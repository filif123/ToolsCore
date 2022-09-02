namespace ToolsCore.XML;

public interface IColorScheme
{
    public bool DisableFontEdit { get; }

    public Font Font { get; set; }

    public string Name { get; }
}