namespace CoolantTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShipSystems = new System.Windows.Forms.FlowLayoutPanel();
            this.ReservoirsGroup = new System.Windows.Forms.GroupBox();
            this.ReservoirsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.TempValue = new System.Windows.Forms.TextBox();
            this.CoolantValue = new System.Windows.Forms.TextBox();
            this.TempLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeatSinkFactor = new System.Windows.Forms.NumericUpDown();
            this.CoolantBar = new CoolantTest.VerticalProgressBar();
            this.TempBar = new CoolantTest.VerticalProgressBar();
            this.CoolantGroup = new System.Windows.Forms.GroupBox();
            this.ReservoirsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatSinkFactor)).BeginInit();
            this.CoolantGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShipSystems
            // 
            this.ShipSystems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipSystems.AutoScroll = true;
            this.ShipSystems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ShipSystems.Location = new System.Drawing.Point(1, 12);
            this.ShipSystems.Name = "ShipSystems";
            this.ShipSystems.Size = new System.Drawing.Size(1143, 381);
            this.ShipSystems.TabIndex = 0;
            // 
            // ReservoirsGroup
            // 
            this.ReservoirsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservoirsGroup.Controls.Add(this.ReservoirsContainer);
            this.ReservoirsGroup.Location = new System.Drawing.Point(1, 399);
            this.ReservoirsGroup.Name = "ReservoirsGroup";
            this.ReservoirsGroup.Size = new System.Drawing.Size(595, 278);
            this.ReservoirsGroup.TabIndex = 2;
            this.ReservoirsGroup.TabStop = false;
            this.ReservoirsGroup.Text = "Reservoirs";
            // 
            // ReservoirsContainer
            // 
            this.ReservoirsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservoirsContainer.AutoScroll = true;
            this.ReservoirsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ReservoirsContainer.Location = new System.Drawing.Point(6, 19);
            this.ReservoirsContainer.Name = "ReservoirsContainer";
            this.ReservoirsContainer.Size = new System.Drawing.Size(583, 253);
            this.ReservoirsContainer.TabIndex = 0;
            // 
            // TempValue
            // 
            this.TempValue.Location = new System.Drawing.Point(115, 183);
            this.TempValue.Name = "TempValue";
            this.TempValue.ReadOnly = true;
            this.TempValue.Size = new System.Drawing.Size(35, 20);
            this.TempValue.TabIndex = 12;
            // 
            // CoolantValue
            // 
            this.CoolantValue.Location = new System.Drawing.Point(9, 183);
            this.CoolantValue.Name = "CoolantValue";
            this.CoolantValue.ReadOnly = true;
            this.CoolantValue.Size = new System.Drawing.Size(100, 20);
            this.CoolantValue.TabIndex = 11;
            // 
            // TempLable
            // 
            this.TempLable.AutoSize = true;
            this.TempLable.Location = new System.Drawing.Point(115, 19);
            this.TempLable.Name = "TempLable";
            this.TempLable.Size = new System.Drawing.Size(37, 13);
            this.TempLable.TabIndex = 10;
            this.TempLable.Text = "Temp.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coolant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 132);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Heat Sink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Removed";
            // 
            // HeatSinkFactor
            // 
            this.HeatSinkFactor.Location = new System.Drawing.Point(462, 172);
            this.HeatSinkFactor.Name = "HeatSinkFactor";
            this.HeatSinkFactor.Size = new System.Drawing.Size(74, 20);
            this.HeatSinkFactor.TabIndex = 16;
            this.HeatSinkFactor.ValueChanged += new System.EventHandler(this.HeatSinkFactor_ValueChanged);
            // 
            // CoolantBar
            // 
            this.CoolantBar.Location = new System.Drawing.Point(9, 35);
            this.CoolantBar.MarqueeAnimationSpeed = 0;
            this.CoolantBar.Name = "CoolantBar";
            this.CoolantBar.Size = new System.Drawing.Size(100, 142);
            this.CoolantBar.TabIndex = 7;
            // 
            // TempBar
            // 
            this.TempBar.Location = new System.Drawing.Point(115, 35);
            this.TempBar.MarqueeAnimationSpeed = 0;
            this.TempBar.Name = "TempBar";
            this.TempBar.Size = new System.Drawing.Size(35, 142);
            this.TempBar.TabIndex = 9;
            // 
            // CoolantGroup
            // 
            this.CoolantGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoolantGroup.Controls.Add(this.label1);
            this.CoolantGroup.Controls.Add(this.HeatSinkFactor);
            this.CoolantGroup.Controls.Add(this.TempBar);
            this.CoolantGroup.Controls.Add(this.label3);
            this.CoolantGroup.Controls.Add(this.CoolantBar);
            this.CoolantGroup.Controls.Add(this.label2);
            this.CoolantGroup.Controls.Add(this.TempLable);
            this.CoolantGroup.Controls.Add(this.pictureBox1);
            this.CoolantGroup.Controls.Add(this.CoolantValue);
            this.CoolantGroup.Controls.Add(this.TempValue);
            this.CoolantGroup.Location = new System.Drawing.Point(602, 399);
            this.CoolantGroup.Name = "CoolantGroup";
            this.CoolantGroup.Size = new System.Drawing.Size(542, 278);
            this.CoolantGroup.TabIndex = 17;
            this.CoolantGroup.TabStop = false;
            this.CoolantGroup.Text = "Cooling System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 683);
            this.Controls.Add(this.CoolantGroup);
            this.Controls.Add(this.ReservoirsGroup);
            this.Controls.Add(this.ShipSystems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ReservoirsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatSinkFactor)).EndInit();
            this.CoolantGroup.ResumeLayout(false);
            this.CoolantGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ShipSystems;
        private System.Windows.Forms.GroupBox ReservoirsGroup;
        private System.Windows.Forms.FlowLayoutPanel ReservoirsContainer;
        private System.Windows.Forms.TextBox TempValue;
        private System.Windows.Forms.TextBox CoolantValue;
        private System.Windows.Forms.Label TempLable;
        private VerticalProgressBar TempBar;
        private System.Windows.Forms.Label label1;
        private VerticalProgressBar CoolantBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HeatSinkFactor;
        private System.Windows.Forms.GroupBox CoolantGroup;
    }
}

