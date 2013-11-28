namespace EntityBuilder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainSpliter = new System.Windows.Forms.SplitContainer();
            this.XYGridCB = new System.Windows.Forms.CheckBox();
            this.OrthographicView = new System.Windows.Forms.CheckBox();
            this.IsometricView = new System.Windows.Forms.Button();
            this.SideView = new System.Windows.Forms.Button();
            this.TopView = new System.Windows.Forms.Button();
            this.CenterOnSelection = new System.Windows.Forms.Button();
            this.ResetView = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.SpinUp = new System.Windows.Forms.Button();
            this.SpinBack = new System.Windows.Forms.Button();
            this.CCWRot = new System.Windows.Forms.Button();
            this.CWRot = new System.Windows.Forms.Button();
            this.Visualisation = new OpenTK.GLControl();
            this.ToolsSplitter = new System.Windows.Forms.SplitContainer();
            this.ComponentViewModeList = new System.Windows.Forms.ComboBox();
            this.ComponentsList = new System.Windows.Forms.TreeView();
            this.ComponentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InspectorArea = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainSpliter)).BeginInit();
            this.MainSpliter.Panel1.SuspendLayout();
            this.MainSpliter.Panel2.SuspendLayout();
            this.MainSpliter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsSplitter)).BeginInit();
            this.ToolsSplitter.Panel1.SuspendLayout();
            this.ToolsSplitter.Panel2.SuspendLayout();
            this.ToolsSplitter.SuspendLayout();
            this.ComponentContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSpliter
            // 
            this.MainSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSpliter.Location = new System.Drawing.Point(0, 24);
            this.MainSpliter.Name = "MainSpliter";
            // 
            // MainSpliter.Panel1
            // 
            this.MainSpliter.Panel1.Controls.Add(this.XYGridCB);
            this.MainSpliter.Panel1.Controls.Add(this.OrthographicView);
            this.MainSpliter.Panel1.Controls.Add(this.IsometricView);
            this.MainSpliter.Panel1.Controls.Add(this.SideView);
            this.MainSpliter.Panel1.Controls.Add(this.TopView);
            this.MainSpliter.Panel1.Controls.Add(this.CenterOnSelection);
            this.MainSpliter.Panel1.Controls.Add(this.ResetView);
            this.MainSpliter.Panel1.Controls.Add(this.ZoomOut);
            this.MainSpliter.Panel1.Controls.Add(this.ZoomIn);
            this.MainSpliter.Panel1.Controls.Add(this.SpinUp);
            this.MainSpliter.Panel1.Controls.Add(this.SpinBack);
            this.MainSpliter.Panel1.Controls.Add(this.CCWRot);
            this.MainSpliter.Panel1.Controls.Add(this.CWRot);
            this.MainSpliter.Panel1.Controls.Add(this.Visualisation);
            // 
            // MainSpliter.Panel2
            // 
            this.MainSpliter.Panel2.Controls.Add(this.ToolsSplitter);
            this.MainSpliter.Size = new System.Drawing.Size(830, 454);
            this.MainSpliter.SplitterDistance = 586;
            this.MainSpliter.TabIndex = 0;
            // 
            // XYGridCB
            // 
            this.XYGridCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XYGridCB.AutoSize = true;
            this.XYGridCB.Checked = true;
            this.XYGridCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XYGridCB.Location = new System.Drawing.Point(399, 432);
            this.XYGridCB.Name = "XYGridCB";
            this.XYGridCB.Size = new System.Drawing.Size(62, 17);
            this.XYGridCB.TabIndex = 12;
            this.XYGridCB.Text = "XY Grid";
            this.XYGridCB.UseVisualStyleBackColor = true;
            this.XYGridCB.CheckedChanged += new System.EventHandler(this.XYGridCB_CheckedChanged);
            // 
            // OrthographicView
            // 
            this.OrthographicView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrthographicView.AutoSize = true;
            this.OrthographicView.Location = new System.Drawing.Point(467, 432);
            this.OrthographicView.Name = "OrthographicView";
            this.OrthographicView.Size = new System.Drawing.Size(52, 17);
            this.OrthographicView.TabIndex = 11;
            this.OrthographicView.Text = "Ortho";
            this.OrthographicView.UseVisualStyleBackColor = true;
            this.OrthographicView.CheckedChanged += new System.EventHandler(this.OrthographicView_CheckedChanged);
            // 
            // IsometricView
            // 
            this.IsometricView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IsometricView.Location = new System.Drawing.Point(129, 427);
            this.IsometricView.Name = "IsometricView";
            this.IsometricView.Size = new System.Drawing.Size(39, 23);
            this.IsometricView.TabIndex = 10;
            this.IsometricView.Text = "ISO";
            this.IsometricView.UseVisualStyleBackColor = true;
            this.IsometricView.Click += new System.EventHandler(this.IsometricView_Click);
            // 
            // SideView
            // 
            this.SideView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SideView.Location = new System.Drawing.Point(84, 427);
            this.SideView.Name = "SideView";
            this.SideView.Size = new System.Drawing.Size(39, 23);
            this.SideView.TabIndex = 9;
            this.SideView.Text = "Side";
            this.SideView.UseVisualStyleBackColor = true;
            this.SideView.Click += new System.EventHandler(this.SideView_Click);
            // 
            // TopView
            // 
            this.TopView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TopView.Location = new System.Drawing.Point(39, 427);
            this.TopView.Name = "TopView";
            this.TopView.Size = new System.Drawing.Size(39, 23);
            this.TopView.TabIndex = 8;
            this.TopView.Text = "Top";
            this.TopView.UseVisualStyleBackColor = true;
            this.TopView.Click += new System.EventHandler(this.TopView_Click);
            // 
            // CenterOnSelection
            // 
            this.CenterOnSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CenterOnSelection.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CenterOnSelection.Location = new System.Drawing.Point(256, 428);
            this.CenterOnSelection.Name = "CenterOnSelection";
            this.CenterOnSelection.Size = new System.Drawing.Size(30, 23);
            this.CenterOnSelection.TabIndex = 7;
            this.CenterOnSelection.Text = "8";
            this.CenterOnSelection.UseVisualStyleBackColor = true;
            this.CenterOnSelection.Click += new System.EventHandler(this.CenterOnSelection_Click);
            // 
            // ResetView
            // 
            this.ResetView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetView.Font = new System.Drawing.Font("Wingdings 2", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ResetView.Location = new System.Drawing.Point(220, 428);
            this.ResetView.Name = "ResetView";
            this.ResetView.Size = new System.Drawing.Size(30, 23);
            this.ResetView.TabIndex = 7;
            this.ResetView.Text = "Ç";
            this.ResetView.UseVisualStyleBackColor = true;
            this.ResetView.Click += new System.EventHandler(this.ResetView_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomOut.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ZoomOut.Location = new System.Drawing.Point(553, 223);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(30, 23);
            this.ZoomOut.TabIndex = 6;
            this.ZoomOut.Text = "q";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // ZoomIn
            // 
            this.ZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomIn.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ZoomIn.Location = new System.Drawing.Point(553, 194);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(30, 23);
            this.ZoomIn.TabIndex = 5;
            this.ZoomIn.Text = "p";
            this.ZoomIn.UseVisualStyleBackColor = true;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // SpinUp
            // 
            this.SpinUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpinUp.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SpinUp.Location = new System.Drawing.Point(553, 399);
            this.SpinUp.Name = "SpinUp";
            this.SpinUp.Size = new System.Drawing.Size(30, 23);
            this.SpinUp.TabIndex = 4;
            this.SpinUp.Text = "M";
            this.SpinUp.UseVisualStyleBackColor = true;
            this.SpinUp.Click += new System.EventHandler(this.SpinUp_Click);
            // 
            // SpinBack
            // 
            this.SpinBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpinBack.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SpinBack.Location = new System.Drawing.Point(553, 1);
            this.SpinBack.Name = "SpinBack";
            this.SpinBack.Size = new System.Drawing.Size(30, 23);
            this.SpinBack.TabIndex = 3;
            this.SpinBack.Text = "L";
            this.SpinBack.UseVisualStyleBackColor = true;
            this.SpinBack.Click += new System.EventHandler(this.SpinBack_Click);
            // 
            // CCWRot
            // 
            this.CCWRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CCWRot.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CCWRot.Location = new System.Drawing.Point(553, 428);
            this.CCWRot.Name = "CCWRot";
            this.CCWRot.Size = new System.Drawing.Size(30, 23);
            this.CCWRot.TabIndex = 2;
            this.CCWRot.Text = "Q";
            this.CCWRot.UseVisualStyleBackColor = true;
            this.CCWRot.Click += new System.EventHandler(this.CCWRot_Click);
            // 
            // CWRot
            // 
            this.CWRot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CWRot.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CWRot.Location = new System.Drawing.Point(3, 428);
            this.CWRot.Name = "CWRot";
            this.CWRot.Size = new System.Drawing.Size(30, 23);
            this.CWRot.TabIndex = 1;
            this.CWRot.Text = "P";
            this.CWRot.UseVisualStyleBackColor = true;
            this.CWRot.Click += new System.EventHandler(this.CWRot_Click);
            // 
            // Visualisation
            // 
            this.Visualisation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Visualisation.BackColor = System.Drawing.Color.Black;
            this.Visualisation.Location = new System.Drawing.Point(0, 0);
            this.Visualisation.Name = "Visualisation";
            this.Visualisation.Size = new System.Drawing.Size(547, 422);
            this.Visualisation.TabIndex = 0;
            this.Visualisation.VSync = false;
            this.Visualisation.Load += new System.EventHandler(this.Visualisation_Load);
            this.Visualisation.Paint += new System.Windows.Forms.PaintEventHandler(this.Visualisation_Paint);
            // 
            // ToolsSplitter
            // 
            this.ToolsSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsSplitter.Location = new System.Drawing.Point(0, 0);
            this.ToolsSplitter.Name = "ToolsSplitter";
            this.ToolsSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ToolsSplitter.Panel1
            // 
            this.ToolsSplitter.Panel1.Controls.Add(this.ComponentViewModeList);
            this.ToolsSplitter.Panel1.Controls.Add(this.ComponentsList);
            // 
            // ToolsSplitter.Panel2
            // 
            this.ToolsSplitter.Panel2.Controls.Add(this.InspectorArea);
            this.ToolsSplitter.Size = new System.Drawing.Size(240, 454);
            this.ToolsSplitter.SplitterDistance = 141;
            this.ToolsSplitter.TabIndex = 0;
            // 
            // ComponentViewModeList
            // 
            this.ComponentViewModeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentViewModeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComponentViewModeList.FormattingEnabled = true;
            this.ComponentViewModeList.Items.AddRange(new object[] {
            "By Location",
            "By Deck"});
            this.ComponentViewModeList.Location = new System.Drawing.Point(3, 3);
            this.ComponentViewModeList.Name = "ComponentViewModeList";
            this.ComponentViewModeList.Size = new System.Drawing.Size(234, 21);
            this.ComponentViewModeList.TabIndex = 1;
            this.ComponentViewModeList.SelectedIndexChanged += new System.EventHandler(this.ComponentViewModeList_SelectedIndexChanged);
            // 
            // ComponentsList
            // 
            this.ComponentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentsList.ContextMenuStrip = this.ComponentContextMenu;
            this.ComponentsList.HideSelection = false;
            this.ComponentsList.Location = new System.Drawing.Point(3, 30);
            this.ComponentsList.Name = "ComponentsList";
            this.ComponentsList.Size = new System.Drawing.Size(234, 108);
            this.ComponentsList.TabIndex = 0;
            this.ComponentsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ComponentsList_AfterSelect);
            // 
            // ComponentContextMenu
            // 
            this.ComponentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.ComponentContextMenu.Name = "ComponentContextMenu";
            this.ComponentContextMenu.Size = new System.Drawing.Size(121, 48);
            this.ComponentContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ComponentContextMenu_Opening);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.duplicateToolStripMenuItem});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.DropDownOpened += new System.EventHandler(this.locationToolStripMenuItem_DropDownOpened);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.deleteToolStripMenuItem1,
            this.moveToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.systemToolStripMenuItem.Text = "System";
            this.systemToolStripMenuItem.DropDownOpening += new System.EventHandler(this.systemToolStripMenuItem_DropDownOpening);
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem2.Text = "New";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // InspectorArea
            // 
            this.InspectorArea.AutoScroll = true;
            this.InspectorArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectorArea.Location = new System.Drawing.Point(0, 0);
            this.InspectorArea.Name = "InspectorArea";
            this.InspectorArea.Size = new System.Drawing.Size(240, 309);
            this.InspectorArea.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.templatesToolStripMenuItem.Text = "Templates";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // ComponentImages
            // 
            this.ComponentImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ComponentImages.ImageStream")));
            this.ComponentImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ComponentImages.Images.SetKeyName(0, "miscellaneous 2.ico");
            this.ComponentImages.Images.SetKeyName(1, "kservices.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 478);
            this.Controls.Add(this.MainSpliter);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 370);
            this.Name = "MainForm";
            this.Text = "EntityBuilder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainSpliter.Panel1.ResumeLayout(false);
            this.MainSpliter.Panel1.PerformLayout();
            this.MainSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSpliter)).EndInit();
            this.MainSpliter.ResumeLayout(false);
            this.ToolsSplitter.Panel1.ResumeLayout(false);
            this.ToolsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolsSplitter)).EndInit();
            this.ToolsSplitter.ResumeLayout(false);
            this.ComponentContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSpliter;
        private System.Windows.Forms.SplitContainer ToolsSplitter;
        private System.Windows.Forms.TreeView ComponentsList;
        private System.Windows.Forms.ComboBox ComponentViewModeList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ComponentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ImageList ComponentImages;
        private System.Windows.Forms.FlowLayoutPanel InspectorArea;
        private OpenTK.GLControl Visualisation;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button CCWRot;
        private System.Windows.Forms.Button CWRot;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.Button SpinUp;
        private System.Windows.Forms.Button SpinBack;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.Button ResetView;
        private System.Windows.Forms.Button CenterOnSelection;
        private System.Windows.Forms.Button IsometricView;
        private System.Windows.Forms.Button SideView;
        private System.Windows.Forms.Button TopView;
        private System.Windows.Forms.CheckBox OrthographicView;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.CheckBox XYGridCB;
    }
}

