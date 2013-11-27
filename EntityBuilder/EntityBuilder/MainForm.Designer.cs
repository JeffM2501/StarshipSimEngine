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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Visualisation.Size = new System.Drawing.Size(586, 422);
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
            this.ToolsSplitter.SplitterDistance = 208;
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
            this.ComponentsList.Size = new System.Drawing.Size(234, 175);
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
            this.deleteToolStripMenuItem});
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.DropDownOpened += new System.EventHandler(this.locationToolStripMenuItem_DropDownOpened);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            this.InspectorArea.Size = new System.Drawing.Size(240, 242);
            this.InspectorArea.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templatesToolStripMenuItem});
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
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.templatesToolStripMenuItem.Text = "Templates";
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
    }
}

