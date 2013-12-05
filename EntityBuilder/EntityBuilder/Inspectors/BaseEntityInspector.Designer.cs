namespace EntityBuilder.Inspectors
{
    partial class BaseEntityInspector
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
            this.ParrentID = new System.Windows.Forms.NumericUpDown();
            this.Radius = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParrentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParrentID";
            // 
            // ParrentID
            // 
            this.ParrentID.Location = new System.Drawing.Point(62, 0);
            this.ParrentID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ParrentID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ParrentID.Name = "ParrentID";
            this.ParrentID.Size = new System.Drawing.Size(120, 20);
            this.ParrentID.TabIndex = 1;
            this.ParrentID.ValueChanged += new System.EventHandler(this.ParrentID_ValueChanged);
            // 
            // Radius
            // 
            this.Radius.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Radius.Location = new System.Drawing.Point(62, 26);
            this.Radius.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Radius.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(120, 20);
            this.Radius.TabIndex = 3;
            this.Radius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radius";
            // 
            // BaseEntityInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParrentID);
            this.Controls.Add(this.label1);
            this.Name = "BaseEntityInspector";
            this.Size = new System.Drawing.Size(185, 54);
            ((System.ComponentModel.ISupportInitialize)(this.ParrentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ParrentID;
        private System.Windows.Forms.NumericUpDown Radius;
        private System.Windows.Forms.Label label2;
    }
}
