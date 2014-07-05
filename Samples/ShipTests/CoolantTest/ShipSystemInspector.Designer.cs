namespace CoolantTest
{
    partial class ShipSystemInspector
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
            this.DoActivate = new System.Windows.Forms.Button();
            this.NominalPower = new System.Windows.Forms.Button();
            this.MinPower = new System.Windows.Forms.Button();
            this.DoublePower = new System.Windows.Forms.Button();
            this.MaxPower = new System.Windows.Forms.Button();
            this.PowerTemp = new CoolantTest.PowerTempControl();
            this.SuspendLayout();
            // 
            // SystemName
            // 
            this.SystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemName.Location = new System.Drawing.Point(0, 3);
            this.SystemName.Name = "SystemName";
            this.SystemName.ReadOnly = true;
            this.SystemName.Size = new System.Drawing.Size(251, 20);
            this.SystemName.TabIndex = 0;
            // 
            // DoActivate
            // 
            this.DoActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoActivate.Location = new System.Drawing.Point(194, 0);
            this.DoActivate.Name = "DoActivate";
            this.DoActivate.Size = new System.Drawing.Size(60, 23);
            this.DoActivate.TabIndex = 12;
            this.DoActivate.Text = "Activate";
            this.DoActivate.UseVisualStyleBackColor = true;
            this.DoActivate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // NominalPower
            // 
            this.NominalPower.Location = new System.Drawing.Point(64, 340);
            this.NominalPower.Name = "NominalPower";
            this.NominalPower.Size = new System.Drawing.Size(58, 23);
            this.NominalPower.TabIndex = 13;
            this.NominalPower.Text = "Nominal";
            this.NominalPower.UseVisualStyleBackColor = true;
            this.NominalPower.Click += new System.EventHandler(this.NominalPower_Click);
            // 
            // MinPower
            // 
            this.MinPower.Location = new System.Drawing.Point(0, 340);
            this.MinPower.Name = "MinPower";
            this.MinPower.Size = new System.Drawing.Size(58, 23);
            this.MinPower.TabIndex = 14;
            this.MinPower.Text = "Min";
            this.MinPower.UseVisualStyleBackColor = true;
            this.MinPower.Click += new System.EventHandler(this.MinPower_Click);
            // 
            // DoublePower
            // 
            this.DoublePower.Location = new System.Drawing.Point(128, 340);
            this.DoublePower.Name = "DoublePower";
            this.DoublePower.Size = new System.Drawing.Size(34, 23);
            this.DoublePower.TabIndex = 15;
            this.DoublePower.Text = "2X";
            this.DoublePower.UseVisualStyleBackColor = true;
            this.DoublePower.Click += new System.EventHandler(this.DoublePower_Click);
            // 
            // MaxPower
            // 
            this.MaxPower.Location = new System.Drawing.Point(168, 340);
            this.MaxPower.Name = "MaxPower";
            this.MaxPower.Size = new System.Drawing.Size(39, 23);
            this.MaxPower.TabIndex = 16;
            this.MaxPower.Text = "Max";
            this.MaxPower.UseVisualStyleBackColor = true;
            this.MaxPower.Click += new System.EventHandler(this.MaxPower_Click);
            // 
            // PowerTemp
            // 
            this.PowerTemp.Location = new System.Drawing.Point(3, 29);
            this.PowerTemp.Name = "PowerTemp";
            this.PowerTemp.Size = new System.Drawing.Size(238, 305);
            this.PowerTemp.TabIndex = 17;
            // 
            // ShipSystemInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PowerTemp);
            this.Controls.Add(this.MaxPower);
            this.Controls.Add(this.DoublePower);
            this.Controls.Add(this.MinPower);
            this.Controls.Add(this.NominalPower);
            this.Controls.Add(this.DoActivate);
            this.Controls.Add(this.SystemName);
            this.Name = "ShipSystemInspector";
            this.Size = new System.Drawing.Size(254, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SystemName;
        private System.Windows.Forms.Button DoActivate;
        private System.Windows.Forms.Button NominalPower;
        private System.Windows.Forms.Button MinPower;
        private System.Windows.Forms.Button DoublePower;
        private System.Windows.Forms.Button MaxPower;
        private PowerTempControl PowerTemp;
    }
}
