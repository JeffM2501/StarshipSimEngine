namespace CoolantTest
{
    partial class PowerTempControl
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
            this.TempDelta = new System.Windows.Forms.Label();
            this.EssentialLabel = new System.Windows.Forms.Label();
            this.PowerTrack = new System.Windows.Forms.TrackBar();
            this.CoolantTrack = new System.Windows.Forms.TrackBar();
            this.CoolantValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoolantBar = new CoolantTest.VerticalProgressBar();
            this.TempValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TempBar = new CoolantTest.VerticalProgressBar();
            this.PowerValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PowerBar = new CoolantTest.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolantTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // TempDelta
            // 
            this.TempDelta.AutoSize = true;
            this.TempDelta.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TempDelta.ForeColor = System.Drawing.Color.Red;
            this.TempDelta.Location = new System.Drawing.Point(105, 19);
            this.TempDelta.Name = "TempDelta";
            this.TempDelta.Size = new System.Drawing.Size(25, 19);
            this.TempDelta.TabIndex = 32;
            this.TempDelta.Text = "5";
            // 
            // EssentialLabel
            // 
            this.EssentialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EssentialLabel.AutoSize = true;
            this.EssentialLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EssentialLabel.Location = new System.Drawing.Point(43, 253);
            this.EssentialLabel.Name = "EssentialLabel";
            this.EssentialLabel.Size = new System.Drawing.Size(49, 13);
            this.EssentialLabel.TabIndex = 31;
            this.EssentialLabel.Text = "Essential";
            // 
            // PowerTrack
            // 
            this.PowerTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerTrack.Location = new System.Drawing.Point(47, 25);
            this.PowerTrack.Name = "PowerTrack";
            this.PowerTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.PowerTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerTrack.Size = new System.Drawing.Size(45, 219);
            this.PowerTrack.TabIndex = 30;
            this.PowerTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.PowerTrack.Scroll += new System.EventHandler(this.PowerTrack_Scroll);
            // 
            // CoolantTrack
            // 
            this.CoolantTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoolantTrack.Location = new System.Drawing.Point(189, 25);
            this.CoolantTrack.Name = "CoolantTrack";
            this.CoolantTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.CoolantTrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CoolantTrack.Size = new System.Drawing.Size(45, 219);
            this.CoolantTrack.TabIndex = 29;
            this.CoolantTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.CoolantTrack.Scroll += new System.EventHandler(this.CoolantTrack_Scroll);
            // 
            // CoolantValue
            // 
            this.CoolantValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CoolantValue.Location = new System.Drawing.Point(139, 250);
            this.CoolantValue.Name = "CoolantValue";
            this.CoolantValue.ReadOnly = true;
            this.CoolantValue.Size = new System.Drawing.Size(44, 20);
            this.CoolantValue.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Coolant";
            // 
            // CoolantBar
            // 
            this.CoolantBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoolantBar.Enabled = false;
            this.CoolantBar.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.CoolantBar.Location = new System.Drawing.Point(139, 25);
            this.CoolantBar.MarqueeAnimationSpeed = 0;
            this.CoolantBar.Name = "CoolantBar";
            this.CoolantBar.Size = new System.Drawing.Size(44, 219);
            this.CoolantBar.TabIndex = 26;
            this.CoolantBar.Value = 50;
            // 
            // TempValue
            // 
            this.TempValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TempValue.Location = new System.Drawing.Point(98, 250);
            this.TempValue.Name = "TempValue";
            this.TempValue.ReadOnly = true;
            this.TempValue.Size = new System.Drawing.Size(35, 20);
            this.TempValue.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Temp";
            // 
            // TempBar
            // 
            this.TempBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TempBar.Enabled = false;
            this.TempBar.ForeColor = System.Drawing.Color.Maroon;
            this.TempBar.Location = new System.Drawing.Point(98, 41);
            this.TempBar.MarqueeAnimationSpeed = 0;
            this.TempBar.Name = "TempBar";
            this.TempBar.Size = new System.Drawing.Size(35, 203);
            this.TempBar.TabIndex = 23;
            this.TempBar.Value = 50;
            // 
            // PowerValue
            // 
            this.PowerValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerValue.Location = new System.Drawing.Point(3, 250);
            this.PowerValue.Name = "PowerValue";
            this.PowerValue.ReadOnly = true;
            this.PowerValue.Size = new System.Drawing.Size(38, 20);
            this.PowerValue.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Power";
            // 
            // PowerBar
            // 
            this.PowerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PowerBar.Enabled = false;
            this.PowerBar.Location = new System.Drawing.Point(3, 25);
            this.PowerBar.MarqueeAnimationSpeed = 0;
            this.PowerBar.Name = "PowerBar";
            this.PowerBar.Size = new System.Drawing.Size(38, 219);
            this.PowerBar.TabIndex = 20;
            this.PowerBar.Value = 50;
            // 
            // PowerTempControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TempDelta);
            this.Controls.Add(this.EssentialLabel);
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
            this.Name = "PowerTempControl";
            this.Size = new System.Drawing.Size(238, 273);
            ((System.ComponentModel.ISupportInitialize)(this.PowerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoolantTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TempDelta;
        private System.Windows.Forms.Label EssentialLabel;
        private System.Windows.Forms.TrackBar PowerTrack;
        private System.Windows.Forms.TrackBar CoolantTrack;
        private System.Windows.Forms.TextBox CoolantValue;
        private System.Windows.Forms.Label label3;
        private VerticalProgressBar CoolantBar;
        private System.Windows.Forms.TextBox TempValue;
        private System.Windows.Forms.Label label2;
        private VerticalProgressBar TempBar;
        private System.Windows.Forms.TextBox PowerValue;
        private System.Windows.Forms.Label label1;
        private VerticalProgressBar PowerBar;
    }
}
