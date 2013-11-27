namespace EntityBuilder.Controls
{
    partial class Vector3Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.XValue = new System.Windows.Forms.NumericUpDown();
            this.YValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ZValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // XValue
            // 
            this.XValue.DecimalPlaces = 4;
            this.XValue.Location = new System.Drawing.Point(44, 20);
            this.XValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.XValue.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.XValue.Name = "XValue";
            this.XValue.Size = new System.Drawing.Size(99, 20);
            this.XValue.TabIndex = 1;
            this.XValue.ValueChanged += new System.EventHandler(this.XValue_ValueChanged);
            // 
            // YValue
            // 
            this.YValue.DecimalPlaces = 4;
            this.YValue.Location = new System.Drawing.Point(44, 46);
            this.YValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.YValue.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.YValue.Name = "YValue";
            this.YValue.Size = new System.Drawing.Size(99, 20);
            this.YValue.TabIndex = 3;
            this.YValue.ValueChanged += new System.EventHandler(this.YValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // ZValue
            // 
            this.ZValue.DecimalPlaces = 4;
            this.ZValue.Location = new System.Drawing.Point(44, 72);
            this.ZValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ZValue.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.ZValue.Name = "ZValue";
            this.ZValue.Size = new System.Drawing.Size(99, 20);
            this.ZValue.TabIndex = 5;
            this.ZValue.ValueChanged += new System.EventHandler(this.ZValue_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z";
            // 
            // ValueName
            // 
            this.ValueName.AutoSize = true;
            this.ValueName.Location = new System.Drawing.Point(0, 0);
            this.ValueName.Name = "ValueName";
            this.ValueName.Size = new System.Drawing.Size(35, 13);
            this.ValueName.TabIndex = 6;
            this.ValueName.Text = "Name";
            // 
            // Vector3Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueName);
            this.Controls.Add(this.ZValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XValue);
            this.Controls.Add(this.label1);
            this.Name = "Vector3Editor";
            this.Size = new System.Drawing.Size(148, 100);
            this.Load += new System.EventHandler(this.Vector3Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown XValue;
        private System.Windows.Forms.NumericUpDown YValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ZValue;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label ValueName;

    }
}
