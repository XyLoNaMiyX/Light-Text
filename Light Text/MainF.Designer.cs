namespace Light_Text
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
        	this.splitContainer = new System.Windows.Forms.SplitContainer();
        	this.textEditorTC = new System.Windows.Forms.TabControl();
        	this.tcCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.closeCurrentTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.closeTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.randomTP = new System.Windows.Forms.TabPage();
        	this.textEditorRTB = new System.Windows.Forms.RichTextBox();
        	this.teCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.copyTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.cutTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.pasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.tss1 = new System.Windows.Forms.ToolStripSeparator();
        	this.undoTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.redoTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.emojisL = new System.Windows.Forms.Label();
        	this.emojisLV = new System.Windows.Forms.ListView();
        	this.menuStrip = new System.Windows.Forms.MenuStrip();
        	this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAllTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.editTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.countTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.searchTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.replaceTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.encodingTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.utf7TSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.utf8TSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.utf32TSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.bigendianTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.unicodeTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.asciiTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.settingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.programmerTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.smartHighlightingTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.showincmsTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.openLinksTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.viewTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.styleTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.showExtraPanelsTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.sepEmojisTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.tutorialTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.supportTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.checkUpdatesB = new System.Windows.Forms.ToolStripMenuItem();
        	this.addonsTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.compilersTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.CSC = new System.Windows.Forms.ToolStripMenuItem();
        	this.VBNET = new System.Windows.Forms.ToolStripMenuItem();
        	this.codeExampleTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.cecsTSMI = new System.Windows.Forms.ToolStripMenuItem();
        	this.statusStrip = new System.Windows.Forms.StatusStrip();
        	this.fileInfoTSSL = new System.Windows.Forms.ToolStripStatusLabel();
        	this.infoTSSL = new System.Windows.Forms.ToolStripStatusLabel();
        	this.ofd = new System.Windows.Forms.OpenFileDialog();
        	this.sfd = new System.Windows.Forms.SaveFileDialog();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
        	this.splitContainer.Panel1.SuspendLayout();
        	this.splitContainer.Panel2.SuspendLayout();
        	this.splitContainer.SuspendLayout();
        	this.textEditorTC.SuspendLayout();
        	this.tcCMS.SuspendLayout();
        	this.randomTP.SuspendLayout();
        	this.teCMS.SuspendLayout();
        	this.menuStrip.SuspendLayout();
        	this.statusStrip.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// splitContainer
        	// 
        	this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
        	this.splitContainer.Location = new System.Drawing.Point(0, 27);
        	this.splitContainer.Name = "splitContainer";
        	// 
        	// splitContainer.Panel1
        	// 
        	this.splitContainer.Panel1.Controls.Add(this.textEditorTC);
        	// 
        	// splitContainer.Panel2
        	// 
        	this.splitContainer.Panel2.Controls.Add(this.emojisL);
        	this.splitContainer.Panel2.Controls.Add(this.emojisLV);
        	this.splitContainer.Panel2Collapsed = true;
        	this.splitContainer.Size = new System.Drawing.Size(544, 229);
        	this.splitContainer.SplitterDistance = 406;
        	this.splitContainer.TabIndex = 3;
        	// 
        	// textEditorTC
        	// 
        	this.textEditorTC.ContextMenuStrip = this.tcCMS;
        	this.textEditorTC.Controls.Add(this.randomTP);
        	this.textEditorTC.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.textEditorTC.Location = new System.Drawing.Point(0, 0);
        	this.textEditorTC.Name = "textEditorTC";
        	this.textEditorTC.SelectedIndex = 0;
        	this.textEditorTC.Size = new System.Drawing.Size(544, 229);
        	this.textEditorTC.TabIndex = 2;
        	this.textEditorTC.SelectedIndexChanged += new System.EventHandler(this.textEditorTC_SelectedIndexChanged);
        	this.textEditorTC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textEditorTC_MouseUp);
        	// 
        	// tcCMS
        	// 
        	this.tcCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.closeCurrentTabTSMI,
			this.closeTabTSMI});
        	this.tcCMS.Name = "tcCMS";
        	this.tcCMS.Size = new System.Drawing.Size(231, 48);
        	// 
        	// closeCurrentTabTSMI
        	// 
        	this.closeCurrentTabTSMI.Name = "closeCurrentTabTSMI";
        	this.closeCurrentTabTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
        	this.closeCurrentTabTSMI.Size = new System.Drawing.Size(230, 22);
        	this.closeCurrentTabTSMI.Text = "Cerrar pestaña actual";
        	this.closeCurrentTabTSMI.Click += new System.EventHandler(this.closeCurrentTabTSMI_Click);
        	// 
        	// closeTabTSMI
        	// 
        	this.closeTabTSMI.Name = "closeTabTSMI";
        	this.closeTabTSMI.Size = new System.Drawing.Size(230, 22);
        	this.closeTabTSMI.Text = "Cerrar pestaña";
        	this.closeTabTSMI.Click += new System.EventHandler(this.closeTabTSMI_Click);
        	// 
        	// randomTP
        	// 
        	this.randomTP.Controls.Add(this.textEditorRTB);
        	this.randomTP.Location = new System.Drawing.Point(4, 22);
        	this.randomTP.Name = "randomTP";
        	this.randomTP.Size = new System.Drawing.Size(536, 203);
        	this.randomTP.TabIndex = 0;
        	this.randomTP.Text = ">null<";
        	this.randomTP.UseVisualStyleBackColor = true;
        	// 
        	// textEditorRTB
        	// 
        	this.textEditorRTB.AcceptsTab = true;
        	this.textEditorRTB.BackColor = System.Drawing.Color.White;
        	this.textEditorRTB.ContextMenuStrip = this.teCMS;
        	this.textEditorRTB.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.textEditorRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        	this.textEditorRTB.ForeColor = System.Drawing.Color.Black;
        	this.textEditorRTB.Location = new System.Drawing.Point(0, 0);
        	this.textEditorRTB.Name = "textEditorRTB";
        	this.textEditorRTB.Size = new System.Drawing.Size(536, 203);
        	this.textEditorRTB.TabIndex = 1;
        	this.textEditorRTB.Text = "";
        	this.textEditorRTB.WordWrap = false;
        	this.textEditorRTB.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textEditorRTB_LinkClicked);
        	this.textEditorRTB.Click += new System.EventHandler(this.textEditorTB_Click);
        	this.textEditorRTB.TextChanged += new System.EventHandler(this.textEditorTB_TextChanged);
        	this.textEditorRTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorRTB_KeyDown);
        	this.textEditorRTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEditorTB_KeyUp);
        	// 
        	// teCMS
        	// 
        	this.teCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.copyTSMI,
			this.cutTSMI,
			this.pasteTSMI,
			this.tss1,
			this.undoTSMI,
			this.redoTSMI});
        	this.teCMS.Name = "teCMS";
        	this.teCMS.Size = new System.Drawing.Size(164, 120);
        	// 
        	// copyTSMI
        	// 
        	this.copyTSMI.Name = "copyTSMI";
        	this.copyTSMI.Size = new System.Drawing.Size(163, 22);
        	this.copyTSMI.Text = "Copiar";
        	this.copyTSMI.Click += new System.EventHandler(this.copyTSMI_Click);
        	// 
        	// cutTSMI
        	// 
        	this.cutTSMI.Name = "cutTSMI";
        	this.cutTSMI.Size = new System.Drawing.Size(163, 22);
        	this.cutTSMI.Text = "Cortar";
        	this.cutTSMI.Click += new System.EventHandler(this.cutTSMI_Click);
        	// 
        	// pasteTSMI
        	// 
        	this.pasteTSMI.Name = "pasteTSMI";
        	this.pasteTSMI.Size = new System.Drawing.Size(163, 22);
        	this.pasteTSMI.Text = "Pegar";
        	this.pasteTSMI.Click += new System.EventHandler(this.pasteTSMI_Click);
        	// 
        	// tss1
        	// 
        	this.tss1.Name = "tss1";
        	this.tss1.Size = new System.Drawing.Size(160, 6);
        	// 
        	// undoTSMI
        	// 
        	this.undoTSMI.Name = "undoTSMI";
        	this.undoTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
        	this.undoTSMI.Size = new System.Drawing.Size(163, 22);
        	this.undoTSMI.Text = "Deshacer";
        	this.undoTSMI.Click += new System.EventHandler(this.undoTSMI_Click);
        	// 
        	// redoTSMI
        	// 
        	this.redoTSMI.Name = "redoTSMI";
        	this.redoTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
        	this.redoTSMI.Size = new System.Drawing.Size(163, 22);
        	this.redoTSMI.Text = "Rehacer";
        	this.redoTSMI.Click += new System.EventHandler(this.redoTSMI_Click);
        	// 
        	// emojisL
        	// 
        	this.emojisL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.emojisL.Location = new System.Drawing.Point(5, 135);
        	this.emojisL.MaximumSize = new System.Drawing.Size(100, 500);
        	this.emojisL.Name = "emojisL";
        	this.emojisL.Size = new System.Drawing.Size(100, 23);
        	this.emojisL.TabIndex = 1;
        	this.emojisL.Text = "Los emojis no funcionan por el momento, pero son copiados al portapapeles";
        	// 
        	// emojisLV
        	// 
        	this.emojisLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.emojisLV.Location = new System.Drawing.Point(2, 3);
        	this.emojisLV.MultiSelect = false;
        	this.emojisLV.Name = "emojisLV";
        	this.emojisLV.Size = new System.Drawing.Size(129, 130);
        	this.emojisLV.TabIndex = 0;
        	this.emojisLV.TileSize = new System.Drawing.Size(22, 16);
        	this.emojisLV.UseCompatibleStateImageBehavior = false;
        	this.emojisLV.View = System.Windows.Forms.View.Tile;
        	this.emojisLV.DoubleClick += new System.EventHandler(this.emojisLV_DoubleClick);
        	// 
        	// menuStrip
        	// 
        	this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem,
			this.editTSMI,
			this.encodingTSMI,
			this.settingsTSMI,
			this.viewTSMI,
			this.helpTSMI,
			this.addonsTSMI});
        	this.menuStrip.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip.Name = "menuStrip";
        	this.menuStrip.Size = new System.Drawing.Size(544, 24);
        	this.menuStrip.TabIndex = 0;
        	// 
        	// archivoToolStripMenuItem
        	// 
        	this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newTSMI,
			this.openTSMI,
			this.saveTSMI,
			this.saveAllTSMI,
			this.saveAsTSMI});
        	this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
        	this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
        	this.archivoToolStripMenuItem.Text = "Archivo";
        	// 
        	// newTSMI
        	// 
        	this.newTSMI.Name = "newTSMI";
        	this.newTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newTSMI.Size = new System.Drawing.Size(235, 22);
        	this.newTSMI.Text = "Nuevo";
        	this.newTSMI.Click += new System.EventHandler(this.newTSMI_Click);
        	// 
        	// openTSMI
        	// 
        	this.openTSMI.Name = "openTSMI";
        	this.openTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openTSMI.Size = new System.Drawing.Size(235, 22);
        	this.openTSMI.Text = "Abrir archivo(s)";
        	this.openTSMI.Click += new System.EventHandler(this.openTSMI_Click);
        	// 
        	// saveTSMI
        	// 
        	this.saveTSMI.Name = "saveTSMI";
        	this.saveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveTSMI.Size = new System.Drawing.Size(235, 22);
        	this.saveTSMI.Text = "Guardar";
        	this.saveTSMI.Click += new System.EventHandler(this.saveTSMI_Click);
        	// 
        	// saveAllTSMI
        	// 
        	this.saveAllTSMI.Name = "saveAllTSMI";
        	this.saveAllTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
			| System.Windows.Forms.Keys.S)));
        	this.saveAllTSMI.Size = new System.Drawing.Size(235, 22);
        	this.saveAllTSMI.Text = "Guardar todos";
        	this.saveAllTSMI.Click += new System.EventHandler(this.saveAllTSMI_Click);
        	// 
        	// saveAsTSMI
        	// 
        	this.saveAsTSMI.Name = "saveAsTSMI";
        	this.saveAsTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
			| System.Windows.Forms.Keys.S)));
        	this.saveAsTSMI.Size = new System.Drawing.Size(235, 22);
        	this.saveAsTSMI.Text = "Guardar como...";
        	this.saveAsTSMI.Click += new System.EventHandler(this.saveAsTSMI_Click);
        	// 
        	// editTSMI
        	// 
        	this.editTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.countTSMI,
			this.searchTSMI,
			this.replaceTSMI});
        	this.editTSMI.Name = "editTSMI";
        	this.editTSMI.Size = new System.Drawing.Size(49, 20);
        	this.editTSMI.Text = "Editar";
        	// 
        	// countTSMI
        	// 
        	this.countTSMI.Name = "countTSMI";
        	this.countTSMI.Size = new System.Drawing.Size(178, 22);
        	this.countTSMI.Text = "Contar";
        	this.countTSMI.Click += new System.EventHandler(this.anyEditTSMI_Click);
        	// 
        	// searchTSMI
        	// 
        	this.searchTSMI.Name = "searchTSMI";
        	this.searchTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
        	this.searchTSMI.Size = new System.Drawing.Size(178, 22);
        	this.searchTSMI.Text = "Buscar";
        	this.searchTSMI.Click += new System.EventHandler(this.anyEditTSMI_Click);
        	// 
        	// replaceTSMI
        	// 
        	this.replaceTSMI.Name = "replaceTSMI";
        	this.replaceTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
        	this.replaceTSMI.Size = new System.Drawing.Size(178, 22);
        	this.replaceTSMI.Text = "Reemplazar";
        	this.replaceTSMI.Click += new System.EventHandler(this.anyEditTSMI_Click);
        	// 
        	// encodingTSMI
        	// 
        	this.encodingTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.utf7TSMI,
			this.utf8TSMI,
			this.utf32TSMI,
			this.bigendianTSMI,
			this.unicodeTSMI,
			this.asciiTSMI});
        	this.encodingTSMI.Name = "encodingTSMI";
        	this.encodingTSMI.Size = new System.Drawing.Size(86, 20);
        	this.encodingTSMI.Text = "Codificación";
        	// 
        	// utf7TSMI
        	// 
        	this.utf7TSMI.CheckOnClick = true;
        	this.utf7TSMI.Name = "utf7TSMI";
        	this.utf7TSMI.Size = new System.Drawing.Size(177, 22);
        	this.utf7TSMI.Text = "UTF-7";
        	this.utf7TSMI.Click += new System.EventHandler(this.utf7TSMI_Click);
        	// 
        	// utf8TSMI
        	// 
        	this.utf8TSMI.Checked = true;
        	this.utf8TSMI.CheckOnClick = true;
        	this.utf8TSMI.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.utf8TSMI.Name = "utf8TSMI";
        	this.utf8TSMI.Size = new System.Drawing.Size(177, 22);
        	this.utf8TSMI.Text = "UTF-8";
        	this.utf8TSMI.Click += new System.EventHandler(this.utf8TSMI_Click);
        	// 
        	// utf32TSMI
        	// 
        	this.utf32TSMI.CheckOnClick = true;
        	this.utf32TSMI.Name = "utf32TSMI";
        	this.utf32TSMI.Size = new System.Drawing.Size(177, 22);
        	this.utf32TSMI.Text = "UTF-32";
        	this.utf32TSMI.Click += new System.EventHandler(this.utf32TSMI_Click);
        	// 
        	// bigendianTSMI
        	// 
        	this.bigendianTSMI.CheckOnClick = true;
        	this.bigendianTSMI.Name = "bigendianTSMI";
        	this.bigendianTSMI.Size = new System.Drawing.Size(177, 22);
        	this.bigendianTSMI.Text = "Big Endian Unicode";
        	this.bigendianTSMI.Click += new System.EventHandler(this.bigendianTSMI_Click);
        	// 
        	// unicodeTSMI
        	// 
        	this.unicodeTSMI.CheckOnClick = true;
        	this.unicodeTSMI.Name = "unicodeTSMI";
        	this.unicodeTSMI.Size = new System.Drawing.Size(177, 22);
        	this.unicodeTSMI.Text = "Unicode";
        	this.unicodeTSMI.Click += new System.EventHandler(this.unicodeTSMI_Click);
        	// 
        	// asciiTSMI
        	// 
        	this.asciiTSMI.CheckOnClick = true;
        	this.asciiTSMI.Name = "asciiTSMI";
        	this.asciiTSMI.Size = new System.Drawing.Size(177, 22);
        	this.asciiTSMI.Text = "ASCII";
        	this.asciiTSMI.Click += new System.EventHandler(this.asciiTSMI_Click);
        	// 
        	// settingsTSMI
        	// 
        	this.settingsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.programmerTSMI,
			this.smartHighlightingTSMI,
			this.showincmsTSMI,
			this.openLinksTSMI});
        	this.settingsTSMI.Name = "settingsTSMI";
        	this.settingsTSMI.Size = new System.Drawing.Size(57, 20);
        	this.settingsTSMI.Text = "Ajustes";
        	// 
        	// programmerTSMI
        	// 
        	this.programmerTSMI.CheckOnClick = true;
        	this.programmerTSMI.Name = "programmerTSMI";
        	this.programmerTSMI.Size = new System.Drawing.Size(235, 22);
        	this.programmerTSMI.Text = "Modo programador";
        	this.programmerTSMI.Click += new System.EventHandler(this.programmerTSMI_Click);
        	// 
        	// smartHighlightingTSMI
        	// 
        	this.smartHighlightingTSMI.CheckOnClick = true;
        	this.smartHighlightingTSMI.Name = "smartHighlightingTSMI";
        	this.smartHighlightingTSMI.Size = new System.Drawing.Size(235, 22);
        	this.smartHighlightingTSMI.Text = "Resaltado inteligente (BETA)";
        	this.smartHighlightingTSMI.Click += new System.EventHandler(this.smartHighlightingTSMI_Click);
        	// 
        	// showincmsTSMI
        	// 
        	this.showincmsTSMI.CheckOnClick = true;
        	this.showincmsTSMI.Name = "showincmsTSMI";
        	this.showincmsTSMI.Size = new System.Drawing.Size(235, 22);
        	this.showincmsTSMI.Text = "Mostrar en el menú contextual";
        	this.showincmsTSMI.Click += new System.EventHandler(this.showincmsTSMI_Click);
        	// 
        	// openLinksTSMI
        	// 
        	this.openLinksTSMI.Checked = true;
        	this.openLinksTSMI.CheckOnClick = true;
        	this.openLinksTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.openLinksTSMI.Name = "openLinksTSMI";
        	this.openLinksTSMI.Size = new System.Drawing.Size(235, 22);
        	this.openLinksTSMI.Text = "Abrir links al cliquearlos";
        	this.openLinksTSMI.Click += new System.EventHandler(this.openLinksTSMI_Click);
        	// 
        	// viewTSMI
        	// 
        	this.viewTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.styleTSMI,
			this.showExtraPanelsTSMI});
        	this.viewTSMI.Name = "viewTSMI";
        	this.viewTSMI.Size = new System.Drawing.Size(44, 20);
        	this.viewTSMI.Text = "Vista";
        	// 
        	// styleTSMI
        	// 
        	this.styleTSMI.Name = "styleTSMI";
        	this.styleTSMI.Size = new System.Drawing.Size(186, 22);
        	this.styleTSMI.Text = "Estilo";
        	this.styleTSMI.Click += new System.EventHandler(this.styleTSMI_Click);
        	// 
        	// showExtraPanelsTSMI
        	// 
        	this.showExtraPanelsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.sepEmojisTSMI});
        	this.showExtraPanelsTSMI.Name = "showExtraPanelsTSMI";
        	this.showExtraPanelsTSMI.Size = new System.Drawing.Size(186, 22);
        	this.showExtraPanelsTSMI.Text = "Mostrar paneles extra";
        	// 
        	// sepEmojisTSMI
        	// 
        	this.sepEmojisTSMI.CheckOnClick = true;
        	this.sepEmojisTSMI.Name = "sepEmojisTSMI";
        	this.sepEmojisTSMI.Size = new System.Drawing.Size(109, 22);
        	this.sepEmojisTSMI.Text = "Emojis";
        	this.sepEmojisTSMI.CheckedChanged += new System.EventHandler(this.sepEmojisTSMI_CheckedChanged);
        	// 
        	// helpTSMI
        	// 
        	this.helpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tutorialTSMI,
			this.supportTSMI,
			this.checkUpdatesB});
        	this.helpTSMI.Name = "helpTSMI";
        	this.helpTSMI.Size = new System.Drawing.Size(53, 20);
        	this.helpTSMI.Text = "Ayuda";
        	// 
        	// tutorialTSMI
        	// 
        	this.tutorialTSMI.Name = "tutorialTSMI";
        	this.tutorialTSMI.Size = new System.Drawing.Size(218, 22);
        	this.tutorialTSMI.Text = "Tutorial";
        	this.tutorialTSMI.Click += new System.EventHandler(this.tutorialTSMI_Click);
        	// 
        	// supportTSMI
        	// 
        	this.supportTSMI.Name = "supportTSMI";
        	this.supportTSMI.Size = new System.Drawing.Size(218, 22);
        	this.supportTSMI.Text = "Soporte";
        	this.supportTSMI.Click += new System.EventHandler(this.supportTSMI_Click);
        	// 
        	// checkUpdatesB
        	// 
        	this.checkUpdatesB.Name = "checkUpdatesB";
        	this.checkUpdatesB.Size = new System.Drawing.Size(218, 22);
        	this.checkUpdatesB.Text = "Comprobar actualizaciones";
        	this.checkUpdatesB.Click += new System.EventHandler(this.checkUpdatesB_Click);
        	// 
        	// addonsTSMI
        	// 
        	this.addonsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.compilersTSMI,
			this.codeExampleTSMI});
        	this.addonsTSMI.Name = "addonsTSMI";
        	this.addonsTSMI.Size = new System.Drawing.Size(60, 20);
        	this.addonsTSMI.Text = "Addons";
        	// 
        	// compilersTSMI
        	// 
        	this.compilersTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CSC,
			this.VBNET});
        	this.compilersTSMI.Name = "compilersTSMI";
        	this.compilersTSMI.Size = new System.Drawing.Size(173, 22);
        	this.compilersTSMI.Text = "Compiladores";
        	// 
        	// CSC
        	// 
        	this.CSC.Name = "CSC";
        	this.CSC.Size = new System.Drawing.Size(229, 22);
        	this.CSC.Text = "Descargar compilador C#";
        	this.CSC.Click += new System.EventHandler(this.AddonTSMI_Click);
        	// 
        	// VBNET
        	// 
        	this.VBNET.Name = "VBNET";
        	this.VBNET.Size = new System.Drawing.Size(229, 22);
        	this.VBNET.Text = "Descargar compilador VB.Net";
        	this.VBNET.Click += new System.EventHandler(this.AddonTSMI_Click);
        	// 
        	// codeExampleTSMI
        	// 
        	this.codeExampleTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cecsTSMI});
        	this.codeExampleTSMI.Name = "codeExampleTSMI";
        	this.codeExampleTSMI.Size = new System.Drawing.Size(173, 22);
        	this.codeExampleTSMI.Text = "Ejemplo de código";
        	// 
        	// cecsTSMI
        	// 
        	this.cecsTSMI.Name = "cecsTSMI";
        	this.cecsTSMI.Size = new System.Drawing.Size(135, 22);
        	this.cecsTSMI.Text = "Ejemplo C#";
        	this.cecsTSMI.Click += new System.EventHandler(this.cecsTSMI_Click);
        	// 
        	// statusStrip
        	// 
        	this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileInfoTSSL,
			this.infoTSSL});
        	this.statusStrip.Location = new System.Drawing.Point(0, 259);
        	this.statusStrip.Name = "statusStrip";
        	this.statusStrip.Size = new System.Drawing.Size(544, 22);
        	this.statusStrip.TabIndex = 2;
        	// 
        	// fileInfoTSSL
        	// 
        	this.fileInfoTSSL.Name = "fileInfoTSSL";
        	this.fileInfoTSSL.Size = new System.Drawing.Size(41, 17);
        	this.fileInfoTSSL.Text = "1 línea";
        	// 
        	// infoTSSL
        	// 
        	this.infoTSSL.Name = "infoTSSL";
        	this.infoTSSL.Size = new System.Drawing.Size(72, 17);
        	this.infoTSSL.Text = "Información";
        	// 
        	// ofd
        	// 
        	this.ofd.Multiselect = true;
        	this.ofd.Title = "Elija el archivo que desee abrir";
        	// 
        	// sfd
        	// 
        	this.sfd.Title = "Elija donde desea guardar el archivo";
        	// 
        	// MainF
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(544, 281);
        	this.Controls.Add(this.splitContainer);
        	this.Controls.Add(this.statusStrip);
        	this.Controls.Add(this.menuStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MainMenuStrip = this.menuStrip;
        	this.Name = "MainF";
        	this.Text = "Light Text";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainF_FormClosing);
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainF_FormClosed);
        	this.Load += new System.EventHandler(this.MainF_Load);
        	this.ResizeEnd += new System.EventHandler(this.MainF_ResizeEnd);
        	this.splitContainer.Panel1.ResumeLayout(false);
        	this.splitContainer.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
        	this.splitContainer.ResumeLayout(false);
        	this.textEditorTC.ResumeLayout(false);
        	this.tcCMS.ResumeLayout(false);
        	this.randomTP.ResumeLayout(false);
        	this.teCMS.ResumeLayout(false);
        	this.menuStrip.ResumeLayout(false);
        	this.menuStrip.PerformLayout();
        	this.statusStrip.ResumeLayout(false);
        	this.statusStrip.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.MenuStrip menuStrip;
        System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        System.Windows.Forms.ToolStripMenuItem newTSMI;
        System.Windows.Forms.ToolStripMenuItem openTSMI;
        System.Windows.Forms.ToolStripMenuItem saveTSMI;
        System.Windows.Forms.ToolStripMenuItem saveAsTSMI;
        System.Windows.Forms.StatusStrip statusStrip;
        System.Windows.Forms.ToolStripStatusLabel infoTSSL;
        System.Windows.Forms.ToolStripMenuItem encodingTSMI;
        System.Windows.Forms.ToolStripMenuItem utf8TSMI;
        System.Windows.Forms.ToolStripMenuItem utf7TSMI;
        System.Windows.Forms.ToolStripMenuItem unicodeTSMI;
        System.Windows.Forms.ToolStripMenuItem utf32TSMI;
        System.Windows.Forms.ToolStripMenuItem bigendianTSMI;
        System.Windows.Forms.ToolStripMenuItem asciiTSMI;
        System.Windows.Forms.ToolStripMenuItem viewTSMI;
        System.Windows.Forms.ToolStripMenuItem showExtraPanelsTSMI;
        System.Windows.Forms.ToolStripMenuItem sepEmojisTSMI;
        System.Windows.Forms.ToolStripStatusLabel fileInfoTSSL;
        System.Windows.Forms.ToolStripMenuItem styleTSMI;
        System.Windows.Forms.SplitContainer splitContainer;
        System.Windows.Forms.ListView emojisLV;
        System.Windows.Forms.Label emojisL;
        System.Windows.Forms.ToolStripMenuItem settingsTSMI;
        System.Windows.Forms.ToolStripMenuItem programmerTSMI;
        System.Windows.Forms.TabControl textEditorTC;
        public System.Windows.Forms.RichTextBox textEditorRTB;
        System.Windows.Forms.TabPage randomTP;
        System.Windows.Forms.ContextMenuStrip tcCMS;
        System.Windows.Forms.ToolStripMenuItem closeCurrentTabTSMI;
        System.Windows.Forms.ToolStripMenuItem editTSMI;
        System.Windows.Forms.ToolStripMenuItem countTSMI;
        System.Windows.Forms.ToolStripMenuItem searchTSMI;
        System.Windows.Forms.ToolStripMenuItem replaceTSMI;
        System.Windows.Forms.ToolStripMenuItem helpTSMI;
        System.Windows.Forms.ToolStripMenuItem tutorialTSMI;
        System.Windows.Forms.ToolStripMenuItem supportTSMI;
        System.Windows.Forms.ContextMenuStrip teCMS;
        System.Windows.Forms.ToolStripMenuItem copyTSMI;
        System.Windows.Forms.ToolStripMenuItem cutTSMI;
        System.Windows.Forms.ToolStripMenuItem pasteTSMI;
        System.Windows.Forms.ToolStripMenuItem addonsTSMI;
        System.Windows.Forms.ToolStripMenuItem compilersTSMI;
        System.Windows.Forms.ToolStripMenuItem CSC;
        System.Windows.Forms.ToolStripMenuItem codeExampleTSMI;
        System.Windows.Forms.ToolStripMenuItem cecsTSMI;
        System.Windows.Forms.ToolStripMenuItem undoTSMI;
        System.Windows.Forms.ToolStripMenuItem redoTSMI;
        System.Windows.Forms.ToolStripSeparator tss1;
        System.Windows.Forms.ToolStripMenuItem showincmsTSMI;
        System.Windows.Forms.ToolStripMenuItem saveAllTSMI;
        System.Windows.Forms.ToolStripMenuItem closeTabTSMI;
        System.Windows.Forms.ToolStripMenuItem openLinksTSMI;
        System.Windows.Forms.ToolStripMenuItem smartHighlightingTSMI;
        System.Windows.Forms.ToolStripMenuItem VBNET;
        System.Windows.Forms.ToolStripMenuItem checkUpdatesB;
        System.Windows.Forms.OpenFileDialog ofd;
        System.Windows.Forms.SaveFileDialog sfd;
    }
}

