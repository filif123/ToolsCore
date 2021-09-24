using System.Collections.Generic;
using System.Drawing;

namespace ToolsCore.XML
{
    public class ColorCategory
    {
        public string Name { get; set; }
        public Font Font { get; set; }
        public bool DisableFontEdit { get; set; }
        public List<ColorSetting> Settings { get; set; }
        public override string ToString() => Name;
    }
}