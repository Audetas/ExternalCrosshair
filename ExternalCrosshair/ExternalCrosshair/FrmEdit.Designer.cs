namespace ExternalCrosshair
{
    partial class FrmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
            this.pnlConfig = new System.Windows.Forms.GroupBox();
            this.chkCenter = new System.Windows.Forms.CheckBox();
            this.lblUnitsOpacity = new System.Windows.Forms.Label();
            this.lblUnitsRotation = new System.Windows.Forms.Label();
            this.lblUnitsSeperation = new System.Windows.Forms.Label();
            this.lblUnitsSize = new System.Windows.Forms.Label();
            this.lblUnitsOutlineThickness = new System.Windows.Forms.Label();
            this.lblUnitsCrosshairThickness = new System.Windows.Forms.Label();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.numRotation = new System.Windows.Forms.NumericUpDown();
            this.numSeperation = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numOutlineThickness = new System.Windows.Forms.NumericUpDown();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.btnOutlineColor = new System.Windows.Forms.Panel();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblRotation = new System.Windows.Forms.Label();
            this.lblSeperation = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOutlineThickness = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblOutlineColor = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnCrosshairColor = new System.Windows.Forms.Panel();
            this.pnlPreview = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCustom = new System.Windows.Forms.GroupBox();
            this.pbxCustom = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutlineThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            this.grpCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.chkCenter);
            this.pnlConfig.Controls.Add(this.lblUnitsOpacity);
            this.pnlConfig.Controls.Add(this.lblUnitsRotation);
            this.pnlConfig.Controls.Add(this.lblUnitsSeperation);
            this.pnlConfig.Controls.Add(this.lblUnitsSize);
            this.pnlConfig.Controls.Add(this.lblUnitsOutlineThickness);
            this.pnlConfig.Controls.Add(this.lblUnitsCrosshairThickness);
            this.pnlConfig.Controls.Add(this.numOpacity);
            this.pnlConfig.Controls.Add(this.numRotation);
            this.pnlConfig.Controls.Add(this.numSeperation);
            this.pnlConfig.Controls.Add(this.numSize);
            this.pnlConfig.Controls.Add(this.numOutlineThickness);
            this.pnlConfig.Controls.Add(this.numThickness);
            this.pnlConfig.Controls.Add(this.btnOutlineColor);
            this.pnlConfig.Controls.Add(this.lblOpacity);
            this.pnlConfig.Controls.Add(this.lblRotation);
            this.pnlConfig.Controls.Add(this.lblSeperation);
            this.pnlConfig.Controls.Add(this.lblSize);
            this.pnlConfig.Controls.Add(this.lblOutlineThickness);
            this.pnlConfig.Controls.Add(this.lblThickness);
            this.pnlConfig.Controls.Add(this.lblOutlineColor);
            this.pnlConfig.Controls.Add(this.lblColor);
            this.pnlConfig.Controls.Add(this.btnCrosshairColor);
            this.pnlConfig.Location = new System.Drawing.Point(12, 12);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(268, 249);
            this.pnlConfig.TabIndex = 0;
            this.pnlConfig.TabStop = false;
            this.pnlConfig.Text = "Configure settings for: rust.exe";
            // 
            // chkCenter
            // 
            this.chkCenter.AutoSize = true;
            this.chkCenter.Location = new System.Drawing.Point(9, 225);
            this.chkCenter.Name = "chkCenter";
            this.chkCenter.Size = new System.Drawing.Size(83, 17);
            this.chkCenter.TabIndex = 22;
            this.chkCenter.Text = "Center point";
            this.chkCenter.UseVisualStyleBackColor = true;
            this.chkCenter.CheckedChanged += new System.EventHandler(this.Option_Click);
            // 
            // lblUnitsOpacity
            // 
            this.lblUnitsOpacity.AutoSize = true;
            this.lblUnitsOpacity.Location = new System.Drawing.Point(200, 201);
            this.lblUnitsOpacity.Name = "lblUnitsOpacity";
            this.lblUnitsOpacity.Size = new System.Drawing.Size(67, 13);
            this.lblUnitsOpacity.TabIndex = 21;
            this.lblUnitsOpacity.Text = "(percentage)";
            // 
            // lblUnitsRotation
            // 
            this.lblUnitsRotation.AutoSize = true;
            this.lblUnitsRotation.Location = new System.Drawing.Point(200, 175);
            this.lblUnitsRotation.Name = "lblUnitsRotation";
            this.lblUnitsRotation.Size = new System.Drawing.Size(51, 13);
            this.lblUnitsRotation.TabIndex = 20;
            this.lblUnitsRotation.Text = "(degrees)";
            // 
            // lblUnitsSeperation
            // 
            this.lblUnitsSeperation.AutoSize = true;
            this.lblUnitsSeperation.Location = new System.Drawing.Point(200, 149);
            this.lblUnitsSeperation.Name = "lblUnitsSeperation";
            this.lblUnitsSeperation.Size = new System.Drawing.Size(39, 13);
            this.lblUnitsSeperation.TabIndex = 19;
            this.lblUnitsSeperation.Text = "(pixels)";
            // 
            // lblUnitsSize
            // 
            this.lblUnitsSize.AutoSize = true;
            this.lblUnitsSize.Location = new System.Drawing.Point(200, 123);
            this.lblUnitsSize.Name = "lblUnitsSize";
            this.lblUnitsSize.Size = new System.Drawing.Size(39, 13);
            this.lblUnitsSize.TabIndex = 18;
            this.lblUnitsSize.Text = "(pixels)";
            // 
            // lblUnitsOutlineThickness
            // 
            this.lblUnitsOutlineThickness.AutoSize = true;
            this.lblUnitsOutlineThickness.Location = new System.Drawing.Point(200, 97);
            this.lblUnitsOutlineThickness.Name = "lblUnitsOutlineThickness";
            this.lblUnitsOutlineThickness.Size = new System.Drawing.Size(39, 13);
            this.lblUnitsOutlineThickness.TabIndex = 17;
            this.lblUnitsOutlineThickness.Text = "(pixels)";
            // 
            // lblUnitsCrosshairThickness
            // 
            this.lblUnitsCrosshairThickness.AutoSize = true;
            this.lblUnitsCrosshairThickness.Location = new System.Drawing.Point(200, 71);
            this.lblUnitsCrosshairThickness.Name = "lblUnitsCrosshairThickness";
            this.lblUnitsCrosshairThickness.Size = new System.Drawing.Size(39, 13);
            this.lblUnitsCrosshairThickness.TabIndex = 16;
            this.lblUnitsCrosshairThickness.Text = "(pixels)";
            // 
            // numOpacity
            // 
            this.numOpacity.DecimalPlaces = 2;
            this.numOpacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpacity.Location = new System.Drawing.Point(113, 199);
            this.numOpacity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(81, 20);
            this.numOpacity.TabIndex = 15;
            this.numOpacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOpacity.Click += new System.EventHandler(this.Option_Click);
            // 
            // numRotation
            // 
            this.numRotation.Increment = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numRotation.Location = new System.Drawing.Point(113, 173);
            this.numRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numRotation.Name = "numRotation";
            this.numRotation.Size = new System.Drawing.Size(81, 20);
            this.numRotation.TabIndex = 14;
            this.numRotation.Click += new System.EventHandler(this.Option_Click);
            // 
            // numSeperation
            // 
            this.numSeperation.Location = new System.Drawing.Point(113, 147);
            this.numSeperation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSeperation.Name = "numSeperation";
            this.numSeperation.Size = new System.Drawing.Size(81, 20);
            this.numSeperation.TabIndex = 13;
            this.numSeperation.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSeperation.Click += new System.EventHandler(this.Option_Click);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(113, 121);
            this.numSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(81, 20);
            this.numSize.TabIndex = 12;
            this.numSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSize.Click += new System.EventHandler(this.Option_Click);
            // 
            // numOutlineThickness
            // 
            this.numOutlineThickness.Location = new System.Drawing.Point(113, 95);
            this.numOutlineThickness.Name = "numOutlineThickness";
            this.numOutlineThickness.Size = new System.Drawing.Size(81, 20);
            this.numOutlineThickness.TabIndex = 11;
            this.numOutlineThickness.Click += new System.EventHandler(this.Option_Click);
            // 
            // numThickness
            // 
            this.numThickness.Location = new System.Drawing.Point(113, 69);
            this.numThickness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(81, 20);
            this.numThickness.TabIndex = 10;
            this.numThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThickness.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnOutlineColor
            // 
            this.btnOutlineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOutlineColor.Location = new System.Drawing.Point(113, 42);
            this.btnOutlineColor.Name = "btnOutlineColor";
            this.btnOutlineColor.Size = new System.Drawing.Size(149, 13);
            this.btnOutlineColor.TabIndex = 9;
            this.btnOutlineColor.BackColorChanged += new System.EventHandler(this.Option_Click);
            this.btnOutlineColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(6, 201);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(46, 13);
            this.lblOpacity.TabIndex = 8;
            this.lblOpacity.Text = "Opacity:";
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(6, 175);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(50, 13);
            this.lblRotation.TabIndex = 7;
            this.lblRotation.Text = "Rotation:";
            // 
            // lblSeperation
            // 
            this.lblSeperation.AutoSize = true;
            this.lblSeperation.Location = new System.Drawing.Point(6, 149);
            this.lblSeperation.Name = "lblSeperation";
            this.lblSeperation.Size = new System.Drawing.Size(86, 13);
            this.lblSeperation.TabIndex = 6;
            this.lblSeperation.Text = "Inner-seperation:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(6, 123);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(74, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Crosshair size:";
            // 
            // lblOutlineThickness
            // 
            this.lblOutlineThickness.AutoSize = true;
            this.lblOutlineThickness.Location = new System.Drawing.Point(6, 97);
            this.lblOutlineThickness.Name = "lblOutlineThickness";
            this.lblOutlineThickness.Size = new System.Drawing.Size(91, 13);
            this.lblOutlineThickness.TabIndex = 4;
            this.lblOutlineThickness.Text = "Outline thickness:";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(6, 71);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(101, 13);
            this.lblThickness.TabIndex = 3;
            this.lblThickness.Text = "Crosshair thickness:";
            // 
            // lblOutlineColor
            // 
            this.lblOutlineColor.AutoSize = true;
            this.lblOutlineColor.Location = new System.Drawing.Point(6, 42);
            this.lblOutlineColor.Name = "lblOutlineColor";
            this.lblOutlineColor.Size = new System.Drawing.Size(69, 13);
            this.lblOutlineColor.TabIndex = 2;
            this.lblOutlineColor.Text = "Outline color:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 23);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(79, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Crosshair color:";
            // 
            // btnCrosshairColor
            // 
            this.btnCrosshairColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCrosshairColor.Location = new System.Drawing.Point(113, 23);
            this.btnCrosshairColor.Name = "btnCrosshairColor";
            this.btnCrosshairColor.Size = new System.Drawing.Size(149, 13);
            this.btnCrosshairColor.TabIndex = 0;
            this.btnCrosshairColor.BackColorChanged += new System.EventHandler(this.Option_Click);
            this.btnCrosshairColor.Click += new System.EventHandler(this.Color_Click);
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPreview.BackgroundImage")));
            this.pnlPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPreview.Location = new System.Drawing.Point(12, 345);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(268, 142);
            this.pnlPreview.TabIndex = 1;
            this.pnlPreview.TabStop = false;
            this.pnlPreview.Text = "Preview";
            this.pnlPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPreview_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(268, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCustom
            // 
            this.grpCustom.Controls.Add(this.btnClear);
            this.grpCustom.Controls.Add(this.btnBrowse);
            this.grpCustom.Controls.Add(this.pbxCustom);
            this.grpCustom.Location = new System.Drawing.Point(12, 267);
            this.grpCustom.Name = "grpCustom";
            this.grpCustom.Size = new System.Drawing.Size(268, 72);
            this.grpCustom.TabIndex = 3;
            this.grpCustom.TabStop = false;
            this.grpCustom.Text = "Use a custom image";
            // 
            // pbxCustom
            // 
            this.pbxCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCustom.Location = new System.Drawing.Point(216, 19);
            this.pbxCustom.Name = "pbxCustom";
            this.pbxCustom.Size = new System.Drawing.Size(44, 44);
            this.pbxCustom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCustom.TabIndex = 0;
            this.pbxCustom.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(201, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear custom image";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 527);
            this.Controls.Add(this.grpCustom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.pnlConfig);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Crosshair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEdit_FormClosing);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutlineThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            this.grpCustom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlConfig;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Panel btnCrosshairColor;
        private System.Windows.Forms.Label lblOutlineColor;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblOutlineThickness;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSeperation;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.Panel btnOutlineColor;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.NumericUpDown numRotation;
        private System.Windows.Forms.NumericUpDown numSeperation;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numOutlineThickness;
        private System.Windows.Forms.Label lblUnitsCrosshairThickness;
        private System.Windows.Forms.Label lblUnitsOpacity;
        private System.Windows.Forms.Label lblUnitsRotation;
        private System.Windows.Forms.Label lblUnitsSeperation;
        private System.Windows.Forms.Label lblUnitsSize;
        private System.Windows.Forms.Label lblUnitsOutlineThickness;
        private System.Windows.Forms.GroupBox pnlPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkCenter;
        private System.Windows.Forms.GroupBox grpCustom;
        private System.Windows.Forms.PictureBox pbxCustom;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClear;
    }
}