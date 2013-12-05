namespace EntityBuilder.Inspectors.Dialogs
{
    partial class FuelConsumptionEditor
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
            this.FluidType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsumptionRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Efficency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveTank = new System.Windows.Forms.Button();
            this.AddTank = new System.Windows.Forms.Button();
            this.FuelList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TankList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumptionRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Efficency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(117, 275);
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
            this.Cancel.Location = new System.Drawing.Point(36, 275);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // FluidType
            // 
            this.FluidType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FluidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FluidType.FormattingEnabled = true;
            this.FluidType.Location = new System.Drawing.Point(3, 25);
            this.FluidType.Name = "FluidType";
            this.FluidType.Size = new System.Drawing.Size(189, 21);
            this.FluidType.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fluid Type";
            // 
            // ConsumptionRate
            // 
            this.ConsumptionRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumptionRate.DecimalPlaces = 2;
            this.ConsumptionRate.Location = new System.Drawing.Point(57, 52);
            this.ConsumptionRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ConsumptionRate.Name = "ConsumptionRate";
            this.ConsumptionRate.Size = new System.Drawing.Size(135, 20);
            this.ConsumptionRate.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rate";
            // 
            // Efficency
            // 
            this.Efficency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Efficency.DecimalPlaces = 2;
            this.Efficency.Location = new System.Drawing.Point(57, 78);
            this.Efficency.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Efficency.Name = "Efficency";
            this.Efficency.Size = new System.Drawing.Size(135, 20);
            this.Efficency.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Efficency";
            // 
            // Capacity
            // 
            this.Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Capacity.DecimalPlaces = 2;
            this.Capacity.Location = new System.Drawing.Point(57, 104);
            this.Capacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(135, 20);
            this.Capacity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Capacity";
            // 
            // RemoveTank
            // 
            this.RemoveTank.Location = new System.Drawing.Point(5, 243);
            this.RemoveTank.Name = "RemoveTank";
            this.RemoveTank.Size = new System.Drawing.Size(18, 23);
            this.RemoveTank.TabIndex = 23;
            this.RemoveTank.Text = "-";
            this.RemoveTank.UseVisualStyleBackColor = true;
            this.RemoveTank.Click += new System.EventHandler(this.RemoveTank_Click);
            // 
            // AddTank
            // 
            this.AddTank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTank.Location = new System.Drawing.Point(174, 243);
            this.AddTank.Name = "AddTank";
            this.AddTank.Size = new System.Drawing.Size(18, 23);
            this.AddTank.TabIndex = 22;
            this.AddTank.Text = "+";
            this.AddTank.UseVisualStyleBackColor = true;
            this.AddTank.Click += new System.EventHandler(this.AddTank_Click);
            // 
            // FuelList
            // 
            this.FuelList.FormattingEnabled = true;
            this.FuelList.Location = new System.Drawing.Point(4, 142);
            this.FuelList.Name = "FuelList";
            this.FuelList.Size = new System.Drawing.Size(188, 95);
            this.FuelList.TabIndex = 21;
            this.FuelList.SelectedIndexChanged += new System.EventHandler(this.FuelList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Storage Tanks";
            // 
            // TankList
            // 
            this.TankList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TankList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TankList.FormattingEnabled = true;
            this.TankList.Location = new System.Drawing.Point(29, 243);
            this.TankList.Name = "TankList";
            this.TankList.Size = new System.Drawing.Size(139, 21);
            this.TankList.TabIndex = 24;
            // 
            // FuelConsumptionEditor
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(204, 310);
            this.Controls.Add(this.TankList);
            this.Controls.Add(this.RemoveTank);
            this.Controls.Add(this.AddTank);
            this.Controls.Add(this.FuelList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Efficency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsumptionRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FluidType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuelConsumptionEditor";
            this.Text = "Consumption";
            this.Load += new System.EventHandler(this.FuelConsumptionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsumptionRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Efficency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox FluidType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ConsumptionRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Efficency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Capacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveTank;
        private System.Windows.Forms.Button AddTank;
        private System.Windows.Forms.ListBox FuelList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TankList;
    }
}