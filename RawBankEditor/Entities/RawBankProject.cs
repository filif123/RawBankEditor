using ExControls;
using ToolsCore.Entities;

namespace RawBankEditor.Entities;

public class RawBankProject
{
    public string AbsPathToBank { get; set; }
    public string AbsPathToINISS { get; set; }
    public ExBindingList<FyzLanguage> Languages { get; set; }
}