using System.Media;
using NAudio.Wave;

namespace RawBankEditor.Tools;

public static class SoundUtils
{
    public const string EWA_EXT = ".EWA";
    public const string WAV_EXT = ".WAV";

    public static void Play(string soundpath)
    {
        if (!File.Exists(soundpath))
            return;

        switch (Path.GetExtension(soundpath).ToUpper())
        {
            case EWA_EXT:
            {
                using var fileStream = new FileStream(soundpath, FileMode.Open);
                using var memoryStream = new MemoryStream();
                using var reader = new BinaryReader(fileStream);
                using var writer = new BinaryWriter(memoryStream);

                EWAtoWAV(reader, writer);

                using var player = new SoundPlayer(memoryStream);
                
                player.Play();
                break;
            }
            case WAV_EXT:
            {
                using var player = new SoundPlayer(soundpath);
                player.Play();
                break;
            }
        }
    }

    private static void ThrowIfInvalid(string inpath, string outpath)
    {
        if (string.IsNullOrEmpty(inpath))
            throw new ArgumentNullException(nameof(inpath));
        if (string.IsNullOrEmpty(outpath))
            throw new ArgumentNullException(nameof(outpath));
        if (!File.Exists(inpath))
            throw new FileNotFoundException("Input file must be exists.", inpath);
    }

    /// <summary>
    ///     Converts .WAV audio file to .EWA encoded file.
    /// </summary>
    /// <param name="inpath">input file (.WAV)</param>
    /// <param name="outpath">output file (.EWA)</param>
    /// <param name="check">whether the format of .WAV file should be checked</param>
    public static void WAVtoEWA(string inpath, string outpath, bool check = false)
    {
        ThrowIfInvalid(inpath, outpath);

        using var inStream = new FileStream(inpath, FileMode.Open, FileAccess.Read);
        using var outStream = new FileStream(outpath, FileMode.Create, FileAccess.Write);
        using var reader = new BinaryReader(inStream);
        using var writer = new BinaryWriter(outStream);

        WAVtoEWA(reader, writer, check);
    }

    /// <summary>
    ///     Converts .EWA encoded file to .WAV audio file.
    /// </summary>
    /// <param name="inpath">input file (.EWA)</param>
    /// <param name="outpath">output file (.WAV)</param>
    /// <param name="check">whether the format of .WAV file should be checked</param>
    public static void EWAtoWAV(string inpath, string outpath, bool check = false)
    {
        ThrowIfInvalid(inpath, outpath);

        using var inStream = new FileStream(inpath, FileMode.Open, FileAccess.Read);
        using var outStream = new FileStream(outpath, FileMode.Create, FileAccess.Write);
        using var reader = new BinaryReader(inStream);
        using var writer = new BinaryWriter(outStream);

        EWAtoWAV(reader, writer, check);
    }

    /// <summary>
    ///     Converts .EWA stream to .WAV stream.
    /// </summary>
    /// <param name="instream">input stream (.WAV)</param>
    /// <param name="outstream">output stream (.EWA)</param>
    /// <param name="check">whether the format of .WAV stream should be checked</param>
    public static void WAVtoEWA(BinaryReader instream, BinaryWriter outstream, bool check = false)
    {
        var rand = new Random();
        var ewaByte = (byte)rand.Next(0xff + 1);

        if (check)
        {
            instream.BaseStream.Position = 0;
            CheckWAV(instream);
        }

        while (instream.BaseStream.Position < instream.BaseStream.Length)
        {
            var pos = instream.BaseStream.Position;
            var b = instream.ReadByte();
            b = (byte)((b + 0x11 * pos) & 0xff);
            b = (byte)(b ^ ewaByte);
            outstream.Write(b);
        }
    }

    /// <summary>
    ///     Converts .EWA stream to .WAV stream.
    /// </summary>
    /// <param name="instream">input stream (.EWA)</param>
    /// <param name="outstream">output stream (.WAV)</param>
    /// <param name="check">whether the format of .WAV stream should be checked</param>
    public static void EWAtoWAV(BinaryReader instream, BinaryWriter outstream, bool check = false)
    {
        var b = instream.ReadByte();
        var ewaByte = (byte)(b ^ 82);
        instream.BaseStream.Position = 0;

        while (instream.BaseStream.Position < instream.BaseStream.Length)
        {
            var pos = instream.BaseStream.Position;
            b = instream.ReadByte();
            b = (byte)(b ^ ewaByte);
            b = (byte)((b - 0x11 * pos) & 0xff);
            outstream.Write(b);
        }

        if (check)
        {
            outstream.BaseStream.Position = 0;
            CheckWAV(instream);
        }
    }

