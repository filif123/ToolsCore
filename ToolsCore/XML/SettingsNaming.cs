using ToolsCore.Properties;

namespace ToolsCore.XML
{
    /// <summary>
    ///     Trieda obsahujuca metody na lokalizane pomenovanie nastaveni.
    /// </summary>
    public static class SettingsNaming
    {
        /// <summary>
        ///     Nazve nastavenia farieb podla aktualnej lokalizacie.
        /// </summary>
        public static void NameColorSettings(Style style)
        {
            style.ControlsColorScheme.Panel.Name = GlobalResources.NameColorSettings_Panel;
            style.ControlsColorScheme.Button.Name = GlobalResources.NameColorSettings_Button;
            style.ControlsColorScheme.Label.Name = GlobalResources.NameColorSettings_Label;
            style.ControlsColorScheme.Box.Name = GlobalResources.NameColorSettings_Box;
            style.ControlsColorScheme.Border.Name = GlobalResources.NameColorSettings_Border;
            style.ControlsColorScheme.Border.DisableBackColorEdit = true;
            style.ControlsColorScheme.Mark.Name = GlobalResources.NameColorSettings_Mark;
            style.ControlsColorScheme.Mark.DisableBackColorEdit = true;
            style.ControlsColorScheme.Highlight.Name = GlobalResources.NameColorSettings_Highlight; 
        }

        /// <summary>
        ///     Pomenuje názvy typov použitia písiem pre rôzne časti formulára.
        /// </summary>
        /// <param name="fonts"></param>
        public static void NameAppFontSetting(ControlFonts fonts)
        {
            fonts.Labels.Name = GlobalResources.NameAppFontSetting_Labels;
            fonts.Buttons.Name = GlobalResources.NameAppFontSetting_Buttons;
            fonts.ColsHeader.Name = GlobalResources.NameAppFontSetting_ChartHeaders;
            fonts.TableCells.Name = GlobalResources.NameAppFontSetting_ChartData;
            fonts.StateRow.Name = GlobalResources.NameAppFontSetting_StateRow;
            fonts.Menu.Name = GlobalResources.NameAppFontSetting_Menu;
        }
    }
}