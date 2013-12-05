namespace EntityBuilder.Inspectors.Systems
{
    partial class ComputerInspector
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
            this.ComputerType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompSpeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerType
            // 
            this.ComputerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComputerType.FormattingEnabled = true;
            this.ComputerType.Location = new System.Drawing.Point(6, 286);
            this.ComputerType.Name = "ComputerType";
            this.ComputerType.Size = new System.Drawing.Size(189, 21);
            this.ComputerType.TabIndex = 9;
            this.ComputerType.SelectedIndexChanged += new System.EventHandler(this.ComputerType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Computer Type";
            // 
            // CompSpeed
            // 
            this.CompSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompSpeed.DecimalPlaces = 2;
            this.CompSpeed.Location = new System.Drawing.Point(110, 313);
            this.CompSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CompSpeed.Name = "CompSpeed";
            this.CompSpeed.Size = new System.Drawing.Size(79, 20);
            this.CompSpeed.TabIndex = 11;
            this.CompSpeed.ValueChanged += new System.EventHandler(this.CompSpeed_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Computation Speed";
            // 
            // ComputerInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComputerType);
            this.Controls.Add(this.label1);
            this.Name = "ComputerInspector";
            this.Size = new System.Drawing.Size(200, 341);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ComputerType, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.CompSpeed, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CompSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComputerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CompSpeed;
        private System.Windows.Forms.Label label6;
    }
}
