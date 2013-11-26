namespace EntityBuilder.Controls
{
    partial class QuaternionEditor
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
            this.VectorEdit = new EntityBuilder.Controls.Vector3Editor();
            this.RotationValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PresetList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RotationValue)).BeginInit();
            this.SuspendLayout();
            // 
            // VectorEdit
            // 
            this.VectorEdit.LabelText = "Vector3Editor";
            this.VectorEdit.Location = new System.Drawing.Point(0, 2);
            this.VectorEdit.Name = "VectorEdit";
            this.VectorEdit.Size = new System.Drawing.Size(148, 100);
            this.VectorEdit.TabIndex = 0;
            this.VectorEdit.Load += new System.EventHandler(this.VectorEdit_Load);
            // 
            // RotationValue
            // 
            this.RotationValue.DecimalPlaces = 4;
            this.RotationValue.Location = new System.Drawing.Point(56, 100);
            this.RotationValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.RotationValue.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.RotationValue.Name = "RotationValue";
            this.RotationValue.Size = new System.Drawing.Size(88, 20);
            this.RotationValue.TabIndex = 3;
            this.RotationValue.ValueChanged += new System.EventHandler(this.RotationValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rotation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Presets";
            // 
            // PresetList
            // 
            this.PresetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PresetList.FormattingEnabled = true;
            this.PresetList.Items.AddRange(new object[] {
            "Custom",
            "Positive X",
            "Positive Y",
            "Positive Z",
            "Negative X",
            "Negative Y",
            "Negative Z"});
            this.PresetList.Location = new System.Drawing.Point(45, 125);
            this.PresetList.Name = "PresetList";
            this.PresetList.Size = new System.Drawing.Size(99, 21);
            this.PresetList.TabIndex = 5;
            this.PresetList.SelectedIndexChanged += new System.EventHandler(this.PresetList_SelectedIndexChanged);
            // 
            // QuaternionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PresetList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RotationValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VectorEdit);
            this.Name = "QuaternionEditor";
            this.Size = new System.Drawing.Size(149, 151);
            ((System.ComponentModel.ISupportInitialize)(this.RotationValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vector3Editor VectorEdit;
        private System.Windows.Forms.NumericUpDown RotationValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PresetList;
    }
}
