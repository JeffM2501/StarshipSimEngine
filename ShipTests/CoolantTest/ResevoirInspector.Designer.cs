namespace CoolantTest
{
    partial class ResevoirInspector
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
            this.CoolantBar = new CoolantTest.VerticalProgressBar();
            this.ResevourID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TempBar = new CoolantTest.VerticalProgressBar();
            this.TempLable = new System.Windows.Forms.Label();
            this.CoolantValue = new System.Windows.Forms.TextBox();
            this.TempValue = new System.Windows.Forms.TextBox();
            this.Connected = new System.Windows.Forms.CheckBox();
            this.Flush = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.ToSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoolantBar
            // 
            this.CoolantBar.Location = new System.Drawing.Point(6, 34);
            this.CoolantBar.MarqueeAnimationSpeed = 0;
            this.CoolantBar.Name = "CoolantBar";
            this.CoolantBar.Size = new System.Drawing.Size(100, 142);
            this.CoolantBar.TabIndex = 0;
            // 
            // ResevourID
            // 
            this.ResevourID.AutoSize = true;
            this.ResevourID.Location = new System.Drawing.Point(3, 0);
            this.ResevourID.Name = "ResevourID";
            this.ResevourID.Size = new System.Drawing.Size(13, 13);
            this.ResevourID.TabIndex = 1;
            this.ResevourID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coolant";
            // 
            // TempBar
            // 
            this.TempBar.Location = new System.Drawing.Point(112, 34);
            this.TempBar.MarqueeAnimationSpeed = 0;
            this.TempBar.Name = "TempBar";
            this.TempBar.Size = new System.Drawing.Size(35, 142);
            this.TempBar.TabIndex = 3;
            // 
            // TempLable
            // 
            this.TempLable.AutoSize = true;
            this.TempLable.Location = new System.Drawing.Point(112, 18);
            this.TempLable.Name = "TempLable";
            this.TempLable.Size = new System.Drawing.Size(37, 13);
            this.TempLable.TabIndex = 4;
            this.TempLable.Text = "Temp.";
            // 
            // CoolantValue
            // 
            this.CoolantValue.Location = new System.Drawing.Point(6, 182);
            this.CoolantValue.Name = "CoolantValue";
            this.CoolantValue.ReadOnly = true;
            this.CoolantValue.Size = new System.Drawing.Size(100, 20);
            this.CoolantValue.TabIndex = 5;
            // 
            // TempValue
            // 
            this.TempValue.Location = new System.Drawing.Point(112, 182);
            this.TempValue.Name = "TempValue";
            this.TempValue.ReadOnly = true;
            this.TempValue.Size = new System.Drawing.Size(35, 20);
            this.TempValue.TabIndex = 6;
            // 
            // Connected
            // 
            this.Connected.AutoSize = true;
            this.Connected.Location = new System.Drawing.Point(6, 209);
            this.Connected.Name = "Connected";
            this.Connected.Size = new System.Drawing.Size(78, 17);
            this.Connected.TabIndex = 7;
            this.Connected.Text = "Connected";
            this.Connected.UseVisualStyleBackColor = true;
            this.Connected.CheckedChanged += new System.EventHandler(this.Connected_CheckedChanged);
            // 
            // Flush
            // 
            this.Flush.Location = new System.Drawing.Point(153, 34);
            this.Flush.Name = "Flush";
            this.Flush.Size = new System.Drawing.Size(40, 23);
            this.Flush.TabIndex = 8;
            this.Flush.Text = "Flush";
            this.Flush.UseVisualStyleBackColor = true;
            this.Flush.Click += new System.EventHandler(this.Flush_Click);
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(153, 63);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(40, 23);
            this.Fill.TabIndex = 9;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // ToSystem
            // 
            this.ToSystem.Location = new System.Drawing.Point(153, 92);
            this.ToSystem.Name = "ToSystem";
            this.ToSystem.Size = new System.Drawing.Size(40, 23);
            this.ToSystem.TabIndex = 10;
            this.ToSystem.Text = ">Sys";
            this.ToSystem.UseVisualStyleBackColor = true;
            this.ToSystem.Click += new System.EventHandler(this.ToSystem_Click);
            // 
            // ResevoirInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToSystem);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Flush);
            this.Controls.Add(this.Connected);
            this.Controls.Add(this.TempValue);
            this.Controls.Add(this.CoolantValue);
            this.Controls.Add(this.TempLable);
            this.Controls.Add(this.TempBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResevourID);
            this.Controls.Add(this.CoolantBar);
            this.Name = "ResevoirInspector";
            this.Size = new System.Drawing.Size(198, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VerticalProgressBar CoolantBar;
        private System.Windows.Forms.Label ResevourID;
        private System.Windows.Forms.Label label1;
        private VerticalProgressBar TempBar;
        private System.Windows.Forms.Label TempLable;
        private System.Windows.Forms.TextBox CoolantValue;
        private System.Windows.Forms.TextBox TempValue;
        private System.Windows.Forms.CheckBox Connected;
        private System.Windows.Forms.Button Flush;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button ToSystem;
    }
}
