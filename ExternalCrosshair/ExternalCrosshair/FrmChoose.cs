using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExternalCrosshair
{
	public partial class FrmChoose : Form
    {
        public string ChosenProcess = "";

        public FrmChoose()
        {
            InitializeComponent();

            lstProcesses.SmallImageList = new ImageList();
            int index = 0;
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    lstProcesses.SmallImageList.Images.Add(Win32.GetSmallWindowIcon(p.MainWindowHandle));
                    lstProcesses.Items.Add(p.ProcessName, index);
                    index++;
                }
            }
        }

        private void lstProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProcesses.FocusedItem != null)
                btnChoose.Enabled = true;
        }

        private void lstProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstProcesses.FocusedItem != null)
            {
                ChosenProcess = lstProcesses.FocusedItem.ToString();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChosenProcess = lstProcesses.FocusedItem.ToString();
            Close();
        }
    }
}
