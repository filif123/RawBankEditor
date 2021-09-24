using System;
using System.Text;
using RawBankEditor.Tools;
using ToolsCore.Tools;

namespace RawBankEditor.Entities
{
    public sealed class FyzSound
    {
        /// <summary>Initializes a new instance of the <see cref="FyzSound" /> class. Don't use this overload of constructor!</summary>
        public FyzSound()
        {
            Duration = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="FyzSound" /> class.</summary>
        public FyzSound(FyzGroup grp, string key, string name, string fileName, string addiRelativePath, string text, int duration)
        {
            Group = grp;
            Key = key;
            Name = name;
            FileName = fileName;
            AdditionalRelativePath = addiRelativePath;
            Text = text;
            Duration = duration;
        }

        /// <summary>
        ///     Kluc zvuku (v ZvukBase sa neda menit).
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        ///     Nazov zvuku (v ZvukBase sa da menit).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Nazov suboru zvuku (s priponou).
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///     Doplnokova reletavna cesta k suboru, ak sa subor nenachadza .
        /// </summary>
        public string AdditionalRelativePath { get; set; }

        /// <summary>
        ///     Text hlasenia.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     Dlzka zvuku v milisekundach (ms).
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        ///     Dlzka zvuku ako retazec v tvare mm:ss.
        /// </summary>
        public string DurationText => Utils.LengthIntToString(Duration);

        /// <summary>
        ///     Skupina zvokov do ktorej patri tento zvuk.
        /// </summary>
        public FyzGroup Group { get; set; }

        /// <summary>
        ///     Odkaz na fyzicky subor zvuku.
        /// </summary>
        public SoundFileElement File { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Name;
        }

        public string GetAbsPath(string pathToBank = null)
        {
            if (Group == null)
                throw new ArgumentNullException(nameof(Group));
            if (Group.Language == null)
                throw new ArgumentNullException(nameof(Group.Language));
            if (string.IsNullOrEmpty(pathToBank) && string.IsNullOrEmpty(GlobData.AbsPathToBank))
                throw new ArgumentNullException(nameof(GlobData.AbsPathToBank));

            var path = new StringBuilder(pathToBank ?? GlobData.AbsPathToBank);

            path.Append(Group.Language.RelativePath);
            path.Append(RawBankParser.AddPathIsEmpty(AdditionalRelativePath) ? Group.RelativePath : AdditionalRelativePath);
            path.Append(FileName);

            return path.ToString();
        }
    }
}