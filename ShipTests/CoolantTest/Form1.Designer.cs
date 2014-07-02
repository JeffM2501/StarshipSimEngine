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
            this.HeatSinkFactor = new System.Windows.Forms.NumericUpDown();
            this.CoolantGroup = new System.Windows.Forms.GroupBox();
            this.TempDelta = new System.Windows.Forms.Label();
            this.VentCoolant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CoolantToVent = new System.Windows.Forms.NumericUpDown();
            this.CoolantInSystem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnAllocatedCoolantValue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BallanceCool = new System.Windows.Forms.Button();
            this.SplitCool = new System.Windows.Forms.Button();
            this.NominalAll = new System.Windows.Forms.Button();
            this.ShutdownAll = new System.Windows.Forms.Button();
            this.EngineGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.verticalProgressBar1 = new CoolantTest.VerticalProgressBar();
            this.TempBar = new CoolantTest.VerticalProgressBar();
            this.UnallocatedCoolantBar = new CoolantTest.VerticalProgressBar();
            this.CoolantBar = new CoolantTest.VerticalProgressBar();
            this.powerTempControl1 = new CoolantTest.PowerTempControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.verticalProgressBar2 = new CoolantTest.VerticalProgressBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ReservoirsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeatSinkFactor)).BeginInit();
            this.CoolantGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoolantToVent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.EngineGroup.SuspendLayout();
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
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Heat Sink";
            // 
            // HeatSinkFactor
            // 
            this.HeatSinkFactor.DecimalPlaces = 3;
            this.HeatSinkFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.HeatSinkFactor.Location = new System.Drawing.Point(134, 228);
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
            this.CoolantGroup.Controls.Add(this.UnallocatedCoolantBar);
            this.CoolantGroup.Controls.Add(this.CoolantBar);
            this.CoolantGroup.Controls.Add(this.label2);
            this.CoolantGroup.Controls.Add(this.TempLable);
            this.CoolantGroup.Controls.Add(this.UnAllocatedCoolantValue);
            this.CoolantGroup.Controls.Add(this.pictureBox1);
            this.CoolantGroup.Controls.Add(this.CoolantValue);
            this.CoolantGroup.Controls.Add(this.TempValue);
            this.CoolantGroup.Location = new System.Drawing.Point(936, 414);
            this.CoolantGroup.Name = "CoolantGroup";
            this.CoolantGroup.Size = new System.Drawing.Size(272, 278);
            this.CoolantGroup.TabIndex = 17;
            this.CoolantGroup.TabStop = false;
            this.CoolantGroup.Text = "Cooling System";
            this.CoolantGroup.Enter += new System.EventHandler(this.CoolantGroup_Enter);
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
            // VentCoolant
            // 
            this.VentCoolant.Location = new System.Drawing.Point(9, 250);
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
            this.label5.Location = new System.Drawing.Point(6, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Coolant Loss Simulation";
            // 
            // CoolantToVent
            // 
            this.CoolantToVent.Location = new System.Drawing.Point(9, 228);
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
            this.groupBox1.Location = new System.Drawing.Point(432, 414);
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
            // EngineGroup
            // 
            this.EngineGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EngineGroup.Controls.Add(this.textBox2);
            this.EngineGroup.Controls.Add(this.label6);
            this.EngineGroup.Controls.Add(this.verticalProgressBar2);
            this.EngineGroup.Controls.Add(this.textBox3);
            this.EngineGroup.Controls.Add(this.powerTempControl1);
            this.EngineGroup.Controls.Add(this.label3);
            this.EngineGroup.Controls.Add(this.verticalProgressBar1);
            this.EngineGroup.Controls.Add(this.textBox1);
            this.EngineGroup.Location = new System.Drawing.Point(585, 414);
            this.EngineGroup.Name = "EngineGroup";
            this.EngineGroup.Size = new System.Drawing.Size(345, 278);
            this.EngineGroup.TabIndex = 19;
            this.EngineGroup.TabStop = false;
            this.EngineGroup.Text = "Engine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fuel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 14;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(6, 36);
            this.verticalProgressBar1.MarqueeAnimationSpeed = 0;
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(32, 208);
            this.verticalProgressBar1.TabIndex = 12;
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
            // powerTempControl1
            // 
            this.powerTempControl1.Location = new System.Drawing.Point(44, 19);
            this.powerTempControl1.Name = "powerTempControl1";
            this.powerTempControl1.Size = new System.Drawing.Size(238, 256);
            this.powerTempControl1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Available";
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.Location = new System.Drawing.Point(291, 51);
            this.verticalProgressBar2.MarqueeAnimationSpeed = 0;
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(35, 186);
            this.verticalProgressBar2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 698);
            this.Controls.Add(this.EngineGroup);
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
            this.EngineGroup.ResumeLayout(false);
            this.EngineGroup.PerformLayout();
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
        private System.Windows.Forms.GroupBox EngineGroup;
        private System.Windows.Forms.Label label3;
        private VerticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private PowerTempControl powerTempControl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private VerticalProgressBar verticalProgressBar2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

