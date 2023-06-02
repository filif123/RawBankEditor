using ExControls;
using ToolsCore.Entities;

namespace RawBankEditor.Entities;

public class RawBankProject
{
    public string AbsPathToBank { get; init; }
    public string AbsPathToINISS { get; init; }
    public ExBindingList<FyzLanguage> Languages { get; init; }
    public Dictionary<FyzLanguage, List<IRawBankMessage>> Messages { get; init; }
}