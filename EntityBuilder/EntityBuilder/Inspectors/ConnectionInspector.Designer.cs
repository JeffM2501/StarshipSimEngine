namespace EntityBuilder.Inspectors
{
    partial class ConnectionInspector
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionTarget = new System.Windows.Forms.ComboBox();
            this.ConnectionLocation = new EntityBuilder.Controls.Vector3Editor();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target";
            // 
            // ConnectionTarget
            // 
            this.ConnectionTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConnectionTarget.FormattingEnabled = true;
            this.ConnectionTarget.Location = new System.Drawing.Point(6, 16);
            this.ConnectionTarget.Name = "ConnectionTarget";
            this.ConnectionTarget.Size = new System.Drawing.Size(182, 21);
            this.ConnectionTarget.TabIndex = 1;
            this.ConnectionTarget.SelectedIndexChanged += new System.EventHandler(this.ConnectionTarget_SelectedIndexChanged);
            // 
            // ConnectionLocation
            // 
            this.ConnectionLocation.LabelName = "Location";
            this.ConnectionLocation.Location = new System.Drawing.Point(6, 43);
            this.ConnectionLocation.Name = "ConnectionLocation";
            this.ConnectionLocation.Size = new System.Drawing.Size(174, 100);
            this.ConnectionLocation.TabIndex = 2;
            // 
            // ConnectionInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConnectionLocation);
            this.Controls.Add(this.ConnectionTarget);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionInspector";
            this.Size = new System.Drawing.Size(191, 150);
            this.Load += new System.EventHandler(this.ConnectionInspector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ConnectionTarget;
        private Controls.Vector3Editor ConnectionLocation;
    }
}
