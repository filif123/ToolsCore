﻿using System.Collections;
using ExControls;
using ToolsCore.XML;

namespace ToolsCore.Tools;

/// <summary>
///     Trieda obsahujúca metódy na správu formularov.
/// </summary>
public static class FormUtils
{
    /// <summary>
    ///     Zmena farebnej schémy dialogu alebo ovladacieho prvku.
    /// </summary>
    /// <param name="c">form alobo ovladaci prvok</param>
    public static void ApplyTheme(this Control c)
    {
        var style = GlobSettings.UsingStyle;
            
        if (c is Form f)
        {
            f.BackColor = style.ControlsColorScheme.Panel.BackColor;
            f.SetImmersiveDarkMode(style.DarkTitleBar);
        }

        ChangeStyleOfControls(style, c.Controls);
    }

    public static void ChangeColorContextMenu(Style style, ContextMenuStrip strip)
    {
        if (style.ControlsDefaultStyle)
        {
            strip.RenderMode = ToolStripRenderMode.Professional;
            strip.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
            return;
        }

        strip.RenderMode = ToolStripRenderMode.Professional;
        strip.Renderer = new MyMenuRenderer(new MyColorTable());

        strip.BackColor = style.ControlsColorScheme.Panel.BackColor;
        strip.ForeColor = style.ControlsColorScheme.Panel.ForeColor;

        SetColorMenuItems(strip.Items);

        void SetColorMenuItems(IEnumerable coll)
        {
            foreach (ToolStripItem toolStripItem in coll)
            {
                toolStripItem.BackColor = style.ControlsColorScheme.Panel.BackColor;
                toolStripItem.ForeColor = style.ControlsColorScheme.Panel.ForeColor;
                if (toolStripItem is ToolStripMenuItem tsmi) SetColorMenuItems(tsmi.DropDown.Items);
            }
        }
    }

