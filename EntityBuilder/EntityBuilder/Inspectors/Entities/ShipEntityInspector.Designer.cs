namespace EntityBuilder.Inspectors.Entities
{
    partial class ShipEntityInspector
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
            this.label3 = new System.Windows.Forms.Label();
            this.SizeClassList = new System.Windows.Forms.ComboBox();
            this.FactionID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FactionID)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size Class";
            // 
            // SizeClassList
            // 
            this.SizeClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeClassList.FormattingEnabled = true;
            this.SizeClassList.Location = new System.Drawing.Point(7, 71);
            this.SizeClassList.Name = "SizeClassList";
            this.SizeClassList.Size = new System.Drawing.Size(175, 21);
            this.SizeClassList.TabIndex = 5;
            this.SizeClassList.SelectedIndexChanged += new System.EventHandler(this.SizeClassList_SelectedIndexChanged);
            // 
            // FactionID
            // 
            this.FactionID.Location = new System.Drawing.Point(62, 98);
            this.FactionID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.FactionID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.FactionID.Name = "FactionID";
            this.FactionID.Size = new System.Drawing.Size(120, 20);
            this.FactionID.TabIndex = 7;
            this.FactionID.ValueChanged += new System.EventHandler(this.FactionID_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "FactionID";
            // 
            // ShipEntityInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FactionID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeClassList);
            this.Controls.Add(this.label3);
            this.Name = "ShipEntityInspector";
            this.Size = new System.Drawing.Size(185, 264);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.SizeClassList, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.FactionID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.FactionID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SizeClassList;
        private System.Windows.Forms.NumericUpDown FactionID;
        private System.Windows.Forms.Label label4;
    }
}
