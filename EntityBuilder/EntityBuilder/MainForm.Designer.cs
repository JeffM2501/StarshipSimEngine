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
            this.ZoomOut = new System.Windows.Forms.Button();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.SpinUp = new System.Windows.Forms.Button();
            this.SpinBack = new System.Windows.Forms.Button();
            this.CCWRot = new System.Windows.Forms.Button();
            this.CWRot = new System.Windows.Forms.Button();
            this.Visualisation = new OpenTK.GLControl();
            this.ToolsSplitter = new System.Windows.Forms.SplitContainer();
            this.ComponentsList = new System.Windows.Forms.TreeView();
            this.ComponentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentImages = new System.Windows.Forms.ImageList(this.components);
            this.InspectorArea = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vissibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wireframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orthographicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perspectiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFocusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAllTraversalSpeedsToSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ToolsSplitter.Panel1.Controls.Add(this.ComponentsList);
            // 
            // ToolsSplitter.Panel2
            // 
            this.ToolsSplitter.Panel2.Controls.Add(this.InspectorArea);
            this.ToolsSplitter.Size = new System.Drawing.Size(240, 454);
            this.ToolsSplitter.SplitterDistance = 141;
            this.ToolsSplitter.TabIndex = 0;
            // 
            // ComponentsList
            // 
            this.ComponentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentsList.ContextMenuStrip = this.ComponentContextMenu;
            this.ComponentsList.FullRowSelect = true;
            this.ComponentsList.HideSelection = false;
            this.ComponentsList.ImageIndex = 12;
            this.ComponentsList.ImageList = this.ComponentImages;
            this.ComponentsList.Location = new System.Drawing.Point(3, 3);
            this.ComponentsList.Name = "ComponentsList";
            this.ComponentsList.SelectedImageIndex = 0;
            this.ComponentsList.Size = new System.Drawing.Size(234, 135);
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
            this.duplicateToolStripMenuItem,
            this.newConnectionToolStripMenuItem,
            this.deleteConnectionToolStripMenuItem});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.DropDownOpened += new System.EventHandler(this.locationToolStripMenuItem_DropDownOpened);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newConnectionToolStripMenuItem.Text = "New Connection";
            this.newConnectionToolStripMenuItem.Click += new System.EventHandler(this.newConnectionToolStripMenuItem_Click);
            // 
            // deleteConnectionToolStripMenuItem
            // 
            this.deleteConnectionToolStripMenuItem.Name = "deleteConnectionToolStripMenuItem";
            this.deleteConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteConnectionToolStripMenuItem.Text = "Delete Connection";
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
            // ComponentImages
            // 
            this.ComponentImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ComponentImages.ImageStream")));
            this.ComponentImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ComponentImages.Images.SetKeyName(0, "miscellaneous 2.ico");
            this.ComponentImages.Images.SetKeyName(1, "kservices.ico");
            this.ComponentImages.Images.SetKeyName(2, "restart.ico");
            this.ComponentImages.Images.SetKeyName(3, "quick_restart.ico");
            this.ComponentImages.Images.SetKeyName(4, "logout.ico");
            this.ComponentImages.Images.SetKeyName(5, "database.ico");
            this.ComponentImages.Images.SetKeyName(6, "Login Manager.ico");
            this.ComponentImages.Images.SetKeyName(7, "kcmmemory.ico");
            this.ComponentImages.Images.SetKeyName(8, "kspaceduel.ico");
            this.ComponentImages.Images.SetKeyName(9, "utilities.ico");
            this.ComponentImages.Images.SetKeyName(10, "kthememgr.ico");
            this.ComponentImages.Images.SetKeyName(11, "kbounce.ico");
            this.ComponentImages.Images.SetKeyName(12, "camera_test.png");
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
            this.viewToolStripMenuItem,
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
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girdToolStripMenuItem,
            this.renderingToolStripMenuItem,
            this.presetToolStripMenuItem,
            this.projectionToolStripMenuItem,
            this.focusToolStripMenuItem,
            this.showToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // girdToolStripMenuItem
            // 
            this.girdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planeToolStripMenuItem,
            this.vissibleToolStripMenuItem});
            this.girdToolStripMenuItem.Name = "girdToolStripMenuItem";
            this.girdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.girdToolStripMenuItem.Text = "Grid";
            // 
            // planeToolStripMenuItem
            // 
            this.planeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xYToolStripMenuItem,
            this.yZToolStripMenuItem});
            this.planeToolStripMenuItem.Name = "planeToolStripMenuItem";
            this.planeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.planeToolStripMenuItem.Text = "Plane";
            // 
            // xYToolStripMenuItem
            // 
            this.xYToolStripMenuItem.Name = "xYToolStripMenuItem";
            this.xYToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.xYToolStripMenuItem.Text = "XY";
            this.xYToolStripMenuItem.Click += new System.EventHandler(this.xYToolStripMenuItem_Click);
            // 
            // yZToolStripMenuItem
            // 
            this.yZToolStripMenuItem.Name = "yZToolStripMenuItem";
            this.yZToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.yZToolStripMenuItem.Text = "YZ";
            this.yZToolStripMenuItem.Click += new System.EventHandler(this.yZToolStripMenuItem_Click);
            // 
            // vissibleToolStripMenuItem
            // 
            this.vissibleToolStripMenuItem.Name = "vissibleToolStripMenuItem";
            this.vissibleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.vissibleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.vissibleToolStripMenuItem.Text = "Vissible";
            this.vissibleToolStripMenuItem.Click += new System.EventHandler(this.vissibleToolStripMenuItem_Click);
            // 
            // renderingToolStripMenuItem
            // 
            this.renderingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.wireframeToolStripMenuItem});
            this.renderingToolStripMenuItem.Name = "renderingToolStripMenuItem";
            this.renderingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renderingToolStripMenuItem.Text = "Rendering";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // wireframeToolStripMenuItem
            // 
            this.wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            this.wireframeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.wireframeToolStripMenuItem.Text = "Wireframe";
            this.wireframeToolStripMenuItem.Click += new System.EventHandler(this.wireframeToolStripMenuItem_Click);
            // 
            // presetToolStripMenuItem
            // 
            this.presetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.sideToolStripMenuItem,
            this.frontToolStripMenuItem,
            this.isometricToolStripMenuItem});
            this.presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            this.presetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.presetToolStripMenuItem.Text = "Preset";
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // sideToolStripMenuItem
            // 
            this.sideToolStripMenuItem.Name = "sideToolStripMenuItem";
            this.sideToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.sideToolStripMenuItem.Text = "Side";
            this.sideToolStripMenuItem.Click += new System.EventHandler(this.sideToolStripMenuItem_Click);
            // 
            // frontToolStripMenuItem
            // 
            this.frontToolStripMenuItem.Name = "frontToolStripMenuItem";
            this.frontToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.frontToolStripMenuItem.Text = "Front";
            this.frontToolStripMenuItem.Click += new System.EventHandler(this.frontToolStripMenuItem_Click);
            // 
            // isometricToolStripMenuItem
            // 
            this.isometricToolStripMenuItem.Name = "isometricToolStripMenuItem";
            this.isometricToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.isometricToolStripMenuItem.Text = "Isometric";
            this.isometricToolStripMenuItem.Click += new System.EventHandler(this.isometricToolStripMenuItem_Click);
            // 
            // projectionToolStripMenuItem
            // 
            this.projectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orthographicToolStripMenuItem,
            this.perspectiveToolStripMenuItem});
            this.projectionToolStripMenuItem.Name = "projectionToolStripMenuItem";
            this.projectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projectionToolStripMenuItem.Text = "Projection";
            // 
            // orthographicToolStripMenuItem
            // 
            this.orthographicToolStripMenuItem.Name = "orthographicToolStripMenuItem";
            this.orthographicToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.orthographicToolStripMenuItem.Text = "Orthographic";
            this.orthographicToolStripMenuItem.Click += new System.EventHandler(this.orthographicToolStripMenuItem_Click);
            // 
            // perspectiveToolStripMenuItem
            // 
            this.perspectiveToolStripMenuItem.Name = "perspectiveToolStripMenuItem";
            this.perspectiveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.perspectiveToolStripMenuItem.Text = "Perspective";
            this.perspectiveToolStripMenuItem.Click += new System.EventHandler(this.perspectiveToolStripMenuItem_Click);
            // 
            // focusToolStripMenuItem
            // 
            this.focusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.focusSelectedToolStripMenuItem,
            this.resetFocusToolStripMenuItem});
            this.focusToolStripMenuItem.Name = "focusToolStripMenuItem";
            this.focusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.focusToolStripMenuItem.Text = "Focus";
            // 
            // focusSelectedToolStripMenuItem
            // 
            this.focusSelectedToolStripMenuItem.Name = "focusSelectedToolStripMenuItem";
            this.focusSelectedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.focusSelectedToolStripMenuItem.Text = "Focus Selected";
            this.focusSelectedToolStripMenuItem.Click += new System.EventHandler(this.focusSelectedToolStripMenuItem_Click);
            // 
            // resetFocusToolStripMenuItem
            // 
            this.resetFocusToolStripMenuItem.Name = "resetFocusToolStripMenuItem";
            this.resetFocusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetFocusToolStripMenuItem.Text = "Reset Focus";
            this.resetFocusToolStripMenuItem.Click += new System.EventHandler(this.resetFocusToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.systemsToolStripMenuItem});
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem1.Text = "Show";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectionsToolStripMenuItem.Text = "Connections";
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // systemsToolStripMenuItem
            // 
            this.systemsToolStripMenuItem.Name = "systemsToolStripMenuItem";
            this.systemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.systemsToolStripMenuItem.Text = "Systems";
            this.systemsToolStripMenuItem.Click += new System.EventHandler(this.systemsToolStripMenuItem_Click);
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
            this.scaleToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAllTraversalSpeedsToSelectedToolStripMenuItem});
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            // 
            // setAllTraversalSpeedsToSelectedToolStripMenuItem
            // 
            this.setAllTraversalSpeedsToSelectedToolStripMenuItem.Name = "setAllTraversalSpeedsToSelectedToolStripMenuItem";
            this.setAllTraversalSpeedsToSelectedToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.setAllTraversalSpeedsToSelectedToolStripMenuItem.Text = "Set All Traversal Speeds to Selected";
            this.setAllTraversalSpeedsToSelectedToolStripMenuItem.Click += new System.EventHandler(this.setAllTraversalSpeedsToSelectedToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wireframeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isometricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orthographicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perspectiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focusSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFocusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vissibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAllTraversalSpeedsToSelectedToolStripMenuItem;
    }
}