    public static void ChangeStyleOfControls(Style style, IEnumerable collection)
    {
        var scheme = style.ControlsColorScheme;
        foreach (Control control in collection)
        {
            switch (control)
            {
                case ExCheckedListBox dclb:
                {
                    dclb.DefaultStyle = style.ControlsDefaultStyle;
                    if (!style.ControlsDefaultStyle)
                    {
                        dclb.BackColor = scheme.Box.BackColor;
                        dclb.ForeColor = scheme.Box.ForeColor;
                        dclb.BorderColor = scheme.Border.ForeColor;
                        dclb.SquareBackColor = scheme.Box.BackColor;
                        dclb.MarkColor = scheme.Mark.ForeColor;
                        dclb.BorderStyle = BorderStyle.None;
                        dclb.FocusedBackColor = scheme.Border.ForeColor;
                        dclb.HighlightColor = scheme.Highlight.BackColor;
                    }

                    if (style.DarkScrollBar) 
                        dclb.SetTheme(WindowsTheme.DarkExplorer);

                    break;
                }
                case ExGroupBox dgb:
                {
                    ChangeStyleOfControls(style, dgb.Controls);
                    dgb.DefaultStyle = style.ControlsDefaultStyle;
                    dgb.BackColor = scheme.Panel.BackColor;
                    dgb.ForeColor = scheme.Panel.ForeColor;
                    dgb.BorderThickness = 1;
                    dgb.BorderColor = scheme.Border.ForeColor;
                    break;
                }
                case ExTableLayoutPanel p:
                {
                    ChangeStyleOfControls(style, control.Controls);
                    control.BackColor = scheme.Panel.BackColor;
                    control.ForeColor = scheme.Panel.ForeColor;
                    p.DefaultStyle = style.ControlsDefaultStyle;
                    if (!p.DefaultStyle && p.CellBorderStyle == TableLayoutPanelCellBorderStyle.Single)
                    {
                        p.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                        p.BorderColor = scheme.Border.ForeColor;
                    }

                    break;
                }
                case Panel:
                {
                    ChangeStyleOfControls(style, control.Controls);
                    control.BackColor = scheme.Panel.BackColor;
                    control.ForeColor = scheme.Panel.ForeColor;
                    break;
                }
                case SplitContainer sc:
                {
                    control.BackColor = scheme.Panel.BackColor;
                    control.ForeColor = scheme.Panel.ForeColor;
                    ChangeStyleOfControls(style, sc.Panel1.Controls);
                    ChangeStyleOfControls(style, sc.Panel2.Controls);
                    break;
                }
                case ExTabControl tab:
                {
                    ChangeStyleOfControls(style, control.Controls);
                    tab.DefaultStyle = style.ControlsDefaultStyle;
                    control.BackColor = scheme.Panel.BackColor;
                    control.ForeColor = scheme.Panel.ForeColor;
                    tab.HeaderBackColor = scheme.Box.BackColor;
                    tab.HeaderForeColor = scheme.Box.ForeColor;
                    tab.ActiveHeaderBackColor = scheme.Panel.BackColor;
                    tab.ActiveHeaderForeColor = scheme.Panel.ForeColor;
                    tab.BorderColor = scheme.Border.ForeColor;
                    tab.HighlightBackColor = scheme.Button.BackColor;
                    tab.HighlightForeColor = scheme.Button.ForeColor;
                    break;
                }
                case ExButton b:
                {
                    b.DefaultStyle = style.ControlsDefaultStyle;
                    if (!style.ControlsDefaultStyle)
                    {
                        control.BackColor = scheme.Button.BackColor;
                        control.ForeColor = scheme.Button.ForeColor;
                        b.ExFlatAppearance.BorderColor = scheme.Border.ForeColor;
                        b.ExFlatAppearance.MouseOverBackColor = scheme.Highlight.BackColor;
                        b.ExFlatAppearance.MouseDownBackColor = scheme.Highlight.BackColor;
                        b.ExFlatAppearance.FocusBorderColor = scheme.Highlight.BackColor;
                    }

                    break;
                }
                case ExLineSeparator dls:
                {
                    dls.LineColor = scheme.Border.ForeColor;
                    break;
                }
                case ExMaskedTextBox tb:
                {
                    tb.DefaultStyle = style.ControlsDefaultStyle;
                    if (!style.ControlsDefaultStyle)
                    {
                        tb.BackColor = scheme.Box.BackColor;
                        tb.ForeColor = scheme.Box.ForeColor;
                        tb.BorderColor = scheme.Border.ForeColor;
                        tb.HighlightColor = scheme.Highlight.BackColor;
                        tb.DisabledBorderColor = scheme.Button.BackColor;
                    }

                    break;
                }
                case ExTextBox tb:
                {
                    tb.BackColor = scheme.Box.BackColor;
                    tb.ForeColor = scheme.Box.ForeColor;
                    tb.BorderColor = scheme.Border.ForeColor;
                    tb.HighlightColor = scheme.Highlight.BackColor;
                    tb.DefaultStyle = style.ControlsDefaultStyle;
                    tb.DisabledBorderColor = scheme.Button.BackColor;
                    tb.DisabledBackColor = scheme.Panel.BackColor;
                    break;
                }
                case RichTextBox tb:
                {
                    if (!style.ControlsDefaultStyle)
                    {
                        tb.BackColor = scheme.Box.BackColor;
                        tb.ForeColor = scheme.Box.ForeColor;
                        tb.BorderStyle = BorderStyle.None;
                    }

                    break;
                }
                case ExNumericUpDown nud:
                {
                    nud.DefaultStyle = style.ControlsDefaultStyle;
                    if (!style.ControlsDefaultStyle)
                    {
                        nud.BackColor = scheme.Box.BackColor;
                        nud.ForeColor = scheme.Box.ForeColor;
                        nud.ArrowsColor = scheme.Button.ForeColor;
                        nud.BorderColor = scheme.Border.ForeColor;
                        nud.HighlightColor = scheme.Highlight.BackColor;
                        nud.SelectedButtonColor = scheme.Highlight.BackColor;
                    }

                    break;
                }
                case ExDateTimePicker dtp:
                {
                    dtp.DefaultStyle = style.ControlsDefaultStyle;
                    dtp.BackColor = scheme.Button.BackColor;
                    dtp.ForeColor = scheme.Button.ForeColor;
                    dtp.BorderColor = scheme.Border.ForeColor;
                    dtp.ArrowColor = scheme.Box.ForeColor;
                    dtp.HighlightColor = scheme.Highlight.BackColor;
                    break;
                }
                case DateTimePicker dtp:
                {
                    dtp.BackColor = scheme.Box.BackColor;
                    dtp.ForeColor = scheme.Box.ForeColor;
                    dtp.CalendarMonthBackground = scheme.Box.BackColor;
                    dtp.CalendarForeColor = scheme.Box.ForeColor;
                    break;
                }
                case LinkLabel ll:
                {
                    ll.LinkColor = scheme.Highlight.BackColor;
                    break;
                }
                case Label l:
                {
                    l.ForeColor = scheme.Label.ForeColor;
                    break;
                }
                case TreeView tv:
                {
                    control.BackColor = scheme.Box.BackColor;
                    control.ForeColor = scheme.Box.ForeColor;
                    if (!style.ControlsDefaultStyle) tv.BorderStyle = BorderStyle.None;

                    if (style.DarkScrollBar) 
                        tv.SetTheme(WindowsTheme.DarkExplorer);

                    break;
                }
                case ListBox lb:
                {
                    control.BackColor = scheme.Box.BackColor;
                    control.ForeColor = scheme.Box.ForeColor;
                    if (!style.ControlsDefaultStyle) lb.BorderStyle = BorderStyle.None;

                    if (style.DarkScrollBar) 
                        lb.SetTheme(WindowsTheme.DarkExplorer);

                    break;
                }
                case ExCheckBox cb:
                {
                    cb.DefaultStyle = style.ControlsDefaultStyle;
                    if (!style.ControlsDefaultStyle)
                    {
                        cb.BorderColor = scheme.Border.ForeColor;
                        cb.BoxBackColor = scheme.Box.BackColor;
                        cb.MarkColor = scheme.Mark.ForeColor;
                        cb.HighlightColor = scheme.Highlight.BackColor;
                    }

                    break;
                }
                case ExComboBox dcombo:
                {
                    dcombo.DefaultStyle = dcombo.DefaultStyle && style.ControlsDefaultStyle;
                    dcombo.UseDarkScrollBar = style.DarkScrollBar;
                    if (!dcombo.DefaultStyle)
                    {
                        dcombo.BackColor = scheme.Box.BackColor;
                        dcombo.ForeColor = scheme.Box.ForeColor;
                        dcombo.DropDownSelectedRowBackColor = scheme.Highlight.BackColor;
                        dcombo.DropDownBackColor = scheme.Panel.BackColor;
                        dcombo.StyleNormal.BorderColor = scheme.Border.ForeColor;
                        dcombo.StyleNormal.ArrowColor = scheme.Box.ForeColor;
                        dcombo.StyleNormal.ButtonBorderColor = scheme.Box.BackColor;
                        dcombo.StyleSelected.BorderColor = scheme.Highlight.BackColor;
                        dcombo.StyleSelected.ButtonRenderFirst = false;
                        dcombo.StyleSelected.ButtonBackColor = scheme.Highlight.BackColor;
                        dcombo.StyleSelected.ButtonBorderColor = scheme.Highlight.BackColor;
                        dcombo.StyleHighlight.BorderColor = scheme.Highlight.BackColor;
                        dcombo.StyleHighlight.ButtonBorderColor = scheme.Highlight.BackColor;
                    }

                    break;
                }
                case ExRadioButton rb:
                {
                    rb.DefaultStyle = style.ControlsDefaultStyle;
                    if (!style.ControlsDefaultStyle)
                    {
                        rb.BorderColor = scheme.Mark.ForeColor;
                        rb.BoxBackColor = scheme.Panel.BackColor;
                        rb.MarkColor = scheme.Mark.ForeColor;
                        rb.HighlightColor = scheme.Highlight.BackColor;
                    }

                    break;
                }
                case MenuStrip ms:
                {
                    if (style.ControlsDefaultStyle)
                    {
                        ms.RenderMode = ToolStripRenderMode.Professional;
                        ms.Renderer = new ToolStripProfessionalRenderer(new LightColorTable());
                    }
                    else
                    {
                        ms.BackColor = scheme.Panel.BackColor;
                        ms.ForeColor = scheme.Panel.ForeColor;
                        ms.RenderMode = ToolStripRenderMode.Professional;
                        ms.Renderer = new MyMenuRenderer(new MyColorTable());
                    }

                    SetColorMenuItems(ms.Items);

                    void SetColorMenuItems(ToolStripItemCollection coll)
                    {
                        foreach (ToolStripItem toolStripItem in coll)
                        {
                            toolStripItem.BackColor = scheme.Panel.BackColor;
                            toolStripItem.ForeColor = scheme.Panel.ForeColor;
                            switch (toolStripItem)
                            {
                                case ToolStripMenuItem tsmi:
                                    SetColorMenuItems(tsmi.DropDown.Items);
                                    break;
                                case ToolStripExComboBox tcb:
                                {
                                    tcb.ComboBox.DefaultStyle = style.ControlsDefaultStyle;
                                    if (!style.ControlsDefaultStyle)
                                    {
                                        tcb.ComboBox.BackColor = scheme.Button.BackColor;
                                        tcb.ComboBox.ForeColor = scheme.Button.ForeColor;
                                        tcb.ComboBox.DropDownSelectedRowBackColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.DropDownBackColor = scheme.Panel.BackColor;
                                        tcb.ComboBox.StyleNormal.BorderColor = scheme.Border.ForeColor;
                                        tcb.ComboBox.StyleNormal.ArrowColor = scheme.Box.ForeColor;
                                        tcb.ComboBox.StyleSelected.BorderColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleHighlight.BorderColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleSelected.ButtonRenderFirst = false;
                                        tcb.ComboBox.StyleSelected.ButtonBackColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleSelected.ButtonBorderColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleHighlight.ButtonBorderColor = scheme.Highlight.BackColor;
                                    }

                                    break;
                                }
                            }
                        }
                    }

                    break;
                }
                case ToolStrip ts:
                {
                    if (style.ControlsDefaultStyle)
                    {
                        ts.RenderMode = ToolStripRenderMode.Professional;
                        ts.Renderer = new MyMenuRenderer(new LightColorTable());
                    }
                    else
                    {
                        ts.BackColor = scheme.Panel.BackColor;
                        ts.ForeColor = scheme.Panel.ForeColor;
                        ts.RenderMode = ToolStripRenderMode.Professional;
                        ts.Renderer = new MyMenuRenderer(new MyColorTable());
                    }


                    SetColorMenuItems(ts.Items);

                    void SetColorMenuItems(ToolStripItemCollection coll)
                    {
                        foreach (ToolStripItem toolStripItem in coll)
                        {
                            toolStripItem.BackColor = scheme.Panel.BackColor;
                            toolStripItem.ForeColor = scheme.Panel.ForeColor;
                            switch (toolStripItem)
                            {
                                case ToolStripMenuItem tsmi:
                                    SetColorMenuItems(tsmi.DropDown.Items);
                                    break;
                                case ToolStripSplitButton tssb:
                                    SetColorMenuItems(tssb.DropDownItems);
                                    break;
                                case ToolStripDropDownButton tsddb:
                                    SetColorMenuItems(tsddb.DropDownItems);
                                    break;
                                case ToolStripExComboBox tcb:
                                    tcb.ComboBox.DefaultStyle = style.ControlsDefaultStyle;
                                    if (!style.ControlsDefaultStyle)
                                    {
                                        tcb.ComboBox.BackColor = scheme.Button.BackColor;
                                        tcb.ComboBox.ForeColor = scheme.Button.ForeColor;
                                        tcb.ComboBox.DropDownSelectedRowBackColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.DropDownBackColor = scheme.Panel.BackColor;
                                        tcb.ComboBox.StyleNormal.BorderColor = scheme.Border.ForeColor;
                                        tcb.ComboBox.StyleNormal.ArrowColor = scheme.Box.ForeColor;
                                        tcb.ComboBox.StyleSelected.BorderColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleHighlight.BorderColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleSelected.ButtonRenderFirst = false;
                                        tcb.ComboBox.StyleSelected.ButtonBackColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleSelected.ButtonBorderColor = scheme.Highlight.BackColor;
                                        tcb.ComboBox.StyleHighlight.ButtonBorderColor = scheme.Highlight.BackColor;
                                    }

                                    break;
                            }
                        }
                    }

                    break;
                }
                case DataGridView dgv:
                {
                    dgv.EnableHeadersVisualStyles = style.ControlsDefaultStyle;

                    if (!style.ControlsDefaultStyle)
                    {
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = scheme.Button.BackColor;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = scheme.Button.ForeColor;
                        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                        dgv.RowHeadersDefaultCellStyle.BackColor = scheme.Button.BackColor;
                        dgv.RowHeadersDefaultCellStyle.ForeColor = scheme.Button.ForeColor;
                        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                        dgv.DefaultCellStyle.BackColor = scheme.Box.BackColor;
                        dgv.DefaultCellStyle.ForeColor = scheme.Box.ForeColor;

                        dgv.ForeColor = scheme.Panel.ForeColor;
                        dgv.BackColor = scheme.Panel.BackColor;
                        dgv.BackgroundColor = scheme.Box.BackColor;
                        dgv.GridColor = scheme.Border.ForeColor;

                        dgv.BorderStyle = BorderStyle.None;
                    }

                    foreach (DataGridViewColumn column in dgv.Columns)
                        switch (column)
                        {
                            case DataGridViewButtonColumn cbutton:
                            {
                                if (!style.ControlsDefaultStyle)
                                {
                                    cbutton.FlatStyle = FlatStyle.Flat;
                                    cbutton.DefaultCellStyle.ForeColor = scheme.Button.ForeColor;
                                    cbutton.DefaultCellStyle.BackColor = scheme.Button.BackColor;
                                    cbutton.DefaultCellStyle.SelectionBackColor = scheme.Highlight.BackColor;
                                    cbutton.DefaultCellStyle.SelectionForeColor = scheme.Highlight.ForeColor;
                                }

                                break;
                            }
                            case DataGridViewExComboBoxColumn dccb:
                            {
                                dccb.DefaultStyle = style.ControlsDefaultStyle;
                                if (!style.ControlsDefaultStyle)
                                {
                                    dccb.DropDownBackColor = scheme.Panel.BackColor;
                                    dccb.DropDownSelectedBackColor = scheme.Highlight.BackColor;
                                    dccb.StyleNormal.ForeColor = scheme.Button.ForeColor;
                                    dccb.StyleNormal.BackColor = scheme.Button.BackColor;
                                    dccb.StyleNormal.BorderColor = scheme.Border.ForeColor;
                                    dccb.StyleNormal.ArrowColor = scheme.Box.ForeColor;
                                    dccb.StyleNormal.ButtonBackColor = scheme.Button.BackColor;
                                    dccb.StyleNormal.ButtonBorderColor = scheme.Button.BackColor;
                                    dccb.StyleSelected.BorderColor = scheme.Highlight.BackColor;
                                    dccb.StyleSelected.ButtonRenderFirst = false;
                                    dccb.StyleSelected.ButtonBackColor = scheme.Highlight.BackColor;
                                    dccb.StyleSelected.ButtonBorderColor = scheme.Highlight.BackColor;
                                    dccb.StyleHighlight.BorderColor = scheme.Highlight.BackColor;
                                    dccb.StyleHighlight.ButtonBorderColor = scheme.Highlight.BackColor;
                                }

                                break;
                            }
                            case DataGridViewExCheckBoxColumn dccb:
                            {
                                dccb.DefaultStyle = style.ControlsDefaultStyle;
                                if (!style.ControlsDefaultStyle)
                                {
                                    dccb.BorderColor = scheme.Border.ForeColor;
                                    dccb.MarkColor = scheme.Mark.ForeColor;
                                    dccb.SquareBackColor = scheme.Panel.BackColor;
                                    dccb.HighlightColor = scheme.Highlight.BackColor;
                                }

                                break;
                            }
                            case DataGridViewCheckBoxColumn ccb:
                            {
                                var template = new DataGridViewExCheckBoxCell
                                {
                                    DefaultStyle = style.ControlsDefaultStyle,
                                    BorderColor = scheme.Border.ForeColor,
                                    MarkColor = scheme.Mark.ForeColor,
                                    SquareBackColor = scheme.Panel.BackColor,
                                    HighlightColor = scheme.Highlight.BackColor
                                };
                                ccb.CellTemplate = template;
                                break;
                            }
                        }

                    if (style.DarkScrollBar)
                        foreach (Control dgvc in dgv.Controls)
                            if (dgvc is ScrollBar sc)
                                sc.SetTheme(WindowsTheme.DarkExplorer);

                    break;
                }
            }

            if (control.ContextMenuStrip is not null)
            {
                ChangeColorContextMenu(style, control.ContextMenuStrip);
            }
        }
    }

