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
            this.label1 = new System.Windows.Forms.Label();
            this.PowerValue = new System.Windows.Forms.TextBox();
            this.TempValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CoolantValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoolantTrack = new System.Windows.Forms.TrackBar();
            this.PowerTrack = new System.Windows.Forms.TrackBar();
            this.CoolantBar = new CoolantTest.VerticalProgressBar();
            this.TempBar = new CoolantTest.VerticalProgressBar();
            this.PowerBar = new CoolantTest.VerticalProgressBar();
            this.DoActivate = new System.Windows.Forms.Button();
            this.NominalPower = new System.Windows.Forms.Button();
            this.MinPower = new System.Windows.Forms.Button();
            this.DoublePower = new System.Windows.Forms.Button();
            this.MaxPower = new System.Windows.Forms.Button();
            this.EssentialLabel = new System.Windows.Forms.Label();
            this.TempDelta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoolantTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemName
            // 
            this.SystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemName.Location = new System.Drawing.Point(0, 3);
            this.SystemName.Name = "SystemName";
            this.SystemName.ReadOnly = true;
            this.SystemName.Size = new System.Drawing.Size(236, 20);
            this.SystemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Power";
            // 
            // PowerValue
            // 
            this.PowerValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerValue.Location = new System.Drawing.Point(3, 314);
            this.PowerValue.Name = "PowerValue";
            this.PowerValue.ReadOnly = true;
            this.PowerValue.Size = new System.Drawing.Size(38, 20);
            this.PowerValue.TabIndex = 3;
            // 
            // TempValue
            // 
            this.TempValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TempValue.Location = new System.Drawing.Point(98, 314);
            this.TempValue.Name = "TempValue";
            this.TempValue.ReadOnly = true;
            this.TempValue.Size = new System.Drawing.Size(35, 20);
            this.TempValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temp";
            // 
            // CoolantValue
            // 
            this.CoolantValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CoolantValue.Location = new System.Drawing.Point(139, 314);
            this.CoolantValue.Name = "CoolantValue";
            this.CoolantValue.ReadOnly = true;
            this.CoolantValue.Size = new System.Drawing.Size(44, 20);
            this.CoolantValue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Coolant";
            // 
            // CoolantTrack
            // 
            this.CoolantTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoolantTrack.Location = new System.Drawing.Point(189, 43);
            this.CoolantTrack.Name = "CoolantTrack";
            this.CoolantTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.CoolantTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CoolantTrack.Size = new System.Drawing.Size(45, 265);
            this.CoolantTrack.TabIndex = 10;
            this.CoolantTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.CoolantTrack.Scroll += new System.EventHandler(this.CoolantTrack_Scroll);
            // 
            // PowerTrack
            // 
            this.PowerTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerTrack.Location = new System.Drawing.Point(47, 43);
            this.PowerTrack.Name = "PowerTrack";
            this.PowerTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.PowerTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerTrack.Size = new System.Drawing.Size(45, 265);
            this.PowerTrack.TabIndex = 11;
            this.PowerTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.PowerTrack.Scroll += new System.EventHandler(this.PowerTrack_Scroll);
            // 
            // CoolantBar
            // 
            this.CoolantBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoolantBar.Enabled = false;
            this.CoolantBar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.CoolantBar.Location = new System.Drawing.Point(139, 43);
            this.CoolantBar.MarqueeAnimationSpeed = 0;
            this.CoolantBar.Name = "CoolantBar";
            this.CoolantBar.Size = new System.Drawing.Size(44, 265);
            this.CoolantBar.TabIndex = 7;
            this.CoolantBar.Value = 50;
            // 
            // TempBar
            // 
            this.TempBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TempBar.Enabled = false;
            this.TempBar.ForeColor = System.Drawing.Color.Maroon;
            this.TempBar.Location = new System.Drawing.Point(98, 59);
            this.TempBar.MarqueeAnimationSpeed = 0;
            this.TempBar.Name = "TempBar";
            this.TempBar.Size = new System.Drawing.Size(35, 249);
            this.TempBar.TabIndex = 4;
            this.TempBar.Value = 50;
            // 
            // PowerBar
            // 
            this.PowerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerBar.Enabled = false;
            this.PowerBar.Location = new System.Drawing.Point(3, 43);
            this.PowerBar.MarqueeAnimationSpeed = 0;
            this.PowerBar.Name = "PowerBar";
            this.PowerBar.Size = new System.Drawing.Size(38, 265);
            this.PowerBar.TabIndex = 1;
            this.PowerBar.Value = 50;
            // 
            // DoActivate
            // 
            this.DoActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoActivate.Location = new System.Drawing.Point(179, 0);
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
            // EssentialLabel
            // 
            this.EssentialLabel.AutoSize = true;
            this.EssentialLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EssentialLabel.Location = new System.Drawing.Point(43, 317);
            this.EssentialLabel.Name = "EssentialLabel";
            this.EssentialLabel.Size = new System.Drawing.Size(49, 13);
            this.EssentialLabel.TabIndex = 17;
            this.EssentialLabel.Text = "Essential";
            // 
            // TempDelta
            // 
            this.TempDelta.AutoSize = true;
            this.TempDelta.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TempDelta.ForeColor = System.Drawing.Color.Red;
            this.TempDelta.Location = new System.Drawing.Point(105, 37);
            this.TempDelta.Name = "TempDelta";
            this.TempDelta.Size = new System.Drawing.Size(25, 19);
            this.TempDelta.TabIndex = 19;
            this.TempDelta.Text = "5";
            // 
            // ShipSystemInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TempDelta);
            this.Controls.Add(this.EssentialLabel);
            this.Controls.Add(this.MaxPower);
            this.Controls.Add(this.DoublePower);
            this.Controls.Add(this.MinPower);
            this.Controls.Add(this.NominalPower);
            this.Controls.Add(this.DoActivate);
            this.Controls.Add(this.PowerTrack);
            this.Controls.Add(this.CoolantTrack);
            this.Controls.Add(this.CoolantValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoolantBar);
            this.Controls.Add(this.TempValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TempBar);
            this.Controls.Add(this.PowerValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PowerBar);
            this.Controls.Add(this.SystemName);
            this.Name = "ShipSystemInspector";
            this.Size = new System.Drawing.Size(239, 375);
            ((System.ComponentModel.ISupportInitialize)(this.CoolantTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SystemName;
        private VerticalProgressBar PowerBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PowerValue;
        private System.Windows.Forms.TextBox TempValue;
        private System.Windows.Forms.Label label2;
        private VerticalProgressBar TempBar;
        private System.Windows.Forms.TextBox CoolantValue;
        private System.Windows.Forms.Label label3;
        private VerticalProgressBar CoolantBar;
        private System.Windows.Forms.TrackBar CoolantTrack;
        private System.Windows.Forms.TrackBar PowerTrack;
        private System.Windows.Forms.Button DoActivate;
        private System.Windows.Forms.Button NominalPower;
        private System.Windows.Forms.Button MinPower;
        private System.Windows.Forms.Button DoublePower;
        private System.Windows.Forms.Button MaxPower;
        private System.Windows.Forms.Label EssentialLabel;
        private System.Windows.Forms.Label TempDelta;
    }
}
