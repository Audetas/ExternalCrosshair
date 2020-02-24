using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalCrosshair
{
    public partial class FrmEdit : Form
    {
        private CrosshairConfig _config;
        private bool initialized = false;

        public FrmEdit(CrosshairConfig config)
        {
            InitializeComponent();
            _config = config;

            pnlConfig.Text = "Configure crosshair for: " + _config.TargetProcessName;
            btnCrosshairColor.BackColor = _config.Color;
            btnOutlineColor.BackColor = _config.OutlineColor;
            numThickness.Value = _config.Thickness;
            numOutlineThickness.Value = _config.OutlineThickness;
            numSeperation.Value = _config.Separation;
            numSize.Value = _config.Size;
            numRotation.Value = _config.Rotation;
            numOpacity.Value = (decimal)_config.Opacity;
            chkCenter.Checked = _config.CenterPoint;
            initialized = true;
        }

        private void FrmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplyChanges();
        }

        private void Option_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            pnlPreview.Refresh();
        }

        private void ApplyChanges()
        {
            if (!initialized) return;
            _config.Color = btnCrosshairColor.BackColor;
            _config.OutlineColor = btnOutlineColor.BackColor;
            _config.Thickness = (int)numThickness.Value;
            _config.OutlineThickness = (int)numOutlineThickness.Value;
            _config.Separation = (int)numSeperation.Value;
            _config.Size = (int)numSize.Value;
            _config.Rotation = (int)numRotation.Value;
            _config.Opacity = (double)numOpacity.Value;
            _config.CenterPoint = chkCenter.Checked;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                (sender as Control).BackColor = cd.Color;
        }

        private void pnlPreview_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetClip((sender as Control).DisplayRectangle);
            _config.DrawToSurface(e.Graphics);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbxCustom.Image = null;
            pnlConfig.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.png, *.ico) | *.jpg; *.jpeg; *.png; *.ico";

            if (open.ShowDialog() == DialogResult.OK)
            {
                _config.CrosshairImage = (Bitmap)Image.FromFile(open.FileName);
                pbxCustom.Image = _config.CrosshairImage;
                pnlPreview.Refresh();
                pnlConfig.Enabled = false;
            }
        }
    }
}
