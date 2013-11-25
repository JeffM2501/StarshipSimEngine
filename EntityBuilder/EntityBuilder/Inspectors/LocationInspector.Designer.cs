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
            this.LocationName = new System.Windows.Forms.TextBox();
            this.Origin = new EntityBuilder.Controls.Vector3Editor();
            this.SuspendLayout();
            // 
            // LocationName
            // 
            this.LocationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationName.Location = new System.Drawing.Point(3, 3);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(215, 20);
            this.LocationName.TabIndex = 0;
            // 
            // Origin
            // 
            this.Origin.LabelText = "Origin";
            this.Origin.Location = new System.Drawing.Point(3, 29);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(148, 100);
            this.Origin.TabIndex = 1;
            // 
            // LocationInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.LocationName);
            this.Name = "LocationInspector";
            this.Size = new System.Drawing.Size(221, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationName;
        private Controls.Vector3Editor Origin;
    }
}
