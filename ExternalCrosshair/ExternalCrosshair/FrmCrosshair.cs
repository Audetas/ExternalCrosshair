using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ExternalCrosshair
{
	public partial class FrmCrosshair : Form
    {
        private CrosshairConfig _config = null;
        private Process _target = null;

        public FrmCrosshair()
        {
            InitializeComponent();
            Visible = false;
        }

        public void SetConfig(CrosshairConfig config, Process target)
        {
            _config = config;
            _target = target;
            Opacity = config.Opacity;

            Show();
            Invalidate();
            tmrRefresh.Start();
        }
        
        public void Disable()
        {
            Hide();
            _target = null;
            _config = null;
            tmrRefresh.Stop();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if (_target == null)
            {
                Disable();
            }
            else
            {
                Size newSize = Win32.GetClientSize(_target.MainWindowHandle);
                Point newLoc = Win32.GetClientLocation(_target.MainWindowHandle);

                if (Size != newSize)
                {
                    Size = newSize;
                    Invalidate();
                }
                if (Location != newLoc)
                {
                    Location = newLoc;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SetClip(ClientRectangle);
            e.Graphics.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
            e.Graphics.DrawLine(Pens.Black, 0, 8, 0, Height - 9);
            e.Graphics.DrawLine(Pens.Black, Width - 1, 8, Width - 1, Height - 9);
            e.Graphics.DrawLine(Pens.Black, 8, 0, Width - 9, 0);
            e.Graphics.DrawLine(Pens.Black, 8, Height - 1, Width - 9, Height - 1);
            _config?.DrawToSurface(e.Graphics);
        }
    }
}
