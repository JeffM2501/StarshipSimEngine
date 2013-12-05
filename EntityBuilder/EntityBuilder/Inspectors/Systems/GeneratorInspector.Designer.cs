namespace EntityBuilder.Inspectors.Systems
{
    partial class GeneratorInspector
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
            this.GeneratorType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PowerGeneration = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FuelList = new System.Windows.Forms.ListBox();
            this.AddFuel = new System.Windows.Forms.Button();
            this.RemoveFuel = new System.Windows.Forms.Button();
            this.EditFuel = new System.Windows.Forms.Button();
            this.EditByproduct = new System.Windows.Forms.Button();
            this.RemoveByproduct = new System.Windows.Forms.Button();
            this.AddByproduct = new System.Windows.Forms.Button();
            this.ByproductList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PowerGeneration)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratorType
            // 
            this.GeneratorType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneratorType.FormattingEnabled = true;
            this.GeneratorType.Location = new System.Drawing.Point(6, 286);
            this.GeneratorType.Name = "GeneratorType";
            this.GeneratorType.Size = new System.Drawing.Size(189, 21);
            this.GeneratorType.TabIndex = 11;
            this.GeneratorType.SelectedIndexChanged += new System.EventHandler(this.GeneratorType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Generator Type";
            // 
            // PowerGeneration
            // 
            this.PowerGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerGeneration.DecimalPlaces = 2;
            this.PowerGeneration.Location = new System.Drawing.Point(102, 313);
            this.PowerGeneration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PowerGeneration.Name = "PowerGeneration";
            this.PowerGeneration.Size = new System.Drawing.Size(87, 20);
            this.PowerGeneration.TabIndex = 13;
            this.PowerGeneration.ValueChanged += new System.EventHandler(this.PowerGeneration_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Power Generation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fuel Feeds";
            // 
            // FuelList
            // 
            this.FuelList.FormattingEnabled = true;
            this.FuelList.Location = new System.Drawing.Point(6, 359);
            this.FuelList.Name = "FuelList";
            this.FuelList.Size = new System.Drawing.Size(188, 95);
            this.FuelList.TabIndex = 15;
            // 
            // AddFuel
            // 
            this.AddFuel.Location = new System.Drawing.Point(7, 460);
            this.AddFuel.Name = "AddFuel";
            this.AddFuel.Size = new System.Drawing.Size(18, 23);
            this.AddFuel.TabIndex = 16;
            this.AddFuel.Text = "+";
            this.AddFuel.UseVisualStyleBackColor = true;
            this.AddFuel.Click += new System.EventHandler(this.AddFuel_Click);
            // 
            // RemoveFuel
            // 
            this.RemoveFuel.Location = new System.Drawing.Point(26, 460);
            this.RemoveFuel.Name = "RemoveFuel";
            this.RemoveFuel.Size = new System.Drawing.Size(18, 23);
            this.RemoveFuel.TabIndex = 18;
            this.RemoveFuel.Text = "-";
            this.RemoveFuel.UseVisualStyleBackColor = true;
            this.RemoveFuel.Click += new System.EventHandler(this.RemoveFuel_Click);
            // 
            // EditFuel
            // 
            this.EditFuel.Location = new System.Drawing.Point(45, 460);
            this.EditFuel.Name = "EditFuel";
            this.EditFuel.Size = new System.Drawing.Size(51, 23);
            this.EditFuel.TabIndex = 19;
            this.EditFuel.Text = "Edit";
            this.EditFuel.UseVisualStyleBackColor = true;
            this.EditFuel.Click += new System.EventHandler(this.EditFuel_Click);
            // 
            // EditByproduct
            // 
            this.EditByproduct.Location = new System.Drawing.Point(45, 606);
            this.EditByproduct.Name = "EditByproduct";
            this.EditByproduct.Size = new System.Drawing.Size(51, 23);
            this.EditByproduct.TabIndex = 24;
            this.EditByproduct.Text = "Edit";
            this.EditByproduct.UseVisualStyleBackColor = true;
            this.EditByproduct.Click += new System.EventHandler(this.EditByproduct_Click);
            // 
            // RemoveByproduct
            // 
            this.RemoveByproduct.Location = new System.Drawing.Point(26, 606);
            this.RemoveByproduct.Name = "RemoveByproduct";
            this.RemoveByproduct.Size = new System.Drawing.Size(18, 23);
            this.RemoveByproduct.TabIndex = 23;
            this.RemoveByproduct.Text = "-";
            this.RemoveByproduct.UseVisualStyleBackColor = true;
            this.RemoveByproduct.Click += new System.EventHandler(this.RemoveByproduct_Click);
            // 
            // AddByproduct
            // 
            this.AddByproduct.Location = new System.Drawing.Point(7, 606);
            this.AddByproduct.Name = "AddByproduct";
            this.AddByproduct.Size = new System.Drawing.Size(18, 23);
            this.AddByproduct.TabIndex = 22;
            this.AddByproduct.Text = "+";
            this.AddByproduct.UseVisualStyleBackColor = true;
            this.AddByproduct.Click += new System.EventHandler(this.AddByproduct_Click);
            // 
            // ByproductList
            // 
            this.ByproductList.FormattingEnabled = true;
            this.ByproductList.Location = new System.Drawing.Point(6, 505);
            this.ByproductList.Name = "ByproductList";
            this.ByproductList.Size = new System.Drawing.Size(188, 95);
            this.ByproductList.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Byproducts";
            // 
            // GeneratorInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditByproduct);
            this.Controls.Add(this.RemoveByproduct);
            this.Controls.Add(this.AddByproduct);
            this.Controls.Add(this.ByproductList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EditFuel);
            this.Controls.Add(this.RemoveFuel);
            this.Controls.Add(this.AddFuel);
            this.Controls.Add(this.FuelList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PowerGeneration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GeneratorType);
            this.Controls.Add(this.label1);
            this.Name = "GeneratorInspector";
            this.Size = new System.Drawing.Size(200, 637);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.GeneratorType, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.PowerGeneration, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.FuelList, 0);
            this.Controls.SetChildIndex(this.AddFuel, 0);
            this.Controls.SetChildIndex(this.RemoveFuel, 0);
            this.Controls.SetChildIndex(this.EditFuel, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.ByproductList, 0);
            this.Controls.SetChildIndex(this.AddByproduct, 0);
            this.Controls.SetChildIndex(this.RemoveByproduct, 0);
            this.Controls.SetChildIndex(this.EditByproduct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PowerGeneration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GeneratorType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PowerGeneration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox FuelList;
        private System.Windows.Forms.Button AddFuel;
        private System.Windows.Forms.Button RemoveFuel;
        private System.Windows.Forms.Button EditFuel;
        private System.Windows.Forms.Button EditByproduct;
        private System.Windows.Forms.Button RemoveByproduct;
        private System.Windows.Forms.Button AddByproduct;
        private System.Windows.Forms.ListBox ByproductList;
        private System.Windows.Forms.Label label8;
    }
}
