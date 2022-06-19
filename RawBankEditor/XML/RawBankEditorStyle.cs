using ToolsCore.XML;

namespace RawBankEditor.XML;

/// <summary>
///     Trieda definujuca farby a pisma pre viacere prvky programu
/// </summary>
public class RawBankEditorStyle : Style
{
    /// <inheritdoc />
    public RawBankEditorStyle()
    {
    }

    /// <inheritdoc />
    public RawBankEditorStyle(Style original) : base(original)
    {
    }
    
    public new static RawBankEditorStyle DefaultLightStyle => new(Style.DefaultLightStyle);

    public new static RawBankEditorStyle DefaultDarkStyle=> new(Style.DefaultDarkStyle);
}