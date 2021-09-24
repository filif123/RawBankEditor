using System.Collections.Generic;
using ToolsCore.XML;

namespace RawBankEditor.XML
{
    /// <summary>
    ///     Obsahuje zoznam všetkých možných klávesových skratiek pre program
    /// </summary>
    public class AppShortcuts
    {
        //// <summary>
        ////     Skratka pre otvorenie dialógu Nový grafikon
        //// </summary>
        //[XmlElement("NewGVD")] public CommandShortcut NewGVD = new(new ShortcutName(Shortcut.None));

        /// <summary>
        ///     Vráti zoznam všetkých možných klávesových skratiek pre program
        /// </summary>
        /// <returns></returns>
        public List<CommandShortcut> GetValues()
        {
            //TODO make shortcuts
            return new List<CommandShortcut>();
        }
    }
}