    private static void CheckWAV(BinaryReader reader)
    {
        if (Read4byteString(reader) != "RIFF")
            throw new FormatException("Chybný formát WAV suboru (chýba hlavička RIFF)!");
        if (reader.ReadInt32() != reader.BaseStream.Length - 8)
            throw new FormatException("Chybný formát WAV suboru (chybná dĺžka súboru)");
        if (Read4byteString(reader) != "WAVE")
            throw new FormatException("Chybný formát WAV suboru (nie je typu WAVE)");

        double formatPos = -1;
        var fmtLen = 0;

        while (reader.BaseStream.Length > reader.BaseStream.Position)
        {
            if (Read4byteString(reader) == "fmt ")
            {
                fmtLen = reader.ReadInt32();
                formatPos = reader.BaseStream.Position;
                break;
            }

            reader.BaseStream.Position += reader.ReadInt32();
        }

        if (formatPos < 0)
            throw new FormatException("Chybný formát WAV suboru (nenalezen formát)");
        if (fmtLen < 16)
            throw new FormatException("Chybný formát WAV suboru (fmt chunk má délku menší než 16 bytů)");

        var formatTag = reader.ReadInt16();
        reader.ReadInt16(); //channels
        reader.ReadInt32(); //sample per second
        reader.ReadInt32(); //average bytes per seconds
        reader.ReadInt16(); //block align
        reader.ReadInt16(); //bits per sample

        if (formatTag == -2)
        {
            reader.ReadInt16();
            reader.ReadInt16();
            reader.ReadInt32();
            var b = new Guid(reader.ReadBytes(16));
            if (new Guid("00000001-0000-0010-8000-00AA00389B71") != b)
                throw new FormatException("Chybný formát WAV suboru (neznámy subformát (GUID))");
        }
    }

    private static string Read4byteString(BinaryReader reader)
    {
        var array = new byte[4];
        reader.Read(array, 0, array.Length);
        return Encoding.ASCII.GetString(array, 0, array.Length);
    }

    /// <summary>
    ///     Vrati dlzku zvuku (.WAV|.EWA) v milisekundach (ms)
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static int GetSoundDuration(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentNullException(nameof(fileName));

        switch (Path.GetExtension(fileName).ToUpper())
        {
            case EWA_EXT:
            {
                using var fileStream = new FileStream(fileName, FileMode.Open);
                using var memoryStream = new MemoryStream();
                using var reader = new BinaryReader(fileStream);
                using var writer = new BinaryWriter(memoryStream);

                EWAtoWAV(reader, writer);
                var wreader = new WaveFileReader(memoryStream);
                var span = wreader.TotalTime;
                return (int) span.TotalMilliseconds;
            }
            case WAV_EXT:
            {
                using var wreader = new WaveFileReader(fileName);
                var span = wreader.TotalTime;
                return (int) span.TotalMilliseconds;
            }
            default: 
                return -1;
        }
    }
}

public class SoundReader : IDisposable
{
    public bool IsEwa { get; }

    public byte EwaByte { get; }

    public string FilePath { get; }

    public FileStream Stream { get; }

    public BinaryReader Reader {  get; }

    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public SoundReader(string filePath)
    {
        if (string.IsNullOrEmpty(filePath))
            throw new ArgumentException(nameof(filePath));
        if (!File.Exists(filePath))
            throw new FileNotFoundException("File must be exists.", filePath);

        string extension = Path.GetExtension(filePath).ToUpper();

        IsEwa = extension switch
        {
            SoundUtils.EWA_EXT => true,
            SoundUtils.WAV_EXT => false,
            _ => throw new InvalidFileException(nameof(filePath))
        };

        FilePath = filePath;

        Stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        Reader = new BinaryReader(Stream);

        if (IsEwa)
        {
            var b = Stream.ReadByte();
            EwaByte = (byte)(b ^ 82);
            Reader.BaseStream.Position = 0;
        }
    }

    /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
    public void Dispose()
    {
        Reader.Dispose();
        Stream.Dispose();
    }
}

public class InvalidFileException : Exception
{
    private readonly string filePath;

    public InvalidFileException(string filePath)
    {
        this.filePath = filePath;
    }

    /// <summary>Gets a message that describes the current exception.</summary>
    /// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
    public override string Message => string.IsNullOrEmpty(filePath) ? "" : $"File {filePath} must be a type .WAV or .EWA.";
}