namespace EntityBuilder.Inspectors
{
    partial class BaseSystemInspector
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
            this.SystemName = new System.Windows.Forms.TextBox();
            this.HostLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SystemLocation = new EntityBuilder.Controls.Vector3Editor();
            this.SuspendLayout();
            // 
            // SystemName
            // 
            this.SystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemName.Location = new System.Drawing.Point(3, 3);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(192, 20);
            this.SystemName.TabIndex = 1;
            this.SystemName.TextChanged += new System.EventHandler(this.SystemName_TextChanged);
            // 
            // HostLocation
            // 
            this.HostLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HostLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostLocation.FormattingEnabled = true;
            this.HostLocation.Location = new System.Drawing.Point(6, 42);
            this.HostLocation.Name = "HostLocation";
            this.HostLocation.Size = new System.Drawing.Size(189, 21);
            this.HostLocation.TabIndex = 3;
            this.HostLocation.SelectedIndexChanged += new System.EventHandler(this.SystemLocation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host Location";
            // 
            // SystemLocation
            // 
            this.SystemLocation.LabelName = "System Location";
            this.SystemLocation.Location = new System.Drawing.Point(6, 69);
            this.SystemLocation.Name = "SystemLocation";
            this.SystemLocation.Size = new System.Drawing.Size(173, 100);
            this.SystemLocation.TabIndex = 4;
            // 
            // BaseSystemInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SystemLocation);
            this.Controls.Add(this.HostLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SystemName);
            this.Name = "BaseSystemInspector";
            this.Size = new System.Drawing.Size(200, 320);
            this.Load += new System.EventHandler(this.BaseSystemInspector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SystemName;
        private System.Windows.Forms.ComboBox HostLocation;
        private System.Windows.Forms.Label label1;
        private Controls.Vector3Editor SystemLocation;
    }
}
