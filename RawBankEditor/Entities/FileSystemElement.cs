using System.Collections.Generic;
using System.IO;
using RawBankEditor.Tools;
using ToolsCore.Tools;

namespace RawBankEditor.Entities
{
    public abstract class FileSystemElement
    {
        protected FileSystemElement(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static implicit operator FileSystemElement(FileSystemInfo fsi)
        {
            switch (fsi)
            {
                case DirectoryInfo di:
                    return new DirectoryElement(di);
                case FileInfo fi:
                    if (fi.Extension.ToUpper() is SoundUtils.WAV_EXT or SoundUtils.EWA_EXT)
                        return new SoundFileElement(fi);
                    else
                        return new OtherFileElement(fi);
                default:
                    return null;
            }
        }
    }

    internal class BackButtonElement : FileSystemElement
    {
        public BackButtonElement(DirectoryElement parent) : base("...")
        {
            ParentDirectory = parent;
        }

        public DirectoryElement ParentDirectory { get; }
    }

    public class DirectoryElement : FileSystemElement
    {
        public DirectoryElement(DirectoryInfo dirinfo) : base(dirinfo.Name)
        {
            DirInfo = dirinfo;
            Children = new List<FileSystemElement>();
            var fis = dirinfo.GetFileSystemInfos();
            for (var i = 0; i < fis.Length; i++)
            {
                var fi = fis[i];
                Children.Add(fi);
                switch (Children[i])
                {
                    case DirectoryElement dir:
                        dir.Parent = this;
                        break;
                    case FileElement fe:
                        fe.Parent = this;
                        break;
                }
            }
        }

        public DirectoryElement(string absPath) : this(new DirectoryInfo(absPath))
        {
        }

        public DirectoryElement Parent { get; set; }

        public DirectoryInfo DirInfo { get; }

        public List<FileSystemElement> Children { get; }

        public int GetCountChildren()
        {
            return Children.Count;
        }
    }

    public abstract class FileElement : FileSystemElement
    {
        protected FileElement(FileInfo fileinfo) : base(fileinfo.Name)
        {
            FileInfo = fileinfo;
        }

        protected FileElement(string absPath) : base(Path.GetFileName(absPath))
        {
            FileInfo = new FileInfo(absPath);
        }

        public FileInfo FileInfo { get; }

        public DirectoryElement Parent { get; set; }
    }

    public class SoundFileElement : FileElement
    {
        public SoundFileElement(FileInfo fileinfo) : base(fileinfo)
        {
            Duration = -1;
        }

        public SoundFileElement(string file) : base(file)
        {
            Duration = -1;
        }

        public int Duration { get; set; }

        public string DurationText => Utils.LengthIntToString(Duration);
    }

    internal class OtherFileElement : FileElement
    {
        public OtherFileElement(FileInfo fileinfo) : base(fileinfo)
        {
        }

        public OtherFileElement(string file) : base(file)
        {
        }
    }
}