using System.Xml.Serialization;
using ToolsCore.XML;

namespace RawBankEditor.XML;

/// <summary>
///     Konfiguracny subor
/// </summary>
[XmlRoot("CONFIG")]
public class RawBankEditorConfig : Config
{
    /// <summary>
    ///     Stlpce zobrazujuce sa v tabulke na pracovnej ploche programu
    /// </summary>
    [XmlElement("DesktopCols")] public DesktopColumns DesktopCols = new();

    /// <summary>
    ///     Klávesové skratky pre akcie na pracovnej ploche programu
    /// </summary>
    [XmlElement("Shortcuts")] public AppShortcuts Shortcuts = new();
}