    /// <summary>
    ///     Zmení písmo Formu
    /// </summary>
    /// <param name="form">upravovaný Form</param>
    public static void SetFormFont(Form form)
    {
        form.AutoSize = true;
        form.Font = GlobSettings.Fonts.Labels.Font;
        ChangeControlsFont(form.Controls);
    }

    private static void ChangeControlsFont(IEnumerable collection)
    {
        foreach (Control control in collection)
        {
            switch (control)
            {
                case GroupBox:
                    control.Font = GlobSettings.Fonts.Labels.Font;
                    break;
                case Panel:
                    control.Font = GlobSettings.Fonts.Labels.Font;
                    break;
                case TabControl:
                    control.Font = GlobSettings.Fonts.Labels.Font;
                    break;
                case Button:
                    control.Font = GlobSettings.Fonts.Buttons.Font;
                    break;
                case MenuStrip ms:
                    control.Font = GlobSettings.Fonts.Menu.Font;
                    SetFontToolStripItems(ms);
                    break;
                case ToolStrip ts:
                    control.Font = GlobSettings.Fonts.Menu.Font;
                    SetFontToolStripItems(ts);
                    break;
                case DataGridView dgv:
                    dgv.ColumnHeadersDefaultCellStyle.Font = GlobSettings.Fonts.ColsHeader.Font;
                    dgv.DefaultCellStyle.Font = GlobSettings.Fonts.TableCells.Font;
                    break;
            }

            if (control.ContextMenuStrip != null) 
                SetFontToolStripItems(control.ContextMenuStrip);

            ChangeControlsFont(control.Controls);
        }
    }

