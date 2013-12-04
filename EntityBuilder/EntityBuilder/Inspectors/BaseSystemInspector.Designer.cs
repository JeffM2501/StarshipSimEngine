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
            this.SystemLocation = new EntityBuilder.Controls.Vector3Editor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BaseEffectivness = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxBuffer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlComputer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseEffectivness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Draw)).BeginInit();
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
            // SystemLocation
            // 
            this.SystemLocation.LabelName = "System Location";
            this.SystemLocation.Location = new System.Drawing.Point(6, 27);
            this.SystemLocation.Name = "SystemLocation";
            this.SystemLocation.Size = new System.Drawing.Size(173, 100);
            this.SystemLocation.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaseEffectivness);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MaxBuffer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Draw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power";
            // 
            // BaseEffectivness
            // 
            this.BaseEffectivness.DecimalPlaces = 2;
            this.BaseEffectivness.Location = new System.Drawing.Point(70, 66);
            this.BaseEffectivness.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BaseEffectivness.Name = "BaseEffectivness";
            this.BaseEffectivness.Size = new System.Drawing.Size(113, 20);
            this.BaseEffectivness.TabIndex = 5;
            this.BaseEffectivness.ValueChanged += new System.EventHandler(this.BaseEffectivness_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Efectivness";
            // 
            // MaxBuffer
            // 
            this.MaxBuffer.DecimalPlaces = 2;
            this.MaxBuffer.Location = new System.Drawing.Point(70, 40);
            this.MaxBuffer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxBuffer.Name = "MaxBuffer";
            this.MaxBuffer.Size = new System.Drawing.Size(113, 20);
            this.MaxBuffer.TabIndex = 3;
            this.MaxBuffer.ValueChanged += new System.EventHandler(this.MaxBuffer_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Buffer";
            // 
            // Draw
            // 
            this.Draw.DecimalPlaces = 2;
            this.Draw.Location = new System.Drawing.Point(70, 14);
            this.Draw.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(113, 20);
            this.Draw.TabIndex = 1;
            this.Draw.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Draw";
            // 
            // ControlComputer
            // 
            this.ControlComputer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlComputer.FormattingEnabled = true;
            this.ControlComputer.Location = new System.Drawing.Point(6, 246);
            this.ControlComputer.Name = "ControlComputer";
            this.ControlComputer.Size = new System.Drawing.Size(189, 21);
            this.ControlComputer.TabIndex = 7;
            this.ControlComputer.SelectedIndexChanged += new System.EventHandler(this.ControlComputer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Control Computer";
            // 
            // BaseSystemInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlComputer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SystemLocation);
            this.Controls.Add(this.SystemName);
            this.Name = "BaseSystemInspector";
            this.Size = new System.Drawing.Size(200, 273);
            this.Load += new System.EventHandler(this.BaseSystemInspector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaseEffectivness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SystemName;
        private Controls.Vector3Editor SystemLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown MaxBuffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Draw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BaseEffectivness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ControlComputer;
        private System.Windows.Forms.Label label5;
    }
}
