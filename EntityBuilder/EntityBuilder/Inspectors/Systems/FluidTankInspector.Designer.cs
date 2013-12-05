namespace EntityBuilder.Inspectors.Systems
{
    partial class FluidTankInspector
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
            this.Capacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxFlowRate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.FluidType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFlowRate)).BeginInit();
            this.SuspendLayout();
            // 
            // Capacity
            // 
            this.Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Capacity.DecimalPlaces = 2;
            this.Capacity.Location = new System.Drawing.Point(90, 369);
            this.Capacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(105, 20);
            this.Capacity.TabIndex = 27;
            this.Capacity.ValueChanged += new System.EventHandler(this.Capacity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Capacity";
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.DecimalPlaces = 2;
            this.Quantity.Location = new System.Drawing.Point(90, 343);
            this.Quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(105, 20);
            this.Quantity.TabIndex = 25;
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Qantity";
            // 
            // MaxFlowRate
            // 
            this.MaxFlowRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxFlowRate.DecimalPlaces = 2;
            this.MaxFlowRate.Location = new System.Drawing.Point(90, 317);
            this.MaxFlowRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxFlowRate.Name = "MaxFlowRate";
            this.MaxFlowRate.Size = new System.Drawing.Size(105, 20);
            this.MaxFlowRate.TabIndex = 23;
            this.MaxFlowRate.ValueChanged += new System.EventHandler(this.MaxFlowRate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max Flow Rate";
            // 
            // FluidType
            // 
            this.FluidType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FluidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FluidType.FormattingEnabled = true;
            this.FluidType.Location = new System.Drawing.Point(6, 290);
            this.FluidType.Name = "FluidType";
            this.FluidType.Size = new System.Drawing.Size(189, 21);
            this.FluidType.TabIndex = 21;
            this.FluidType.SelectedIndexChanged += new System.EventHandler(this.FluidType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fluid Type";
            // 
            // FluidTankInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaxFlowRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FluidType);
            this.Controls.Add(this.label8);
            this.Name = "FluidTankInspector";
            this.Size = new System.Drawing.Size(200, 404);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.FluidType, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.MaxFlowRate, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.Quantity, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Capacity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFlowRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Capacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MaxFlowRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FluidType;
        private System.Windows.Forms.Label label8;
    }
}
