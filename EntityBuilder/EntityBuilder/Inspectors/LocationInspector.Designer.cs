﻿namespace EntityBuilder.Inspectors
{
    partial class LocationInspector
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
            this.LocationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShapeList = new System.Windows.Forms.ComboBox();
            this.Orientation = new EntityBuilder.Controls.QuaternionEditor();
            this.Origin = new EntityBuilder.Controls.Vector3Editor();
            this.GeoSize = new EntityBuilder.Controls.Vector3Editor();
            this.SuspendLayout();
            // 
            // LocationName
            // 
            this.LocationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationName.Location = new System.Drawing.Point(3, 3);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(154, 20);
            this.LocationName.TabIndex = 0;
            this.LocationName.TextChanged += new System.EventHandler(this.LocationName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shape";
            // 
            // ShapeList
            // 
            this.ShapeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeList.FormattingEnabled = true;
            this.ShapeList.Location = new System.Drawing.Point(7, 300);
            this.ShapeList.Name = "ShapeList";
            this.ShapeList.Size = new System.Drawing.Size(144, 21);
            this.ShapeList.TabIndex = 4;
            // 
            // Orientation
            // 
            this.Orientation.LabelText = "Orientation";
            this.Orientation.Location = new System.Drawing.Point(3, 126);
            this.Orientation.Name = "Orientation";
            this.Orientation.Size = new System.Drawing.Size(149, 151);
            this.Orientation.TabIndex = 2;
            this.Orientation.ValueChanged += new System.EventHandler(this.LocationGeoChanged);
            // 
            // Origin
            // 
            this.Origin.LabelText = "Origin";
            this.Origin.Location = new System.Drawing.Point(3, 29);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(148, 100);
            this.Origin.TabIndex = 1;
            this.Origin.ValueChanged += new System.EventHandler(this.LocationGeoChanged);
            // 
            // Size
            // 
            this.GeoSize.LabelText = "Size";
            this.GeoSize.Location = new System.Drawing.Point(7, 327);
            this.GeoSize.Name = "Size";
            this.GeoSize.Size = new System.Drawing.Size(148, 100);
            this.GeoSize.TabIndex = 5;
            this.GeoSize.ValueChanged += new System.EventHandler(this.LocationGeoChanged);
            // 
            // LocationInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeoSize);
            this.Controls.Add(this.ShapeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Orientation);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.LocationName);
            this.Name = "LocationInspector";
            this.Size = new System.Drawing.Size(160, 485);
            this.Load += new System.EventHandler(this.LocationInspector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LocationName;
        private Controls.Vector3Editor Origin;
        private Controls.QuaternionEditor Orientation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ShapeList;
        private Controls.Vector3Editor GeoSize;
    }
}