    private static void SetFontToolStripItems(ToolStrip strip)
    {
        var size = GlobSettings.Fonts.Menu.Font.Height;
        strip.ImageScalingSize = new Size(size, size);

        foreach (ToolStripItem toolStripItem in strip.Items)
        {
            toolStripItem.Font = GlobSettings.Fonts.Menu.Font;
            switch (toolStripItem)
            {
                case ToolStripMenuItem tsmi:
                    SetFontToolStripItems(tsmi.DropDown);
                    break;
                case ToolStripSeparator sep:
                    sep.Size = new Size(6, size + 10);
                    break;
            }
        }
    }

    private class MyColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color MenuBorder => GlobSettings.UsingStyle.ControlsColorScheme.Border.ForeColor;
        public override Color ToolStripBorder => GlobSettings.UsingStyle.ControlsColorScheme.Border.ForeColor;
        public override Color SeparatorDark => GlobSettings.UsingStyle.ControlsColorScheme.Border.ForeColor;
        public override Color SeparatorLight => Color.Transparent;
        public override Color MenuItemBorder => Color.Transparent;
        public override Color GripDark => GlobSettings.UsingStyle.ControlsColorScheme.Border.ForeColor;
        public override Color GripLight => Color.Transparent;
        public override Color MenuStripGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Border.ForeColor;
        public override Color MenuStripGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Border.ForeColor;

