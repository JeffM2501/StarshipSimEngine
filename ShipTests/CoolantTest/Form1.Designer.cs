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
            this.components = new System.ComponentModel.Container();
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
            this.CoolantGroup = new System.Windows.Forms.GroupBox();
            this.VentCoolant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CoolantToVent = new System.Windows.Forms.NumericUpDown();
            this.CoolantInSystem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TempBar = new CoolantTest.VerticalProgressBar();
            this.UnallocatedCoolantBar = new CoolantTest.VerticalProgressBar();
            this.CoolantBar = new CoolantTest.VerticalProgressBar();
            this.UnAllocatedCoolantValue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BallanceCool = new System.Windows.Forms.Button();
            this.SplitCool = new System.Windows.Forms.Button();
            this.NominalAll = new System.Windows.Forms.Button();
            this.ShutdownAll = new System.Windows.Forms.Button();
            this.TempDelta = new System.Windows.Forms.Label();
            this.ReservoirsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatSinkFactor)).BeginInit();
            this.CoolantGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoolantToVent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShipSystems
            // 
            this.ShipSystems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShipSystems.AutoScroll = true;
            this.ShipSystems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ShipSystems.Location = new System.Drawing.Point(1, 12);
            this.ShipSystems.Name = "ShipSystems";
            this.ShipSystems.Size = new System.Drawing.Size(1207, 396);
            this.ShipSystems.TabIndex = 0;
            // 
            // ReservoirsGroup
            // 
            this.ReservoirsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservoirsGroup.Controls.Add(this.ReservoirsContainer);
            this.ReservoirsGroup.Location = new System.Drawing.Point(1, 414);
            this.ReservoirsGroup.Name = "ReservoirsGroup";
            this.ReservoirsGroup.Size = new System.Drawing.Size(425, 278);
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
            this.ReservoirsContainer.Size = new System.Drawing.Size(413, 253);
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
            this.HeatSinkFactor.DecimalPlaces = 3;
            this.HeatSinkFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.HeatSinkFactor.Location = new System.Drawing.Point(462, 172);
            this.HeatSinkFactor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeatSinkFactor.Name = "HeatSinkFactor";
            this.HeatSinkFactor.Size = new System.Drawing.Size(74, 20);
            this.HeatSinkFactor.TabIndex = 16;
            this.HeatSinkFactor.ValueChanged += new System.EventHandler(this.HeatSinkFactor_ValueChanged);
            // 
            // CoolantGroup
            // 
            this.CoolantGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CoolantGroup.Controls.Add(this.TempDelta);
            this.CoolantGroup.Controls.Add(this.VentCoolant);
            this.CoolantGroup.Controls.Add(this.label5);
            this.CoolantGroup.Controls.Add(this.CoolantToVent);
            this.CoolantGroup.Controls.Add(this.CoolantInSystem);
            this.CoolantGroup.Controls.Add(this.label4);
            this.CoolantGroup.Controls.Add(this.label1);
            this.CoolantGroup.Controls.Add(this.HeatSinkFactor);
            this.CoolantGroup.Controls.Add(this.TempBar);
            this.CoolantGroup.Controls.Add(this.label3);
            this.CoolantGroup.Controls.Add(this.UnallocatedCoolantBar);
            this.CoolantGroup.Controls.Add(this.CoolantBar);
            this.CoolantGroup.Controls.Add(this.label2);
            this.CoolantGroup.Controls.Add(this.TempLable);
            this.CoolantGroup.Controls.Add(this.UnAllocatedCoolantValue);
            this.CoolantGroup.Controls.Add(this.pictureBox1);
            this.CoolantGroup.Controls.Add(this.CoolantValue);
            this.CoolantGroup.Controls.Add(this.TempValue);
            this.CoolantGroup.Location = new System.Drawing.Point(666, 414);
            this.CoolantGroup.Name = "CoolantGroup";
            this.CoolantGroup.Size = new System.Drawing.Size(542, 278);
            this.CoolantGroup.TabIndex = 17;
            this.CoolantGroup.TabStop = false;
            this.CoolantGroup.Text = "Cooling System";
            // 
            // VentCoolant
            // 
            this.VentCoolant.Location = new System.Drawing.Point(81, 248);
            this.VentCoolant.Name = "VentCoolant";
            this.VentCoolant.Size = new System.Drawing.Size(75, 23);
            this.VentCoolant.TabIndex = 20;
            this.VentCoolant.Text = "Vent";
            this.VentCoolant.UseVisualStyleBackColor = true;
            this.VentCoolant.Click += new System.EventHandler(this.VentCoolant_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Coolant Loss Simulation";
            // 
            // CoolantToVent
            // 
            this.CoolantToVent.Location = new System.Drawing.Point(9, 251);
            this.CoolantToVent.Name = "CoolantToVent";
            this.CoolantToVent.Size = new System.Drawing.Size(66, 20);
            this.CoolantToVent.TabIndex = 18;
            // 
            // CoolantInSystem
            // 
            this.CoolantInSystem.Location = new System.Drawing.Point(156, 35);
            this.CoolantInSystem.Name = "CoolantInSystem";
            this.CoolantInSystem.ReadOnly = true;
            this.CoolantInSystem.Size = new System.Drawing.Size(100, 20);
            this.CoolantInSystem.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unallocated Coolant";
            // 
            // TempBar
            // 
            this.TempBar.Location = new System.Drawing.Point(115, 58);
            this.TempBar.MarqueeAnimationSpeed = 0;
            this.TempBar.Name = "TempBar";
            this.TempBar.Size = new System.Drawing.Size(35, 119);
            this.TempBar.TabIndex = 9;
            // 
            // UnallocatedCoolantBar
            // 
            this.UnallocatedCoolantBar.Location = new System.Drawing.Point(156, 61);
            this.UnallocatedCoolantBar.MarqueeAnimationSpeed = 0;
            this.UnallocatedCoolantBar.Name = "UnallocatedCoolantBar";
            this.UnallocatedCoolantBar.Size = new System.Drawing.Size(100, 116);
            this.UnallocatedCoolantBar.TabIndex = 7;
            // 
            // CoolantBar
            // 
            this.CoolantBar.Location = new System.Drawing.Point(9, 35);
            this.CoolantBar.MarqueeAnimationSpeed = 0;
            this.CoolantBar.Name = "CoolantBar";
            this.CoolantBar.Size = new System.Drawing.Size(100, 142);
            this.CoolantBar.TabIndex = 7;
            // 
            // UnAllocatedCoolantValue
            // 
            this.UnAllocatedCoolantValue.Location = new System.Drawing.Point(156, 183);
            this.UnAllocatedCoolantValue.Name = "UnAllocatedCoolantValue";
            this.UnAllocatedCoolantValue.ReadOnly = true;
            this.UnAllocatedCoolantValue.Size = new System.Drawing.Size(100, 20);
            this.UnAllocatedCoolantValue.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BallanceCool);
            this.groupBox1.Controls.Add(this.SplitCool);
            this.groupBox1.Controls.Add(this.NominalAll);
            this.groupBox1.Controls.Add(this.ShutdownAll);
            this.groupBox1.Location = new System.Drawing.Point(513, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 278);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ballance Used Coolant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BallanceCool
            // 
            this.BallanceCool.Location = new System.Drawing.Point(6, 106);
            this.BallanceCool.Name = "BallanceCool";
            this.BallanceCool.Size = new System.Drawing.Size(135, 23);
            this.BallanceCool.TabIndex = 3;
            this.BallanceCool.Text = "Balance Coolant";
            this.BallanceCool.UseVisualStyleBackColor = true;
            this.BallanceCool.Click += new System.EventHandler(this.BallanceCool_Click);
            // 
            // SplitCool
            // 
            this.SplitCool.Location = new System.Drawing.Point(6, 77);
            this.SplitCool.Name = "SplitCool";
            this.SplitCool.Size = new System.Drawing.Size(135, 23);
            this.SplitCool.TabIndex = 2;
            this.SplitCool.Text = "Split Coolant";
            this.SplitCool.UseVisualStyleBackColor = true;
            this.SplitCool.Click += new System.EventHandler(this.SplitCool_Click);
            // 
            // NominalAll
            // 
            this.NominalAll.Location = new System.Drawing.Point(6, 48);
            this.NominalAll.Name = "NominalAll";
            this.NominalAll.Size = new System.Drawing.Size(135, 23);
            this.NominalAll.TabIndex = 1;
            this.NominalAll.Text = "All Systems to Nominal";
            this.NominalAll.UseVisualStyleBackColor = true;
            this.NominalAll.Click += new System.EventHandler(this.NominalAll_Click);
            // 
            // ShutdownAll
            // 
            this.ShutdownAll.Location = new System.Drawing.Point(6, 19);
            this.ShutdownAll.Name = "ShutdownAll";
            this.ShutdownAll.Size = new System.Drawing.Size(135, 23);
            this.ShutdownAll.TabIndex = 0;
            this.ShutdownAll.Text = "Shutdown All Systems";
            this.ShutdownAll.UseVisualStyleBackColor = true;
            this.ShutdownAll.Click += new System.EventHandler(this.ShutdownAll_Click);
            // 
            // TempDelta
            // 
            this.TempDelta.AutoSize = true;
            this.TempDelta.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TempDelta.ForeColor = System.Drawing.Color.Red;
            this.TempDelta.Location = new System.Drawing.Point(121, 36);
            this.TempDelta.Name = "TempDelta";
            this.TempDelta.Size = new System.Drawing.Size(25, 19);
            this.TempDelta.TabIndex = 21;
            this.TempDelta.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 698);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CoolantGroup);
            this.Controls.Add(this.ReservoirsGroup);
            this.Controls.Add(this.ShipSystems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ReservoirsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatSinkFactor)).EndInit();
            this.CoolantGroup.ResumeLayout(false);
            this.CoolantGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoolantToVent)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private VerticalProgressBar UnallocatedCoolantBar;
        private System.Windows.Forms.TextBox UnAllocatedCoolantValue;
        private System.Windows.Forms.TextBox CoolantInSystem;
        private System.Windows.Forms.Button VentCoolant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CoolantToVent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BallanceCool;
        private System.Windows.Forms.Button SplitCool;
        private System.Windows.Forms.Button NominalAll;
        private System.Windows.Forms.Button ShutdownAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TempDelta;
    }
}

