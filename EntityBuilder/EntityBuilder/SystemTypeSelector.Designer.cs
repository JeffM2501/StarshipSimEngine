namespace EntityBuilder
{
    partial class SystemTypeSelector
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SystemTypeList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(197, 48);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCEL.Location = new System.Drawing.Point(116, 48);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(75, 23);
            this.CANCEL.TabIndex = 1;
            this.CANCEL.Text = "Cancel";
            this.CANCEL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "System Type";
            // 
            // SystemTypeList
            // 
            this.SystemTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemTypeList.FormattingEnabled = true;
            this.SystemTypeList.Location = new System.Drawing.Point(77, 13);
            this.SystemTypeList.Name = "SystemTypeList";
            this.SystemTypeList.Size = new System.Drawing.Size(195, 21);
            this.SystemTypeList.TabIndex = 3;
            this.SystemTypeList.SelectedIndexChanged += new System.EventHandler(this.SystemTypeList_SelectedIndexChanged);
            // 
            // SystemTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.SystemTypeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemTypeSelector";
            this.Text = "Select System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SystemTypeList;
    }
}