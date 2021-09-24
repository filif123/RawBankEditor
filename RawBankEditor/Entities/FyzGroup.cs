using System;
using System.Text;
using ExControls;

namespace RawBankEditor.Entities
{
    public sealed class FyzGroup
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public FyzGroup(FyzLanguage lang, string key, string name, string relativePath)
        {
            Language = lang;
            Key = key;
            Name = name;
            RelativePath = relativePath;
            Sounds = new ExBindingList<FyzSound>
            {
                Sortable = true
            };
        }

        public FyzGroup(FyzGroup original)
        {
            Language = original.Language;
            Key = string.Copy(original.Key);
            Name = string.Copy(original.Name);
            RelativePath = string.Copy(original.RelativePath);
            Sounds = original.Sounds;
            Sounds.Sortable = true;
        }

        /// <summary>
        ///     Kluc skupiny (v ZvukBase sa neda menit).
        /// </summary>
        public string Key { get; }

        /// <summary>
        ///     Nazov skupiny (v ZvukBase sa da menit).
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Relativna cesta k skupine zvukov.
        /// </summary>
        public string RelativePath { get; }

        /// <summary>
        ///     Zvuky skupiny.
        /// </summary>
        public ExBindingList<FyzSound> Sounds { get; }

        /// <summary>
        ///     Jazyk, ku ktoremu tato skupina zvukov patri.
        /// </summary>
        public FyzLanguage Language { get; set; }

        /// <summary>
        ///     Odkaz na fyzicky priecinok skupiny zvukov.
        /// </summary>
        public DirectoryElement Directory { get; set; }

        public void Add(FyzSound sound)
        {
            Sounds.Add(sound);
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Name;
        }

        public string GetAbsPath(string pathToBank = null)
        {
            if (Language == null)
                throw new ArgumentNullException(nameof(Language));
            if (string.IsNullOrEmpty(pathToBank) && string.IsNullOrEmpty(GlobData.AbsPathToBank))
                throw new ArgumentNullException(nameof(GlobData.AbsPathToBank));

            var path = new StringBuilder(pathToBank ?? GlobData.AbsPathToBank);

            path.Append(Language.RelativePath);
            path.Append(RelativePath);

            return path.ToString();
        }
    }
}