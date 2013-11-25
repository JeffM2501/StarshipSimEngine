namespace EntityBuilder
{
    partial class EntityTypeSelector
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EntityNameTE = new System.Windows.Forms.TextBox();
            this.EntityTypeClass = new System.Windows.Forms.GroupBox();
            this.ShipRB = new System.Windows.Forms.RadioButton();
            this.CelestialRB = new System.Windows.Forms.RadioButton();
            this.EntityTypeGroup = new System.Windows.Forms.Panel();
            this.EntityTypeLabel = new System.Windows.Forms.Label();
            this.EntityType = new System.Windows.Forms.ComboBox();
            this.EntityTypeClass.SuspendLayout();
            this.EntityTypeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(224, 140);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(143, 140);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // EntityNameTE
            // 
            this.EntityNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityNameTE.Location = new System.Drawing.Point(53, 12);
            this.EntityNameTE.Name = "EntityNameTE";
            this.EntityNameTE.Size = new System.Drawing.Size(243, 20);
            this.EntityNameTE.TabIndex = 3;
            // 
            // EntityTypeClass
            // 
            this.EntityTypeClass.Controls.Add(this.CelestialRB);
            this.EntityTypeClass.Controls.Add(this.ShipRB);
            this.EntityTypeClass.Location = new System.Drawing.Point(12, 38);
            this.EntityTypeClass.Name = "EntityTypeClass";
            this.EntityTypeClass.Size = new System.Drawing.Size(205, 51);
            this.EntityTypeClass.TabIndex = 4;
            this.EntityTypeClass.TabStop = false;
            this.EntityTypeClass.Text = "Entity Class";
            // 
            // ShipRB
            // 
            this.ShipRB.AutoSize = true;
            this.ShipRB.Location = new System.Drawing.Point(6, 19);
            this.ShipRB.Name = "ShipRB";
            this.ShipRB.Size = new System.Drawing.Size(46, 17);
            this.ShipRB.TabIndex = 0;
            this.ShipRB.TabStop = true;
            this.ShipRB.Text = "Ship";
            this.ShipRB.UseVisualStyleBackColor = true;
            this.ShipRB.CheckedChanged += new System.EventHandler(this.ShipRB_CheckedChanged);
            // 
            // CelestialRB
            // 
            this.CelestialRB.AutoSize = true;
            this.CelestialRB.Location = new System.Drawing.Point(58, 19);
            this.CelestialRB.Name = "CelestialRB";
            this.CelestialRB.Size = new System.Drawing.Size(98, 17);
            this.CelestialRB.TabIndex = 1;
            this.CelestialRB.TabStop = true;
            this.CelestialRB.Text = "Celestial Object";
            this.CelestialRB.UseVisualStyleBackColor = true;
            this.CelestialRB.CheckedChanged += new System.EventHandler(this.CelestialRB_CheckedChanged);
            // 
            // EntityTypeGroup
            // 
            this.EntityTypeGroup.Controls.Add(this.EntityType);
            this.EntityTypeGroup.Controls.Add(this.EntityTypeLabel);
            this.EntityTypeGroup.Location = new System.Drawing.Point(12, 95);
            this.EntityTypeGroup.Name = "EntityTypeGroup";
            this.EntityTypeGroup.Size = new System.Drawing.Size(284, 32);
            this.EntityTypeGroup.TabIndex = 5;
            // 
            // EntityTypeLabel
            // 
            this.EntityTypeLabel.AutoSize = true;
            this.EntityTypeLabel.Location = new System.Drawing.Point(3, 6);
            this.EntityTypeLabel.Name = "EntityTypeLabel";
            this.EntityTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.EntityTypeLabel.TabIndex = 0;
            this.EntityTypeLabel.Text = "Type";
            // 
            // EntityType
            // 
            this.EntityType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntityType.FormattingEnabled = true;
            this.EntityType.Location = new System.Drawing.Point(44, 3);
            this.EntityType.Name = "EntityType";
            this.EntityType.Size = new System.Drawing.Size(240, 21);
            this.EntityType.TabIndex = 1;
            // 
            // EntityTypeSelector
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(311, 175);
            this.Controls.Add(this.EntityTypeGroup);
            this.Controls.Add(this.EntityTypeClass);
            this.Controls.Add(this.EntityNameTE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntityTypeSelector";
            this.Text = "Select Entity Type";
            this.Load += new System.EventHandler(this.EntityTypeSelector_Load);
            this.EntityTypeClass.ResumeLayout(false);
            this.EntityTypeClass.PerformLayout();
            this.EntityTypeGroup.ResumeLayout(false);
            this.EntityTypeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntityNameTE;
        private System.Windows.Forms.GroupBox EntityTypeClass;
        private System.Windows.Forms.RadioButton CelestialRB;
        private System.Windows.Forms.RadioButton ShipRB;
        private System.Windows.Forms.Panel EntityTypeGroup;
        private System.Windows.Forms.ComboBox EntityType;
        private System.Windows.Forms.Label EntityTypeLabel;
    }
}