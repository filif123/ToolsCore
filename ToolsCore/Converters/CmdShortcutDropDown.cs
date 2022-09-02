namespace ToolsCore.Converters;

internal partial class CmdShortcutDropDown : UserControl
{
    public CmdShortcutDropDown()
    {
        InitializeComponent();
    }

    private void CmdShortcutDropDown_KeyDown(object sender, KeyEventArgs e)
    {
        /*var keys = e.KeyData;

        if (Utils.ValidateShortcut(keys))
        {
            var sc = (Shortcut) keys;
            shortcuts[shortcutindex].Shortcut = new ShortcutName(sc);
            shortcuts.ResetBindings();

            FindAndCheckDuplicateShortcuts();

            lShortcutHelp.Visible = false;
            shortcutindex = -1;
            lShortcutHelp.Text = lShortcutHelp1;
        }
        else
        {
            lShortcutHelp.Text = lShortcutHelp2;
        }

        e.Handled = true;*/
    }
}