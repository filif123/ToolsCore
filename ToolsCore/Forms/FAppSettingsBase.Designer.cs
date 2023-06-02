using ToolsCore.XML;
using ExControls;
using ToolsCore.Properties;

namespace ToolsCore.Forms
{
    partial class FAppSettingsBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label desktopMenuModeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAppSettingsBase));
            ExControls.OptionsNode optionsNode1 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode2 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode3 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode4 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode5 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode6 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode7 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode8 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode9 = new ExControls.OptionsNode();
            ExControls.OptionsNode optionsNode10 = new ExControls.OptionsNode();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bSave = new ExControls.ExButton();
            this.bStorno = new ExControls.ExButton();
            this.listIcons = new System.Windows.Forms.ImageList(this.components);
            this.optionsView = new ExControls.ExOptionsView();
            this.pGeneral = new ExControls.ExOptionsPanel(this.optionsView);
            this.pConcreteGeneral = new System.Windows.Forms.Panel();
            this.gboxGeneralProgram = new ExControls.ExGroupBox();
            this.cbStartup = new ExControls.ExComboBox();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cboxClassicGui = new ExControls.ExCheckBox();
            this.cboxMultipleInstances = new ExControls.ExCheckBox();
            this.pDesktop = new ExControls.ExOptionsPanel(this.optionsView);
            this.pDesktopComponents = new ExControls.ExOptionsPanel(this.optionsView);
            this.pConcreteDesktopComponents = new System.Windows.Forms.Panel();
            this.ppDesktopComponents = new System.Windows.Forms.Panel();
            this.rbMenuToolStrip = new ExControls.ExRadioButton();
            this.cboxShowRowHeaders = new ExControls.ExCheckBox();
            this.rbMenuOnly = new ExControls.ExRadioButton();
            this.rbToolOnly = new ExControls.ExRadioButton();
            this.pDesktopColumns = new ExControls.ExOptionsPanel(this.optionsView);
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.cColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColVisible = new ExControls.DataGridViewExCheckBoxColumn();
            this.cColMinWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desktopColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bResetColumns = new ExControls.ExButton();
            this.bColDown = new ExControls.ExButton();
            this.bColUp = new ExControls.ExButton();
            this.cboxFitLastCol = new ExControls.ExCheckBox();
            this.pLocalization = new ExControls.ExOptionsPanel(this.optionsView);
            this.pConcreteLocalization = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbAppLanguage = new ExControls.ExComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pShortcuts = new ExControls.ExOptionsPanel(this.optionsView);
            this.dgvShortcuts = new System.Windows.Forms.DataGridView();
            this.cShortcutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cShortcut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cShortcutAttach = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cShortcutDeattach = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cShortcutReset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.commandShortcutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bShortcutsReset = new ExControls.ExButton();
            this.lShortcutMsg = new System.Windows.Forms.Label();
            this.pStyles = new ExControls.ExOptionsPanel(this.optionsView);
            this.ppStyles = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbStyles = new ExControls.ExToolStripComboBox();
            this.tsbApplyStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddStyle = new System.Windows.Forms.ToolStripButton();
            this.tsbRenameStyle = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbResetStyle = new System.Windows.Forms.ToolStripButton();
            this.exGroupBox1 = new ExControls.ExGroupBox();
            this.lFontStyleExample = new System.Windows.Forms.Label();
            this.tvStyles = new ExControls.ExTreeView();
            this.gbColorItemSettings = new ExControls.ExGroupBox();
            this.bResetColorSetting = new ExControls.ExButton();
            this.cboxBold = new ExControls.ExCheckBox();
            this.csForeColor = new ExControls.ExColorSelector();
            this.lStyleBackColor = new ExControls.ExLabel();
            this.lStyleForeColor = new ExControls.ExLabel();
            this.csBackColor = new ExControls.ExColorSelector();
            this.gbCategorySettings = new ExControls.ExGroupBox();
            this.label8 = new ExControls.ExLabel();
            this.cbFont = new ExControls.ExComboBox();
            this.nudFontSize = new ExControls.ExNumericUpDown();
            this.cboxOnlyNonPropFont = new ExControls.ExCheckBox();
            this.exGroupBox8 = new ExControls.ExGroupBox();
            this.cboxHighlightStatusBar = new ExControls.ExCheckBox();
            this.cboxDarkScrollbars = new ExControls.ExCheckBox();
            this.cboxDarkTitlebar = new ExControls.ExCheckBox();
            this.cboxDefaultVisual = new ExControls.ExCheckBox();
            this.pFonts = new ExControls.ExOptionsPanel(this.optionsView);
            this.pgFonts = new ExControls.ExPropertyGrid();
            this.exGroupBox3 = new ExControls.ExGroupBox();
            this.lFontExample = new System.Windows.Forms.Label();
            this.pEnvironment = new ExControls.ExOptionsPanel(this.optionsView);
            this.pLogging = new ExControls.ExOptionsPanel(this.optionsView);
            this.ppLogging = new System.Windows.Forms.Panel();
            this.cbShowErrors = new ExControls.ExComboBox();
            this.gbLogging = new ExControls.ExGroupBox();
            this.cboxLoggingInfo = new ExControls.ExCheckBox();
            this.cboxLoggingError = new ExControls.ExCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.appLanguageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debugModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            desktopMenuModeLabel = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsView)).BeginInit();
            this.pGeneral.SuspendLayout();
            this.gboxGeneralProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            this.pDesktopComponents.SuspendLayout();
            this.ppDesktopComponents.SuspendLayout();
            this.pDesktopColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopColumnBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.pLocalization.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortcuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandShortcutBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pStyles.SuspendLayout();
            this.ppStyles.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.exGroupBox1.SuspendLayout();
            this.gbColorItemSettings.SuspendLayout();
            this.gbCategorySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.exGroupBox8.SuspendLayout();
            this.pFonts.SuspendLayout();
            this.pgFonts.SuspendLayout();
            this.exGroupBox3.SuspendLayout();
            this.pLogging.SuspendLayout();
            this.ppLogging.SuspendLayout();
            this.gbLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLanguageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugModeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // desktopMenuModeLabel
            // 
            desktopMenuModeLabel.AutoSize = true;
            desktopMenuModeLabel.Location = new System.Drawing.Point(13, 14);
            desktopMenuModeLabel.Name = "desktopMenuModeLabel";
            desktopMenuModeLabel.Size = new System.Drawing.Size(71, 15);
            desktopMenuModeLabel.TabIndex = 1;
            desktopMenuModeLabel.Text = "Zobrazovať:";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.bSave);
            this.panelBottom.Controls.Add(this.bStorno);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 440);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(826, 35);
            this.panelBottom.TabIndex = 3;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(658, 6);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Uložiť";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // bStorno
            // 
            this.bStorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bStorno.Location = new System.Drawing.Point(739, 6);
            this.bStorno.Name = "bStorno";
            this.bStorno.Size = new System.Drawing.Size(75, 23);
            this.bStorno.TabIndex = 2;
            this.bStorno.Text = "Zrušiť";
            this.bStorno.UseVisualStyleBackColor = true;
            this.bStorno.Click += new System.EventHandler(this.BStorno_Click);
            // 
            // listIcons
            // 
            this.listIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listIcons.ImageStream")));
            this.listIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.listIcons.Images.SetKeyName(0, "general.png");
            this.listIcons.Images.SetKeyName(1, "environment.png");
            this.listIcons.Images.SetKeyName(2, "desktop.png");
            this.listIcons.Images.SetKeyName(3, "columns.png");
            this.listIcons.Images.SetKeyName(4, "localization.png");
            this.listIcons.Images.SetKeyName(5, "shortcut.png");
            this.listIcons.Images.SetKeyName(6, "colors.png");
            this.listIcons.Images.SetKeyName(7, "font.png");
            this.listIcons.Images.SetKeyName(8, "debugging.png");
            this.listIcons.Images.SetKeyName(9, "start.png");
            // 
            // optionsView
            // 
            this.optionsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsView.HeaderNodeNameBackColor = System.Drawing.SystemColors.Control;
            this.optionsView.HeaderNodeNameFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsView.HeaderNodeNameForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsView.LinkToChildrenForeColor = System.Drawing.Color.Empty;
            this.optionsView.Location = new System.Drawing.Point(0, 0);
            this.optionsView.Name = "optionsView";
            this.optionsView.Padding = new System.Windows.Forms.Padding(5);
            this.optionsView.Panels.Add(this.pGeneral);
            this.optionsView.Panels.Add(this.pDesktop);
            this.optionsView.Panels.Add(this.pDesktopComponents);
            this.optionsView.Panels.Add(this.pDesktopColumns);
            this.optionsView.Panels.Add(this.pLocalization);
            this.optionsView.Panels.Add(this.pShortcuts);
            this.optionsView.Panels.Add(this.pStyles);
            this.optionsView.Panels.Add(this.pFonts);
            this.optionsView.Panels.Add(this.pEnvironment);
            this.optionsView.Panels.Add(this.pLogging);
            this.optionsView.Size = new System.Drawing.Size(826, 440);
            this.optionsView.TabIndex = 0;
            // 
            // optionsView.ToolStripMenu
            // 
            this.optionsView.ToolStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.optionsView.ToolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsView.ToolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.optionsView.ToolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.optionsView.ToolStripMenu.Location = new System.Drawing.Point(442, 0);
            this.optionsView.ToolStripMenu.Name = "ToolStripMenu";
            this.optionsView.ToolStripMenu.Size = new System.Drawing.Size(102, 25);
            this.optionsView.ToolStripMenu.TabIndex = 1;
            this.optionsView.ToolStripMenu.Text = "toolStrip1";
            // 
            // 
            // 
            this.optionsView.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsView.TreeView.FullRowSelect = true;
            this.optionsView.TreeView.HideSelection = false;
            this.optionsView.TreeView.ImageIndex = 0;
            this.optionsView.TreeView.ImageList = this.listIcons;
            this.optionsView.TreeView.ItemHeight = 22;
            this.optionsView.TreeView.Name = "treeView";
            this.optionsView.TreeView.PathSeparator = " / ";
            this.optionsView.TreeView.SelectedImageIndex = 0;
            this.optionsView.TreeView.ShowLines = false;
            this.optionsView.TreeView.ShowNodeToolTips = true;
            this.optionsView.TreeView.Style = ExControls.ExTreeViewStyle.Light;
            this.optionsView.TreeView.TabIndex = 0;
            // 
            // pGeneral
            // 
            this.pGeneral.Controls.Add(this.pConcreteGeneral);
            this.pGeneral.Controls.Add(this.gboxGeneralProgram);
            this.pGeneral.Name = "pGeneral";
            optionsNode1.ImageKey = "general.png";
            optionsNode1.Name = "";
            optionsNode1.SelectedImageKey = "general.png";
            optionsNode1.Text = "Všeobecné";
            this.pGeneral.Node = optionsNode1;
            this.pGeneral.NodeText = "Všeobecné";
            this.pGeneral.ParentNode = null;
            // 
            // pConcreteGeneral
            // 
            this.pConcreteGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConcreteGeneral.Location = new System.Drawing.Point(0, 108);
            this.pConcreteGeneral.Name = "pConcreteGeneral";
            this.pConcreteGeneral.Size = new System.Drawing.Size(538, 291);
            this.pConcreteGeneral.TabIndex = 0;
            // 
            // gboxGeneralProgram
            // 
            this.gboxGeneralProgram.AutoSize = true;
            this.gboxGeneralProgram.Controls.Add(this.cbStartup);
            this.gboxGeneralProgram.Controls.Add(this.label3);
            this.gboxGeneralProgram.Controls.Add(this.cboxClassicGui);
            this.gboxGeneralProgram.Controls.Add(this.cboxMultipleInstances);
            this.gboxGeneralProgram.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.gboxGeneralProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxGeneralProgram.Location = new System.Drawing.Point(0, 0);
            this.gboxGeneralProgram.Name = "gboxGeneralProgram";
            this.gboxGeneralProgram.Size = new System.Drawing.Size(538, 108);
            this.gboxGeneralProgram.TabIndex = 0;
            this.gboxGeneralProgram.TabStop = false;
            this.gboxGeneralProgram.Text = "Všeobecné";
            // 
            // cbStartup
            // 
            this.cbStartup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.configBindingSource, "Startup", true));
            this.cbStartup.DropDownSelectedRowBackColor = System.Drawing.SystemColors.Highlight;
            this.cbStartup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartup.FormattingEnabled = true;
            this.cbStartup.Location = new System.Drawing.Point(158, 68);
            this.cbStartup.Name = "cbStartup";
            this.cbStartup.Size = new System.Drawing.Size(188, 21);
            this.cbStartup.StyleDisabled.ArrowColor = null;
            this.cbStartup.StyleDisabled.BackColor = null;
            this.cbStartup.StyleDisabled.BorderColor = null;
            this.cbStartup.StyleDisabled.ButtonBackColor = null;
            this.cbStartup.StyleDisabled.ButtonBorderColor = null;
            this.cbStartup.StyleDisabled.ButtonRenderFirst = null;
            this.cbStartup.StyleDisabled.ForeColor = null;
            this.cbStartup.StyleHighlight.ArrowColor = null;
            this.cbStartup.StyleHighlight.BackColor = null;
            this.cbStartup.StyleHighlight.BorderColor = null;
            this.cbStartup.StyleHighlight.ButtonBackColor = null;
            this.cbStartup.StyleHighlight.ButtonBorderColor = null;
            this.cbStartup.StyleHighlight.ButtonRenderFirst = null;
            this.cbStartup.StyleHighlight.ForeColor = null;
            this.cbStartup.StyleNormal.ArrowColor = null;
            this.cbStartup.StyleNormal.BackColor = null;
            this.cbStartup.StyleNormal.BorderColor = null;
            this.cbStartup.StyleNormal.ButtonBackColor = null;
            this.cbStartup.StyleNormal.ButtonBorderColor = null;
            this.cbStartup.StyleNormal.ButtonRenderFirst = null;
            this.cbStartup.StyleNormal.ForeColor = null;
            this.cbStartup.StyleSelected.ArrowColor = null;
            this.cbStartup.StyleSelected.BackColor = null;
            this.cbStartup.StyleSelected.BorderColor = null;
            this.cbStartup.StyleSelected.ButtonBackColor = null;
            this.cbStartup.StyleSelected.ButtonBorderColor = null;
            this.cbStartup.StyleSelected.ButtonRenderFirst = null;
            this.cbStartup.StyleSelected.ForeColor = null;
            this.cbStartup.TabIndex = 4;
            this.cbStartup.UseDarkScrollBar = false;
            // 
            // configBindingSource
            // 
            this.configBindingSource.DataSource = typeof(ToolsCore.XML.ConfigBase);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pri spustení programu otvoriť:";
            // 
            // cboxClassicGui
            // 
            this.cboxClassicGui.AutoSize = true;
            this.cboxClassicGui.BoxBackColor = System.Drawing.Color.White;
            this.cboxClassicGui.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configBindingSource, "ClassicGUI", true));
            this.cboxClassicGui.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxClassicGui.Location = new System.Drawing.Point(7, 43);
            this.cboxClassicGui.Name = "cboxClassicGui";
            this.cboxClassicGui.Size = new System.Drawing.Size(255, 19);
            this.cboxClassicGui.TabIndex = 0;
            this.cboxClassicGui.Text = "Používať klasický dizajn ovládacích prvkov";
            // 
            // cboxMultipleInstances
            // 
            this.cboxMultipleInstances.AutoSize = true;
            this.cboxMultipleInstances.BoxBackColor = System.Drawing.Color.White;
            this.cboxMultipleInstances.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configBindingSource, "MoreInstance", true));
            this.cboxMultipleInstances.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxMultipleInstances.Location = new System.Drawing.Point(7, 20);
            this.cboxMultipleInstances.Name = "cboxMultipleInstances";
            this.cboxMultipleInstances.Size = new System.Drawing.Size(231, 19);
            this.cboxMultipleInstances.TabIndex = 0;
            this.cboxMultipleInstances.Text = "Povoliť duplicitné inštancie programu";
            // 
            // pDesktop
            // 
            this.pDesktop.GenerateLinksToChildren = true;
            this.pDesktop.Name = "pDesktop";
            optionsNode2.ImageKey = "desktop.png";
            optionsNode2.Name = "";
            optionsNode2.SelectedImageKey = "desktop.png";
            optionsNode2.Text = "Pracovná plocha";
            this.pDesktop.Node = optionsNode2;
            this.pDesktop.NodeText = "Pracovná plocha";
            optionsNode3.ImageKey = "environment.png";
            optionsNode3.Name = "";
            optionsNode3.SelectedImageKey = "environment.png";
            optionsNode3.Text = "Prostredie";
            this.pDesktop.ParentNode = optionsNode3;
            // 
            // pDesktopComponents
            // 
            this.pDesktopComponents.Controls.Add(this.pConcreteDesktopComponents);
            this.pDesktopComponents.Controls.Add(this.ppDesktopComponents);
            this.pDesktopComponents.Name = "pDesktopComponents";
            optionsNode4.ImageKey = "desktop.png";
            optionsNode4.Name = "";
            optionsNode4.SelectedImageKey = "desktop.png";
            optionsNode4.Text = "Komponenty";
            this.pDesktopComponents.Node = optionsNode4;
            this.pDesktopComponents.NodeText = "Komponenty";
            this.pDesktopComponents.ParentNode = optionsNode2;
            // 
            // pConcreteDesktopComponents
            // 
            this.pConcreteDesktopComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConcreteDesktopComponents.Location = new System.Drawing.Point(0, 69);
            this.pConcreteDesktopComponents.Name = "pConcreteDesktopComponents";
            this.pConcreteDesktopComponents.Size = new System.Drawing.Size(538, 330);
            this.pConcreteDesktopComponents.TabIndex = 8;
            // 
            // ppDesktopComponents
            // 
            this.ppDesktopComponents.AutoSize = true;
            this.ppDesktopComponents.Controls.Add(desktopMenuModeLabel);
            this.ppDesktopComponents.Controls.Add(this.rbMenuToolStrip);
            this.ppDesktopComponents.Controls.Add(this.cboxShowRowHeaders);
            this.ppDesktopComponents.Controls.Add(this.rbMenuOnly);
            this.ppDesktopComponents.Controls.Add(this.rbToolOnly);
            this.ppDesktopComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.ppDesktopComponents.Location = new System.Drawing.Point(0, 0);
            this.ppDesktopComponents.Name = "ppDesktopComponents";
            this.ppDesktopComponents.Size = new System.Drawing.Size(538, 69);
            this.ppDesktopComponents.TabIndex = 7;
            // 
            // rbMenuToolStrip
            // 
            this.rbMenuToolStrip.AutoSize = true;
            this.rbMenuToolStrip.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbMenuToolStrip.Location = new System.Drawing.Point(93, 12);
            this.rbMenuToolStrip.Name = "rbMenuToolStrip";
            this.rbMenuToolStrip.Size = new System.Drawing.Size(150, 19);
            this.rbMenuToolStrip.TabIndex = 2;
            this.rbMenuToolStrip.TabStop = true;
            this.rbMenuToolStrip.Text = "MenuStrip aj ToolStrip";
            this.rbMenuToolStrip.UseVisualStyleBackColor = true;
            // 
            // cboxShowRowHeaders
            // 
            this.cboxShowRowHeaders.AutoSize = true;
            this.cboxShowRowHeaders.BoxBackColor = System.Drawing.Color.White;
            this.cboxShowRowHeaders.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configBindingSource, "ShowRowsHeader", true));
            this.cboxShowRowHeaders.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxShowRowHeaders.Location = new System.Drawing.Point(16, 47);
            this.cboxShowRowHeaders.Name = "cboxShowRowHeaders";
            this.cboxShowRowHeaders.Size = new System.Drawing.Size(231, 19);
            this.cboxShowRowHeaders.TabIndex = 6;
            this.cboxShowRowHeaders.Text = "Zobrazovať hlavičku riadkov v tabuľke";
            // 
            // rbMenuOnly
            // 
            this.rbMenuOnly.AutoSize = true;
            this.rbMenuOnly.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbMenuOnly.Location = new System.Drawing.Point(255, 12);
            this.rbMenuOnly.Name = "rbMenuOnly";
            this.rbMenuOnly.Size = new System.Drawing.Size(109, 19);
            this.rbMenuOnly.TabIndex = 3;
            this.rbMenuOnly.TabStop = true;
            this.rbMenuOnly.Text = "Len MenuStrip";
            this.rbMenuOnly.UseVisualStyleBackColor = true;
            // 
            // rbToolOnly
            // 
            this.rbToolOnly.AutoSize = true;
            this.rbToolOnly.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbToolOnly.Location = new System.Drawing.Point(381, 12);
            this.rbToolOnly.Name = "rbToolOnly";
            this.rbToolOnly.Size = new System.Drawing.Size(101, 19);
            this.rbToolOnly.TabIndex = 4;
            this.rbToolOnly.TabStop = true;
            this.rbToolOnly.Text = "Len ToolStrip";
            this.rbToolOnly.UseVisualStyleBackColor = true;
            // 
            // pDesktopColumns
            // 
            this.pDesktopColumns.Controls.Add(this.dgvColumns);
            this.pDesktopColumns.Controls.Add(this.panel2);
            this.pDesktopColumns.Name = "pDesktopColumns";
            optionsNode5.ImageKey = "columns.png";
            optionsNode5.Name = "";
            optionsNode5.SelectedImageKey = "columns.png";
            optionsNode5.Text = "Stĺpce";
            this.pDesktopColumns.Node = optionsNode5;
            this.pDesktopColumns.NodeText = "Stĺpce";
            this.pDesktopColumns.ParentNode = optionsNode2;
            // 
            // dgvColumns
            // 
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            this.dgvColumns.AllowUserToResizeRows = false;
            this.dgvColumns.AutoGenerateColumns = false;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cColName,
            this.cColVisible,
            this.cColMinWidth});
            this.dgvColumns.DataSource = this.desktopColumnBindingSource;
            this.dgvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumns.Location = new System.Drawing.Point(0, 33);
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.RowHeadersVisible = false;
            this.dgvColumns.RowHeadersWidth = 51;
            this.dgvColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColumns.Size = new System.Drawing.Size(538, 366);
            this.dgvColumns.TabIndex = 1;
            // 
            // cColName
            // 
            this.cColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cColName.DataPropertyName = "Name";
            this.cColName.HeaderText = "Názov";
            this.cColName.MinimumWidth = 6;
            this.cColName.Name = "cColName";
            this.cColName.ReadOnly = true;
            this.cColName.Width = 70;
            // 
            // cColVisible
            // 
            this.cColVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cColVisible.DataPropertyName = "Visible";
            this.cColVisible.HeaderText = "Viditeľný";
            this.cColVisible.MinimumWidth = 6;
            this.cColVisible.Name = "cColVisible";
            this.cColVisible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cColVisible.SquareBackColor = System.Drawing.Color.White;
            this.cColVisible.Width = 59;
            // 
            // cColMinWidth
            // 
            this.cColMinWidth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cColMinWidth.DataPropertyName = "MinWidth";
            this.cColMinWidth.HeaderText = "Minimálna šírka (px)";
            this.cColMinWidth.MinimumWidth = 6;
            this.cColMinWidth.Name = "cColMinWidth";
            // 
            // desktopColumnBindingSource
            // 
            this.desktopColumnBindingSource.DataSource = typeof(ToolsCore.XML.DesktopColumn);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bResetColumns);
            this.panel2.Controls.Add(this.bColDown);
            this.panel2.Controls.Add(this.bColUp);
            this.panel2.Controls.Add(this.cboxFitLastCol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 33);
            this.panel2.TabIndex = 2;
            // 
            // bResetColumns
            // 
            this.bResetColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetColumns.Location = new System.Drawing.Point(463, 3);
            this.bResetColumns.Name = "bResetColumns";
            this.bResetColumns.Size = new System.Drawing.Size(75, 23);
            this.bResetColumns.TabIndex = 3;
            this.bResetColumns.Text = "Resetovať";
            this.bResetColumns.UseVisualStyleBackColor = true;
            this.bResetColumns.Click += new System.EventHandler(this.BResetColumns_Click);
            // 
            // bColDown
            // 
            this.bColDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bColDown.Location = new System.Drawing.Point(365, 3);
            this.bColDown.Name = "bColDown";
            this.bColDown.Size = new System.Drawing.Size(48, 23);
            this.bColDown.TabIndex = 2;
            this.bColDown.Text = "↓";
            this.bColDown.UseVisualStyleBackColor = true;
            this.bColDown.Click += new System.EventHandler(this.BColDown_Click);
            // 
            // bColUp
            // 
            this.bColUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bColUp.Location = new System.Drawing.Point(311, 3);
            this.bColUp.Name = "bColUp";
            this.bColUp.Size = new System.Drawing.Size(48, 23);
            this.bColUp.TabIndex = 1;
            this.bColUp.Text = "↑";
            this.bColUp.UseVisualStyleBackColor = true;
            this.bColUp.Click += new System.EventHandler(this.BColUp_Click);
            // 
            // cboxFitLastCol
            // 
            this.cboxFitLastCol.AutoSize = true;
            this.cboxFitLastCol.BoxBackColor = System.Drawing.Color.White;
            this.cboxFitLastCol.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configBindingSource, "FitLastColumn", true));
            this.cboxFitLastCol.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxFitLastCol.Location = new System.Drawing.Point(3, 9);
            this.cboxFitLastCol.Name = "cboxFitLastCol";
            this.cboxFitLastCol.Size = new System.Drawing.Size(178, 19);
            this.cboxFitLastCol.TabIndex = 0;
            this.cboxFitLastCol.Text = "Prispôsobiť posledný stĺpec";
            // 
            // pLocalization
            // 
            this.pLocalization.Controls.Add(this.pConcreteLocalization);
            this.pLocalization.Controls.Add(this.panel3);
            this.pLocalization.Name = "pLocalization";
            optionsNode6.ImageKey = "localization.png";
            optionsNode6.Name = "";
            optionsNode6.SelectedImageKey = "localization.png";
            optionsNode6.Text = "Lokalizácia";
            this.pLocalization.Node = optionsNode6;
            this.pLocalization.NodeText = "Lokalizácia";
            this.pLocalization.ParentNode = optionsNode3;
            // 
            // pConcreteLocalization
            // 
            this.pConcreteLocalization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pConcreteLocalization.Location = new System.Drawing.Point(0, 52);
            this.pConcreteLocalization.Name = "pConcreteLocalization";
            this.pConcreteLocalization.Size = new System.Drawing.Size(538, 347);
            this.pConcreteLocalization.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.cbAppLanguage);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 52);
            this.panel3.TabIndex = 0;
            // 
            // cbAppLanguage
            // 
            this.cbAppLanguage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.configBindingSource, "Language", true));
            this.cbAppLanguage.DropDownSelectedRowBackColor = System.Drawing.SystemColors.Highlight;
            this.cbAppLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppLanguage.FormattingEnabled = true;
            this.cbAppLanguage.Location = new System.Drawing.Point(6, 28);
            this.cbAppLanguage.Name = "cbAppLanguage";
            this.cbAppLanguage.Size = new System.Drawing.Size(202, 21);
            this.cbAppLanguage.StyleDisabled.ArrowColor = null;
            this.cbAppLanguage.StyleDisabled.BackColor = null;
            this.cbAppLanguage.StyleDisabled.BorderColor = null;
            this.cbAppLanguage.StyleDisabled.ButtonBackColor = null;
            this.cbAppLanguage.StyleDisabled.ButtonBorderColor = null;
            this.cbAppLanguage.StyleDisabled.ButtonRenderFirst = null;
            this.cbAppLanguage.StyleDisabled.ForeColor = null;
            this.cbAppLanguage.StyleHighlight.ArrowColor = null;
            this.cbAppLanguage.StyleHighlight.BackColor = null;
            this.cbAppLanguage.StyleHighlight.BorderColor = null;
            this.cbAppLanguage.StyleHighlight.ButtonBackColor = null;
            this.cbAppLanguage.StyleHighlight.ButtonBorderColor = null;
            this.cbAppLanguage.StyleHighlight.ButtonRenderFirst = null;
            this.cbAppLanguage.StyleHighlight.ForeColor = null;
            this.cbAppLanguage.StyleNormal.ArrowColor = null;
            this.cbAppLanguage.StyleNormal.BackColor = null;
            this.cbAppLanguage.StyleNormal.BorderColor = null;
            this.cbAppLanguage.StyleNormal.ButtonBackColor = null;
            this.cbAppLanguage.StyleNormal.ButtonBorderColor = null;
            this.cbAppLanguage.StyleNormal.ButtonRenderFirst = null;
            this.cbAppLanguage.StyleNormal.ForeColor = null;
            this.cbAppLanguage.StyleSelected.ArrowColor = null;
            this.cbAppLanguage.StyleSelected.BackColor = null;
            this.cbAppLanguage.StyleSelected.BorderColor = null;
            this.cbAppLanguage.StyleSelected.ButtonBackColor = null;
            this.cbAppLanguage.StyleSelected.ButtonBorderColor = null;
            this.cbAppLanguage.StyleSelected.ButtonRenderFirst = null;
            this.cbAppLanguage.StyleSelected.ForeColor = null;
            this.cbAppLanguage.TabIndex = 1;
            this.cbAppLanguage.UseDarkScrollBar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jazyk používateľského rozhrania:";
            // 
            // pShortcuts
            // 
            this.pShortcuts.Controls.Add(this.dgvShortcuts);
            this.pShortcuts.Controls.Add(this.panel1);
            this.pShortcuts.Name = "pShortcuts";
            optionsNode7.ImageKey = "shortcut.png";
            optionsNode7.Name = "";
            optionsNode7.SelectedImageKey = "shortcut.png";
            optionsNode7.Text = "Klávesové skratky";
            this.pShortcuts.Node = optionsNode7;
            this.pShortcuts.NodeText = "Klávesové skratky";
            this.pShortcuts.ParentNode = optionsNode3;
            // 
            // dgvShortcuts
            // 
            this.dgvShortcuts.AllowUserToAddRows = false;
            this.dgvShortcuts.AllowUserToDeleteRows = false;
            this.dgvShortcuts.AllowUserToResizeRows = false;
            this.dgvShortcuts.AutoGenerateColumns = false;
            this.dgvShortcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShortcuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cShortcutName,
            this.cShortcut,
            this.cShortcutAttach,
            this.cShortcutDeattach,
            this.cShortcutReset});
            this.dgvShortcuts.DataSource = this.commandShortcutBindingSource;
            this.dgvShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShortcuts.Location = new System.Drawing.Point(0, 32);
            this.dgvShortcuts.Name = "dgvShortcuts";
            this.dgvShortcuts.ReadOnly = true;
            this.dgvShortcuts.RowHeadersVisible = false;
            this.dgvShortcuts.RowHeadersWidth = 51;
            this.dgvShortcuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShortcuts.Size = new System.Drawing.Size(538, 367);
            this.dgvShortcuts.TabIndex = 1;
            this.dgvShortcuts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShortcuts_CellContentClick);
            // 
            // cShortcutName
            // 
            this.cShortcutName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cShortcutName.DataPropertyName = "Name";
            this.cShortcutName.Frozen = true;
            this.cShortcutName.HeaderText = "Názov";
            this.cShortcutName.MinimumWidth = 6;
            this.cShortcutName.Name = "cShortcutName";
            this.cShortcutName.ReadOnly = true;
            this.cShortcutName.Width = 70;
            // 
            // cShortcut
            // 
            this.cShortcut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cShortcut.DataPropertyName = "Shortcut";
            this.cShortcut.Frozen = true;
            this.cShortcut.HeaderText = "Skratka";
            this.cShortcut.MinimumWidth = 6;
            this.cShortcut.Name = "cShortcut";
            this.cShortcut.ReadOnly = true;
            this.cShortcut.Width = 77;
            // 
            // cShortcutAttach
            // 
            this.cShortcutAttach.HeaderText = "Priradiť";
            this.cShortcutAttach.MinimumWidth = 6;
            this.cShortcutAttach.Name = "cShortcutAttach";
            this.cShortcutAttach.ReadOnly = true;
            this.cShortcutAttach.Text = "Priradiť";
            this.cShortcutAttach.UseColumnTextForButtonValue = true;
            this.cShortcutAttach.Width = 125;
            // 
            // cShortcutDeattach
            // 
            this.cShortcutDeattach.HeaderText = "Odobrať";
            this.cShortcutDeattach.MinimumWidth = 6;
            this.cShortcutDeattach.Name = "cShortcutDeattach";
            this.cShortcutDeattach.ReadOnly = true;
            this.cShortcutDeattach.Text = "Odobrať";
            this.cShortcutDeattach.UseColumnTextForButtonValue = true;
            this.cShortcutDeattach.Width = 125;
            // 
            // cShortcutReset
            // 
            this.cShortcutReset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cShortcutReset.HeaderText = "Resetovať";
            this.cShortcutReset.MinimumWidth = 6;
            this.cShortcutReset.Name = "cShortcutReset";
            this.cShortcutReset.ReadOnly = true;
            this.cShortcutReset.Text = "Resetovať";
            this.cShortcutReset.UseColumnTextForButtonValue = true;
            // 
            // commandShortcutBindingSource
            // 
            this.commandShortcutBindingSource.DataSource = typeof(ToolsCore.XML.CmdShortcut);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bShortcutsReset);
            this.panel1.Controls.Add(this.lShortcutMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 32);
            this.panel1.TabIndex = 0;
            // 
            // bShortcutsReset
            // 
            this.bShortcutsReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShortcutsReset.Location = new System.Drawing.Point(421, 3);
            this.bShortcutsReset.Name = "bShortcutsReset";
            this.bShortcutsReset.Size = new System.Drawing.Size(114, 23);
            this.bShortcutsReset.TabIndex = 1;
            this.bShortcutsReset.Text = "Resetovať všetky";
            this.bShortcutsReset.UseVisualStyleBackColor = true;
            this.bShortcutsReset.Click += new System.EventHandler(this.BShortcutsReset_Click);
            // 
            // lShortcutMsg
            // 
            this.lShortcutMsg.AutoSize = true;
            this.lShortcutMsg.Location = new System.Drawing.Point(3, 8);
            this.lShortcutMsg.Name = "lShortcutMsg";
            this.lShortcutMsg.Size = new System.Drawing.Size(19, 15);
            this.lShortcutMsg.TabIndex = 0;
            this.lShortcutMsg.Text = "txt";
            // 
            // pStyles
            // 
            this.pStyles.Controls.Add(this.ppStyles);
            this.pStyles.Name = "pStyles";
            optionsNode8.ImageKey = "colors.png";
            optionsNode8.Name = "";
            optionsNode8.SelectedImageKey = "colors.png";
            optionsNode8.Text = "Štýly a farby";
            this.pStyles.Node = optionsNode8;
            this.pStyles.NodeText = "Štýly a farby";
            this.pStyles.ParentNode = optionsNode3;
            // 
            // ppStyles
            // 
            this.ppStyles.Controls.Add(this.toolStrip1);
            this.ppStyles.Controls.Add(this.exGroupBox1);
            this.ppStyles.Controls.Add(this.tvStyles);
            this.ppStyles.Controls.Add(this.gbColorItemSettings);
            this.ppStyles.Controls.Add(this.gbCategorySettings);
            this.ppStyles.Controls.Add(this.exGroupBox8);
            this.ppStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppStyles.Location = new System.Drawing.Point(0, 0);
            this.ppStyles.Name = "ppStyles";
            this.ppStyles.Size = new System.Drawing.Size(538, 399);
            this.ppStyles.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscbStyles,
            this.tsbApplyStyle,
            this.toolStripSeparator1,
            this.tsbAddStyle,
            this.tsbRenameStyle,
            this.tsbDeleteStyle,
            this.toolStripSeparator2,
            this.tsbResetStyle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(538, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 28);
            this.toolStripLabel1.Text = "Štýl:";
            // 
            // tscbStyles
            // 
            this.tscbStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbStyles.DropDownWidth = 121;
            this.tscbStyles.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscbStyles.Name = "tscbStyles";
            this.tscbStyles.Size = new System.Drawing.Size(150, 28);
            this.tscbStyles.SelectedIndexChanged += new System.EventHandler(this.TscbStyles_SelectedIndexChanged);
            // 
            // tsbApplyStyle
            // 
            this.tsbApplyStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbApplyStyle.Image = global::ToolsCore.GlobalResources.correct;
            this.tsbApplyStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbApplyStyle.Name = "tsbApplyStyle";
            this.tsbApplyStyle.Size = new System.Drawing.Size(29, 28);
            this.tsbApplyStyle.Text = "Použiť štýl";
            this.tsbApplyStyle.Click += new System.EventHandler(this.TsbApplyStyle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbAddStyle
            // 
            this.tsbAddStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddStyle.Image = global::ToolsCore.GlobalResources.add;
            this.tsbAddStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStyle.Name = "tsbAddStyle";
            this.tsbAddStyle.Size = new System.Drawing.Size(29, 28);
            this.tsbAddStyle.Text = "Pridať štýl...";
            this.tsbAddStyle.Click += new System.EventHandler(this.TsbAddStyle_Click);
            // 
            // tsbRenameStyle
            // 
            this.tsbRenameStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenameStyle.Image = global::ToolsCore.GlobalResources.rename;
            this.tsbRenameStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenameStyle.Name = "tsbRenameStyle";
            this.tsbRenameStyle.Size = new System.Drawing.Size(29, 28);
            this.tsbRenameStyle.Text = "Premenovať štýl...";
            this.tsbRenameStyle.Click += new System.EventHandler(this.TsbRenameStyle_Click);
            // 
            // tsbDeleteStyle
            // 
            this.tsbDeleteStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteStyle.Image = global::ToolsCore.GlobalResources.delete;
            this.tsbDeleteStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteStyle.Name = "tsbDeleteStyle";
            this.tsbDeleteStyle.Size = new System.Drawing.Size(29, 28);
            this.tsbDeleteStyle.Text = "Odstrániť štýl";
            this.tsbDeleteStyle.Click += new System.EventHandler(this.TsbDeleteStyle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbResetStyle
            // 
            this.tsbResetStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetStyle.Image = global::ToolsCore.GlobalResources.restart;
            this.tsbResetStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetStyle.Name = "tsbResetStyle";
            this.tsbResetStyle.Size = new System.Drawing.Size(29, 28);
            this.tsbResetStyle.Text = "Resetovať štýl";
            this.tsbResetStyle.Click += new System.EventHandler(this.TsbResetStyle_Click);
            // 
            // exGroupBox1
            // 
            this.exGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exGroupBox1.Controls.Add(this.lFontStyleExample);
            this.exGroupBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.exGroupBox1.Location = new System.Drawing.Point(288, 319);
            this.exGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.exGroupBox1.Name = "exGroupBox1";
            this.exGroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.exGroupBox1.Size = new System.Drawing.Size(246, 78);
            this.exGroupBox1.TabIndex = 5;
            this.exGroupBox1.TabStop = false;
            this.exGroupBox1.Text = "Ukážka";
            // 
            // lFontStyleExample
            // 
            this.lFontStyleExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lFontStyleExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lFontStyleExample.Location = new System.Drawing.Point(7, 15);
            this.lFontStyleExample.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFontStyleExample.Name = "lFontStyleExample";
            this.lFontStyleExample.Size = new System.Drawing.Size(234, 52);
            this.lFontStyleExample.TabIndex = 0;
            this.lFontStyleExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvStyles
            // 
            this.tvStyles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvStyles.FullRowSelect = true;
            this.tvStyles.HideSelection = false;
            this.tvStyles.Location = new System.Drawing.Point(6, 98);
            this.tvStyles.Margin = new System.Windows.Forms.Padding(2);
            this.tvStyles.Name = "tvStyles";
            this.tvStyles.ShowLines = false;
            this.tvStyles.Size = new System.Drawing.Size(278, 299);
            this.tvStyles.Style = ExControls.ExTreeViewStyle.Light;
            this.tvStyles.TabIndex = 2;
            this.tvStyles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvStyles_AfterSelect);
            // 
            // gbColorItemSettings
            // 
            this.gbColorItemSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbColorItemSettings.Controls.Add(this.bResetColorSetting);
            this.gbColorItemSettings.Controls.Add(this.cboxBold);
            this.gbColorItemSettings.Controls.Add(this.csForeColor);
            this.gbColorItemSettings.Controls.Add(this.lStyleBackColor);
            this.gbColorItemSettings.Controls.Add(this.lStyleForeColor);
            this.gbColorItemSettings.Controls.Add(this.csBackColor);
            this.gbColorItemSettings.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.gbColorItemSettings.Location = new System.Drawing.Point(288, 200);
            this.gbColorItemSettings.Margin = new System.Windows.Forms.Padding(2);
            this.gbColorItemSettings.Name = "gbColorItemSettings";
            this.gbColorItemSettings.Padding = new System.Windows.Forms.Padding(2);
            this.gbColorItemSettings.Size = new System.Drawing.Size(246, 115);
            this.gbColorItemSettings.TabIndex = 4;
            this.gbColorItemSettings.TabStop = false;
            this.gbColorItemSettings.Text = "Nastavenia položky";
            // 
            // bResetColorSetting
            // 
            this.bResetColorSetting.Location = new System.Drawing.Point(166, 16);
            this.bResetColorSetting.Name = "bResetColorSetting";
            this.bResetColorSetting.Size = new System.Drawing.Size(75, 23);
            this.bResetColorSetting.TabIndex = 5;
            this.bResetColorSetting.Text = "Resetovať";
            this.bResetColorSetting.UseVisualStyleBackColor = true;
            this.bResetColorSetting.Click += new System.EventHandler(this.BResetColorSetting_Click);
            // 
            // cboxBold
            // 
            this.cboxBold.AutoSize = true;
            this.cboxBold.BoxBackColor = System.Drawing.Color.White;
            this.cboxBold.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxBold.Location = new System.Drawing.Point(7, 22);
            this.cboxBold.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBold.Name = "cboxBold";
            this.cboxBold.Size = new System.Drawing.Size(100, 19);
            this.cboxBold.TabIndex = 0;
            this.cboxBold.Text = "Tučné písmo";
            this.cboxBold.CheckedChanged += new System.EventHandler(this.CboxBold_CheckedChanged);
            // 
            // csForeColor
            // 
            this.csForeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csForeColor.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.csForeColor.Location = new System.Drawing.Point(123, 38);
            this.csForeColor.Margin = new System.Windows.Forms.Padding(4);
            this.csForeColor.Name = "csForeColor";
            this.csForeColor.Size = new System.Drawing.Size(36, 28);
            this.csForeColor.TabIndex = 2;
            this.csForeColor.SelectedColorChanged += new System.EventHandler(this.CsForeColor_SelectedColorChanged);
            // 
            // lStyleBackColor
            // 
            this.lStyleBackColor.AutoSize = true;
            this.lStyleBackColor.Location = new System.Drawing.Point(4, 89);
            this.lStyleBackColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStyleBackColor.Name = "lStyleBackColor";
            this.lStyleBackColor.Size = new System.Drawing.Size(89, 15);
            this.lStyleBackColor.TabIndex = 3;
            this.lStyleBackColor.Text = "Farba pozadia:";
            // 
            // lStyleForeColor
            // 
            this.lStyleForeColor.AutoSize = true;
            this.lStyleForeColor.Location = new System.Drawing.Point(4, 53);
            this.lStyleForeColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStyleForeColor.Name = "lStyleForeColor";
            this.lStyleForeColor.Size = new System.Drawing.Size(131, 15);
            this.lStyleForeColor.TabIndex = 1;
            this.lStyleForeColor.Text = "Farba popredia (textu):";
            // 
            // csBackColor
            // 
            this.csBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csBackColor.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.csBackColor.Location = new System.Drawing.Point(123, 74);
            this.csBackColor.Margin = new System.Windows.Forms.Padding(4);
            this.csBackColor.Name = "csBackColor";
            this.csBackColor.Size = new System.Drawing.Size(36, 28);
            this.csBackColor.TabIndex = 4;
            this.csBackColor.SelectedColorChanged += new System.EventHandler(this.CsBackColor_SelectedColorChanged);
            // 
            // gbCategorySettings
            // 
            this.gbCategorySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCategorySettings.Controls.Add(this.label8);
            this.gbCategorySettings.Controls.Add(this.cbFont);
            this.gbCategorySettings.Controls.Add(this.nudFontSize);
            this.gbCategorySettings.Controls.Add(this.cboxOnlyNonPropFont);
            this.gbCategorySettings.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.gbCategorySettings.Location = new System.Drawing.Point(288, 94);
            this.gbCategorySettings.Margin = new System.Windows.Forms.Padding(2);
            this.gbCategorySettings.Name = "gbCategorySettings";
            this.gbCategorySettings.Padding = new System.Windows.Forms.Padding(2);
            this.gbCategorySettings.Size = new System.Drawing.Size(246, 106);
            this.gbCategorySettings.TabIndex = 3;
            this.gbCategorySettings.TabStop = false;
            this.gbCategorySettings.Text = "Nastavenia kategórie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Veľkosť (pt):";
            // 
            // cbFont
            // 
            this.cbFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFont.DropDownSelectedRowBackColor = System.Drawing.SystemColors.Highlight;
            this.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(7, 14);
            this.cbFont.Margin = new System.Windows.Forms.Padding(2);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(235, 21);
            this.cbFont.StyleDisabled.ArrowColor = null;
            this.cbFont.StyleDisabled.BackColor = null;
            this.cbFont.StyleDisabled.BorderColor = null;
            this.cbFont.StyleDisabled.ButtonBackColor = null;
            this.cbFont.StyleDisabled.ButtonBorderColor = null;
            this.cbFont.StyleDisabled.ButtonRenderFirst = null;
            this.cbFont.StyleDisabled.ForeColor = null;
            this.cbFont.StyleHighlight.ArrowColor = null;
            this.cbFont.StyleHighlight.BackColor = null;
            this.cbFont.StyleHighlight.BorderColor = null;
            this.cbFont.StyleHighlight.ButtonBackColor = null;
            this.cbFont.StyleHighlight.ButtonBorderColor = null;
            this.cbFont.StyleHighlight.ButtonRenderFirst = null;
            this.cbFont.StyleHighlight.ForeColor = null;
            this.cbFont.StyleNormal.ArrowColor = null;
            this.cbFont.StyleNormal.BackColor = null;
            this.cbFont.StyleNormal.BorderColor = null;
            this.cbFont.StyleNormal.ButtonBackColor = null;
            this.cbFont.StyleNormal.ButtonBorderColor = null;
            this.cbFont.StyleNormal.ButtonRenderFirst = null;
            this.cbFont.StyleNormal.ForeColor = null;
            this.cbFont.StyleSelected.ArrowColor = null;
            this.cbFont.StyleSelected.BackColor = null;
            this.cbFont.StyleSelected.BorderColor = null;
            this.cbFont.StyleSelected.ButtonBackColor = null;
            this.cbFont.StyleSelected.ButtonBorderColor = null;
            this.cbFont.StyleSelected.ButtonRenderFirst = null;
            this.cbFont.StyleSelected.ForeColor = null;
            this.cbFont.TabIndex = 0;
            this.cbFont.UseDarkScrollBar = false;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.CbFont_SelectedIndexChanged);
            // 
            // nudFontSize
            // 
            this.nudFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFontSize.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.nudFontSize.Location = new System.Drawing.Point(123, 72);
            this.nudFontSize.Margin = new System.Windows.Forms.Padding(2);
            this.nudFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.SelectedButtonColor = System.Drawing.SystemColors.Highlight;
            this.nudFontSize.Size = new System.Drawing.Size(67, 20);
            this.nudFontSize.TabIndex = 3;
            this.nudFontSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.NudFontSize_ValueChanged);
            // 
            // cboxOnlyNonPropFont
            // 
            this.cboxOnlyNonPropFont.AutoSize = true;
            this.cboxOnlyNonPropFont.BoxBackColor = System.Drawing.Color.White;
            this.cboxOnlyNonPropFont.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxOnlyNonPropFont.Location = new System.Drawing.Point(7, 46);
            this.cboxOnlyNonPropFont.Margin = new System.Windows.Forms.Padding(2);
            this.cboxOnlyNonPropFont.Name = "cboxOnlyNonPropFont";
            this.cboxOnlyNonPropFont.Size = new System.Drawing.Size(231, 19);
            this.cboxOnlyNonPropFont.TabIndex = 1;
            this.cboxOnlyNonPropFont.Text = "Zobraziť len neproporcionálne písma";
            this.cboxOnlyNonPropFont.CheckedChanged += new System.EventHandler(this.CboxOnlyNonPropFont_CheckedChanged);
            // 
            // exGroupBox8
            // 
            this.exGroupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exGroupBox8.Controls.Add(this.cboxHighlightStatusBar);
            this.exGroupBox8.Controls.Add(this.cboxDarkScrollbars);
            this.exGroupBox8.Controls.Add(this.cboxDarkTitlebar);
            this.exGroupBox8.Controls.Add(this.cboxDefaultVisual);
            this.exGroupBox8.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.exGroupBox8.Location = new System.Drawing.Point(6, 29);
            this.exGroupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.exGroupBox8.Name = "exGroupBox8";
            this.exGroupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.exGroupBox8.Size = new System.Drawing.Size(528, 65);
            this.exGroupBox8.TabIndex = 1;
            this.exGroupBox8.TabStop = false;
            this.exGroupBox8.Text = "Nastavenia štýlu";
            // 
            // cboxHighlightStatusBar
            // 
            this.cboxHighlightStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxHighlightStatusBar.AutoSize = true;
            this.cboxHighlightStatusBar.BoxBackColor = System.Drawing.Color.White;
            this.cboxHighlightStatusBar.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxHighlightStatusBar.Location = new System.Drawing.Point(240, 17);
            this.cboxHighlightStatusBar.Name = "cboxHighlightStatusBar";
            this.cboxHighlightStatusBar.Size = new System.Drawing.Size(280, 19);
            this.cboxHighlightStatusBar.TabIndex = 3;
            this.cboxHighlightStatusBar.Text = "Zafarbiť stavový riadok podľa farby zvýraznenia";
            this.cboxHighlightStatusBar.CheckedChanged += new System.EventHandler(this.CboxHighlightStatusBar_CheckedChanged);
            // 
            // cboxDarkScrollbars
            // 
            this.cboxDarkScrollbars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDarkScrollbars.AutoSize = true;
            this.cboxDarkScrollbars.BoxBackColor = System.Drawing.Color.White;
            this.cboxDarkScrollbars.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxDarkScrollbars.Location = new System.Drawing.Point(240, 38);
            this.cboxDarkScrollbars.Margin = new System.Windows.Forms.Padding(2);
            this.cboxDarkScrollbars.Name = "cboxDarkScrollbars";
            this.cboxDarkScrollbars.Size = new System.Drawing.Size(209, 19);
            this.cboxDarkScrollbars.TabIndex = 1;
            this.cboxDarkScrollbars.Text = "Použiť tmavé posuvníky (>Win10)";
            this.cboxDarkScrollbars.CheckedChanged += new System.EventHandler(this.CboxDarkScrollbars_CheckedChanged);
            // 
            // cboxDarkTitlebar
            // 
            this.cboxDarkTitlebar.AutoSize = true;
            this.cboxDarkTitlebar.BoxBackColor = System.Drawing.Color.White;
            this.cboxDarkTitlebar.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxDarkTitlebar.Location = new System.Drawing.Point(4, 38);
            this.cboxDarkTitlebar.Margin = new System.Windows.Forms.Padding(2);
            this.cboxDarkTitlebar.Name = "cboxDarkTitlebar";
            this.cboxDarkTitlebar.Size = new System.Drawing.Size(231, 19);
            this.cboxDarkTitlebar.TabIndex = 2;
            this.cboxDarkTitlebar.Text = "Použiť tmavé záhlavie okna (>Win10)";
            this.cboxDarkTitlebar.CheckedChanged += new System.EventHandler(this.CboxDarkTitlebar_CheckedChanged);
            // 
            // cboxDefaultVisual
            // 
            this.cboxDefaultVisual.AutoSize = true;
            this.cboxDefaultVisual.BoxBackColor = System.Drawing.Color.White;
            this.cboxDefaultVisual.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxDefaultVisual.Location = new System.Drawing.Point(4, 17);
            this.cboxDefaultVisual.Margin = new System.Windows.Forms.Padding(2);
            this.cboxDefaultVisual.Name = "cboxDefaultVisual";
            this.cboxDefaultVisual.Size = new System.Drawing.Size(246, 19);
            this.cboxDefaultVisual.TabIndex = 0;
            this.cboxDefaultVisual.Text = "Použiť klasický vzhľad ovládacích prvkov";
            this.cboxDefaultVisual.CheckedChanged += new System.EventHandler(this.CboxDefaultVisual_CheckedChanged);
            // 
            // pFonts
            // 
            this.pFonts.Controls.Add(this.pgFonts);
            this.pFonts.Controls.Add(this.exGroupBox3);
            this.pFonts.Name = "pFonts";
            optionsNode9.ImageKey = "font.png";
            optionsNode9.Name = "";
            optionsNode9.SelectedImageKey = "font.png";
            optionsNode9.Text = "Písma";
            this.pFonts.Node = optionsNode9;
            this.pFonts.NodeText = "Písma";
            this.pFonts.ParentNode = optionsNode3;
            // 
            // pgFonts
            // 
            this.pgFonts.BrowsableProperties = null;
            // 
            // 
            // 
            this.pgFonts.ButtonAlphabetical.ImageIndex = 0;
            this.pgFonts.ButtonAlphabetical.Name = "";
            this.pgFonts.ButtonAlphabetical.Size = new System.Drawing.Size(29, 28);
            // 
            // 
            // 
            this.pgFonts.ButtonCategorized.ImageIndex = 1;
            this.pgFonts.ButtonCategorized.Name = "";
            this.pgFonts.ButtonCategorized.Size = new System.Drawing.Size(29, 28);
            // 
            // 
            // 
            this.pgFonts.ButtonPropertyPages.Enabled = false;
            this.pgFonts.ButtonPropertyPages.ImageIndex = 3;
            this.pgFonts.ButtonPropertyPages.Name = "";
            this.pgFonts.ButtonPropertyPages.Size = new System.Drawing.Size(29, 22);
            this.pgFonts.ButtonPropertyPages.Visible = false;
            this.pgFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgFonts.FirstHideAllProperties = false;
            this.pgFonts.HelpVisible = false;
            this.pgFonts.HiddenAttributes = null;
            this.pgFonts.HiddenProperties = null;
            // 
            // pgFonts.InnerToolStrip
            // 
            this.pgFonts.InnerToolStrip.AccessibleName = "Property Grid";
            this.pgFonts.InnerToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.pgFonts.InnerToolStrip.AllowMerge = false;
            this.pgFonts.InnerToolStrip.AutoSize = false;
            this.pgFonts.InnerToolStrip.CanOverflow = false;
            this.pgFonts.InnerToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pgFonts.InnerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgFonts.ButtonCategorized,
            this.pgFonts.ButtonAlphabetical,
            this.pgFonts.Separator,
            this.pgFonts.ButtonPropertyPages});
            this.pgFonts.InnerToolStrip.Location = new System.Drawing.Point(0, 0);
            this.pgFonts.InnerToolStrip.Name = "InnerToolStrip";
            this.pgFonts.InnerToolStrip.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.pgFonts.InnerToolStrip.Size = new System.Drawing.Size(538, 31);
            this.pgFonts.InnerToolStrip.TabIndex = 1;
            this.pgFonts.InnerToolStrip.TabStop = true;
            this.pgFonts.InnerToolStrip.Text = "PropertyGridToolBar";
            this.pgFonts.Location = new System.Drawing.Point(0, 0);
            this.pgFonts.Name = "pgFonts";
            this.pgFonts.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgFonts.Size = new System.Drawing.Size(538, 340);
            this.pgFonts.TabIndex = 0;
            this.pgFonts.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.PgFonts_SelectedGridItemChanged);
            // 
            // exGroupBox3
            // 
            this.exGroupBox3.Controls.Add(this.lFontExample);
            this.exGroupBox3.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.exGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exGroupBox3.Location = new System.Drawing.Point(0, 340);
            this.exGroupBox3.Name = "exGroupBox3";
            this.exGroupBox3.Size = new System.Drawing.Size(538, 59);
            this.exGroupBox3.TabIndex = 1;
            this.exGroupBox3.TabStop = false;
            this.exGroupBox3.Text = "Ukážka písma";
            // 
            // lFontExample
            // 
            this.lFontExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lFontExample.Location = new System.Drawing.Point(3, 16);
            this.lFontExample.Name = "lFontExample";
            this.lFontExample.Size = new System.Drawing.Size(532, 40);
            this.lFontExample.TabIndex = 0;
            this.lFontExample.Text = "AaČčXxLl+*1!";
            this.lFontExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEnvironment
            // 
            this.pEnvironment.GenerateLinksToChildren = true;
            this.pEnvironment.Name = "pEnvironment";
            this.pEnvironment.Node = optionsNode3;
            this.pEnvironment.NodeText = "Prostredie";
            this.pEnvironment.ParentNode = null;
            // 
            // pLogging
            // 
            this.pLogging.Controls.Add(this.ppLogging);
            this.pLogging.Name = "pLogging";
            optionsNode10.ImageKey = "debugging.png";
            optionsNode10.Name = "";
            optionsNode10.SelectedImageKey = "debugging.png";
            optionsNode10.Text = "Logovanie a dubugging";
            this.pLogging.Node = optionsNode10;
            this.pLogging.NodeText = "Logovanie a dubugging";
            this.pLogging.ParentNode = null;
            // 
            // ppLogging
            // 
            this.ppLogging.Controls.Add(this.cbShowErrors);
            this.ppLogging.Controls.Add(this.gbLogging);
            this.ppLogging.Controls.Add(this.label1);
            this.ppLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppLogging.Location = new System.Drawing.Point(0, 0);
            this.ppLogging.Name = "ppLogging";
            this.ppLogging.Size = new System.Drawing.Size(538, 399);
            this.ppLogging.TabIndex = 0;
            // 
            // cbShowErrors
            // 
            this.cbShowErrors.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.configBindingSource, "DebugModeGUI", true));
            this.cbShowErrors.DropDownSelectedRowBackColor = System.Drawing.SystemColors.Highlight;
            this.cbShowErrors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShowErrors.FormattingEnabled = true;
            this.cbShowErrors.Location = new System.Drawing.Point(9, 106);
            this.cbShowErrors.Name = "cbShowErrors";
            this.cbShowErrors.Size = new System.Drawing.Size(260, 21);
            this.cbShowErrors.StyleDisabled.ArrowColor = null;
            this.cbShowErrors.StyleDisabled.BackColor = null;
            this.cbShowErrors.StyleDisabled.BorderColor = null;
            this.cbShowErrors.StyleDisabled.ButtonBackColor = null;
            this.cbShowErrors.StyleDisabled.ButtonBorderColor = null;
            this.cbShowErrors.StyleDisabled.ButtonRenderFirst = null;
            this.cbShowErrors.StyleDisabled.ForeColor = null;
            this.cbShowErrors.StyleHighlight.ArrowColor = null;
            this.cbShowErrors.StyleHighlight.BackColor = null;
            this.cbShowErrors.StyleHighlight.BorderColor = null;
            this.cbShowErrors.StyleHighlight.ButtonBackColor = null;
            this.cbShowErrors.StyleHighlight.ButtonBorderColor = null;
            this.cbShowErrors.StyleHighlight.ButtonRenderFirst = null;
            this.cbShowErrors.StyleHighlight.ForeColor = null;
            this.cbShowErrors.StyleNormal.ArrowColor = null;
            this.cbShowErrors.StyleNormal.BackColor = null;
            this.cbShowErrors.StyleNormal.BorderColor = null;
            this.cbShowErrors.StyleNormal.ButtonBackColor = null;
            this.cbShowErrors.StyleNormal.ButtonBorderColor = null;
            this.cbShowErrors.StyleNormal.ButtonRenderFirst = null;
            this.cbShowErrors.StyleNormal.ForeColor = null;
            this.cbShowErrors.StyleSelected.ArrowColor = null;
            this.cbShowErrors.StyleSelected.BackColor = null;
            this.cbShowErrors.StyleSelected.BorderColor = null;
            this.cbShowErrors.StyleSelected.ButtonBackColor = null;
            this.cbShowErrors.StyleSelected.ButtonBorderColor = null;
            this.cbShowErrors.StyleSelected.ButtonRenderFirst = null;
            this.cbShowErrors.StyleSelected.ForeColor = null;
            this.cbShowErrors.TabIndex = 2;
            this.cbShowErrors.UseDarkScrollBar = false;
            // 
            // gbLogging
            // 
            this.gbLogging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogging.Controls.Add(this.cboxLoggingInfo);
            this.gbLogging.Controls.Add(this.cboxLoggingError);
            this.gbLogging.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.gbLogging.Location = new System.Drawing.Point(3, 3);
            this.gbLogging.Name = "gbLogging";
            this.gbLogging.Size = new System.Drawing.Size(531, 70);
            this.gbLogging.TabIndex = 0;
            this.gbLogging.TabStop = false;
            this.gbLogging.Text = "Logovanie";
            // 
            // cboxLoggingInfo
            // 
            this.cboxLoggingInfo.AutoSize = true;
            this.cboxLoggingInfo.BoxBackColor = System.Drawing.Color.White;
            this.cboxLoggingInfo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configBindingSource, "LoggingInfo", true));
            this.cboxLoggingInfo.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxLoggingInfo.Location = new System.Drawing.Point(6, 19);
            this.cboxLoggingInfo.Name = "cboxLoggingInfo";
            this.cboxLoggingInfo.Size = new System.Drawing.Size(299, 19);
            this.cboxLoggingInfo.TabIndex = 0;
            this.cboxLoggingInfo.Text = "Logovanie informácií o stave programu do súboru";
            // 
            // cboxLoggingError
            // 
            this.cboxLoggingError.AutoSize = true;
            this.cboxLoggingError.BoxBackColor = System.Drawing.Color.White;
            this.cboxLoggingError.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configBindingSource, "LoggingError", true));
            this.cboxLoggingError.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxLoggingError.Location = new System.Drawing.Point(6, 42);
            this.cboxLoggingError.Name = "cboxLoggingError";
            this.cboxLoggingError.Size = new System.Drawing.Size(232, 19);
            this.cboxLoggingError.TabIndex = 1;
            this.cboxLoggingError.Text = "Logovanie chýb a výnimiek do súboru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zobrazovať chybové hlášky:";
            // 
            // appLanguageBindingSource
            // 
            this.appLanguageBindingSource.DataSource = typeof(ToolsCore.XML.AppLanguage);
            // 
            // debugModeBindingSource
            // 
            this.debugModeBindingSource.DataSource = typeof(ToolsCore.XML.DebugMode);
            // 
            // styleBindingSource
            // 
            this.styleBindingSource.DataSource = typeof(ToolsCore.XML.Style);
            // 
            // FAppSettingsBase
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bStorno;
            this.ClientSize = new System.Drawing.Size(826, 475);
            this.Controls.Add(this.optionsView);
            this.Controls.Add(this.panelBottom);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(776, 514);
            this.Name = "FAppSettingsBase";
            this.ShowIcon = false;
            this.Text = "Nastavenia programu";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FAppSettingsBase_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FAppSettingsBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FAppSettingsBase_KeyDown);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsView)).EndInit();
            this.pGeneral.ResumeLayout(false);
            this.pGeneral.PerformLayout();
            this.gboxGeneralProgram.ResumeLayout(false);
            this.gboxGeneralProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            this.pDesktopComponents.ResumeLayout(false);
            this.pDesktopComponents.PerformLayout();
            this.ppDesktopComponents.ResumeLayout(false);
            this.ppDesktopComponents.PerformLayout();
            this.pDesktopColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desktopColumnBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pLocalization.ResumeLayout(false);
            this.pLocalization.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortcuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandShortcutBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pStyles.ResumeLayout(false);
            this.ppStyles.ResumeLayout(false);
            this.ppStyles.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.exGroupBox1.ResumeLayout(false);
            this.gbColorItemSettings.ResumeLayout(false);
            this.gbColorItemSettings.PerformLayout();
            this.gbCategorySettings.ResumeLayout(false);
            this.gbCategorySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.exGroupBox8.ResumeLayout(false);
            this.exGroupBox8.PerformLayout();
            this.pFonts.ResumeLayout(false);
            this.pgFonts.ResumeLayout(false);
            this.exGroupBox3.ResumeLayout(false);
            this.pLogging.ResumeLayout(false);
            this.ppLogging.ResumeLayout(false);
            this.ppLogging.PerformLayout();
            this.gbLogging.ResumeLayout(false);
            this.gbLogging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLanguageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugModeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ExControls.ExButton bSave;
        private ExControls.ExButton bStorno;
        private Panel panelBottom;
        private ImageList listIcons;
        protected ExControls.ExOptionsPanel pGeneral;
        private Panel panel1;
        private ExControls.ExButton bShortcutsReset;
        private Label lShortcutMsg;
        private Panel ppLogging;
        private ExControls.ExComboBox cbShowErrors;
        private ExControls.ExGroupBox gbLogging;
        private ExControls.ExCheckBox cboxLoggingInfo;
        private ExControls.ExCheckBox cboxLoggingError;
        private Label label1;
        protected DataGridView dgvColumns;
        private Label label2;
        private ExControls.ExGroupBox gboxGeneralProgram;
        private ExControls.ExCheckBox cboxClassicGui;
        private ExControls.ExCheckBox cboxMultipleInstances;
        private BindingSource appLanguageBindingSource;
        private BindingSource debugModeBindingSource;
        private BindingSource commandShortcutBindingSource;
        private BindingSource desktopColumnBindingSource;
        private ExControls.ExGroupBox exGroupBox3;
        private ExControls.ExPropertyGrid pgFonts;
        private Label lFontExample;
        private ExCheckBox cboxShowRowHeaders;
        private ExRadioButton rbToolOnly;
        private ExRadioButton rbMenuOnly;
        private ExRadioButton rbMenuToolStrip;
        private Panel panel2;
        private ExButton bColDown;
        private ExButton bColUp;
        private ExCheckBox cboxFitLastCol;
        private ExComboBox cbAppLanguage;
        protected DataGridView dgvShortcuts;
        protected Panel pConcreteGeneral;
        protected ExOptionsView optionsView;
        private Panel ppStyles;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ExToolStripComboBox tscbStyles;
        private ToolStripButton tsbApplyStyle;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAddStyle;
        private ToolStripButton tsbRenameStyle;
        private ToolStripButton tsbDeleteStyle;
        private ExGroupBox exGroupBox1;
        private Label lFontStyleExample;
        private ExTreeView tvStyles;
        private ExGroupBox gbColorItemSettings;
        private ExCheckBox cboxBold;
        private ExColorSelector csForeColor;
        private ExLabel lStyleBackColor;
        private ExLabel lStyleForeColor;
        private ExColorSelector csBackColor;
        private ExGroupBox gbCategorySettings;
        private ExLabel label8;
        private ExComboBox cbFont;
        private ExNumericUpDown nudFontSize;
        private ExCheckBox cboxOnlyNonPropFont;
        private ExGroupBox exGroupBox8;
        private ExCheckBox cboxDarkScrollbars;
        private ExCheckBox cboxDarkTitlebar;
        private ExCheckBox cboxDefaultVisual;
        private BindingSource styleBindingSource;
        private ExButton bResetColumns;
        private ExComboBox cbStartup;
        private Label label3;
        protected ExOptionsPanel pShortcuts;
        protected ExOptionsPanel pStyles;
        protected ExOptionsPanel pFonts;
        protected ExOptionsPanel pLogging;
        protected ExOptionsPanel pDesktopComponents;
        protected ExOptionsPanel pDesktopColumns;
        protected ExOptionsPanel pLocalization;
        private ExOptionsPanel pEnvironment;
        private ExOptionsPanel pDesktop;
        protected Panel panel3;
        protected Panel pConcreteLocalization;
        private Panel ppDesktopComponents;
        protected Panel pConcreteDesktopComponents;
        private BindingSource configBindingSource;
        private DataGridViewTextBoxColumn cColName;
        private DataGridViewExCheckBoxColumn cColVisible;
        private DataGridViewTextBoxColumn cColMinWidth;
        private DataGridViewTextBoxColumn cShortcutName;
        private DataGridViewTextBoxColumn cShortcut;
        private DataGridViewButtonColumn cShortcutAttach;
        private DataGridViewButtonColumn cShortcutDeattach;
        private DataGridViewButtonColumn cShortcutReset;
        private ExButton bResetColorSetting;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbResetStyle;
        private ExCheckBox cboxHighlightStatusBar;
    }
}