using System;
using System.Text;
using ExControls;

namespace RawBankEditor.Entities
{
    public sealed class FyzLanguage
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public FyzLanguage(string key, string fileFyzZvukName, string fyzBankName, string relativePath)
        {
            Key = key;
            FileFyzZvukName = fileFyzZvukName;
            FyzBankName = fyzBankName;
            RelativePath = relativePath;
        }

        /// <summary>
        ///     Kluc jazyka, napr. SK
        /// </summary>
        public string Key { get; }

        /// <summary>
        ///     Nazov suboru s definovanymi zvukmi jazyka. Vacsinou FYZZVUK.DAT.
        /// </summary>
        public string FileFyzZvukName { get; }

        /// <summary>
        ///     Nazov zvukovej banky, napr. Slovencina
        /// </summary>
        public string FyzBankName { get; }

        /// <summary>
        ///     Relativna cesta k jazyku, napr. SK\.
        /// </summary>
        public string RelativePath { get; }

        /// <summary>
        ///     Zoznam skupin zvukov.
        /// </summary>
        public ExBindingList<FyzGroup> Groups { get; set; }

        /// <summary>
        ///     Odkaz na fyzicky priecinok banky zvukov
        /// </summary>
        public DirectoryElement Directory { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return FyzBankName;
        }

        public string GetAbsPath(string pathToBank = null)
        {
            if (string.IsNullOrEmpty(pathToBank) && string.IsNullOrEmpty(GlobData.AbsPathToBank))
                throw new ArgumentNullException(nameof(GlobData.AbsPathToBank));

            var path = new StringBuilder(pathToBank ?? GlobData.AbsPathToBank);

            path.Append(RelativePath);

            return path.ToString();
        }
    }
}