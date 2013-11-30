namespace EntityBuilder.Inspectors
{
    partial class LocationInspector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LocationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShapeList = new System.Windows.Forms.ComboBox();
            this.Orientation = new EntityBuilder.Controls.QuaternionEditor();
            this.Origin = new EntityBuilder.Controls.Vector3Editor();
            this.GeoSize = new EntityBuilder.Controls.Vector3Editor();
            this.ConnectionListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationName
            // 
            this.LocationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationName.Location = new System.Drawing.Point(3, 3);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(192, 20);
            this.LocationName.TabIndex = 0;
            this.LocationName.TextChanged += new System.EventHandler(this.LocationName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shape";
            // 
            // ShapeList
            // 
            this.ShapeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeList.FormattingEnabled = true;
            this.ShapeList.Location = new System.Drawing.Point(7, 300);
            this.ShapeList.Name = "ShapeList";
            this.ShapeList.Size = new System.Drawing.Size(182, 21);
            this.ShapeList.TabIndex = 4;
            this.ShapeList.SelectedIndexChanged += new System.EventHandler(this.ShapeList_SelectedIndexChanged);
            // 
            // Orientation
            // 
            this.Orientation.LabelName = "Orientation";
            this.Orientation.Location = new System.Drawing.Point(3, 126);
            this.Orientation.Name = "Orientation";
            this.Orientation.Size = new System.Drawing.Size(173, 151);
            this.Orientation.TabIndex = 2;
            // 
            // Origin
            // 
            this.Origin.LabelName = "Origin";
            this.Origin.Location = new System.Drawing.Point(3, 29);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(173, 100);
            this.Origin.TabIndex = 1;
            // 
            // GeoSize
            // 
            this.GeoSize.LabelName = "Size";
            this.GeoSize.Location = new System.Drawing.Point(7, 327);
            this.GeoSize.Name = "GeoSize";
            this.GeoSize.Size = new System.Drawing.Size(182, 100);
            this.GeoSize.TabIndex = 5;
            // 
            // ConnectionListMenu
            // 
            this.ConnectionListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConnectionToolStripMenuItem,
            this.deleteConnectionToolStripMenuItem});
            this.ConnectionListMenu.Name = "ConnectionListMenu";
            this.ConnectionListMenu.Size = new System.Drawing.Size(173, 48);
            // 
            // newConnectionToolStripMenuItem
            // 
            this.newConnectionToolStripMenuItem.Name = "newConnectionToolStripMenuItem";
            this.newConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newConnectionToolStripMenuItem.Text = "New Connection";
            // 
            // deleteConnectionToolStripMenuItem
            // 
            this.deleteConnectionToolStripMenuItem.Name = "deleteConnectionToolStripMenuItem";
            this.deleteConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteConnectionToolStripMenuItem.Text = "Delete Connection";
            // 
            // LocationInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeoSize);
            this.Controls.Add(this.ShapeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Orientation);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.LocationName);
            this.Name = "LocationInspector";
            this.Size = new System.Drawing.Size(198, 434);
            this.Load += new System.EventHandler(this.LocationInspector_Load);
            this.ConnectionListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationName;
        private Controls.Vector3Editor Origin;
        private Controls.QuaternionEditor Orientation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ShapeList;
        private Controls.Vector3Editor GeoSize;
        private System.Windows.Forms.ContextMenuStrip ConnectionListMenu;
        private System.Windows.Forms.ToolStripMenuItem newConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteConnectionToolStripMenuItem;
    }
}