        public override Color ToolStripDropDownBackground => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;
        public override Color ToolStripGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;
        public override Color ToolStripGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;
        public override Color ToolStripGradientMiddle => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;

        public override Color MenuItemSelectedGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color MenuItemSelectedGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;

        public override Color MenuItemPressedGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color MenuItemPressedGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;

        public override Color ImageMarginGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;
        public override Color ImageMarginGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;
        public override Color ImageMarginGradientMiddle => GlobSettings.UsingStyle.ControlsColorScheme.Panel.BackColor;

        public override Color ButtonSelectedHighlight => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonSelectedHighlightBorder => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;

        public override Color ButtonSelectedGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonSelectedGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonSelectedGradientMiddle => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonSelectedBorder => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;

        public override Color ButtonPressedGradientBegin => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonPressedGradientEnd => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonPressedGradientMiddle => GlobSettings.UsingStyle.ControlsColorScheme.Highlight.BackColor;
        public override Color ButtonPressedBorder => Color.Transparent;

        public override Color CheckBackground => GlobSettings.UsingStyle.ControlsColorScheme.Button.ForeColor;
    }

    public class LightColorTable : ProfessionalColorTable
    {
        public override Color ImageMarginGradientBegin => Color.White;
        public override Color ImageMarginGradientEnd => Color.White;
        public override Color ImageMarginGradientMiddle => Color.White;
    }

    public class MyMenuRenderer : ToolStripProfessionalRenderer
    {
        public MyMenuRenderer(ProfessionalColorTable table) : base(table)
        {
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            if (e.Item.Enabled) 
                e.ArrowColor = GlobSettings.UsingStyle.ControlsColorScheme.Button.ForeColor;

            base.OnRenderArrow(e);
        }
    }
}