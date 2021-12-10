using ToolsCore.XML;

namespace RawBankEditor.XML;

/// <summary>
///     Obsahuje zoznam všetkých možných stĺpcov pre tabuľku na pracovnej ploche programu
/// </summary>
public class DesktopColumns
{
    /*/// <summary>
    ///     Stĺpec Odchod
    /// </summary>
    [XmlElement("Odchod")] public DesktopColumn Odchod = new() { Order = 7, Visible = true, MinWidth = 60 };
    */
        


    /// <summary>
    ///     Vráti zoznam všetkých možnźch stĺpcov pre tabuľku na pracovnej ploche programu
    /// </summary>
    /// <returns></returns>
    public List<DesktopColumn> GetValues()
    {
        return new List<DesktopColumn>();
    }

    /// <summary>
    ///     Vráti zoradený zoznam všetkých možných stĺpcov pre tabuľku na pracovnej ploche programu
    /// </summary>
    /// <returns></returns>
    public List<DesktopColumn> GetOrderedValues()
    {
        var order = GetValues();
        var count = order.Count;

        for (var i = 0; i < count - 1; i++)
        for (var j = 0; j < count - i - 1; j++)
            if (order[j].Order > order[j + 1].Order)
            {
                (order[j], order[j + 1]) = (order[j + 1], order[j]);
            }

        return order;
    }
}