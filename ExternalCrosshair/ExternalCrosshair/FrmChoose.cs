using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    var icon = Win32.GetSmallWindowIcon(p.MainWindowHandle);
                    if (icon != null)
                        lstProcesses.SmallImageList.Images.Add(icon);
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
                ChosenProcess = lstProcesses.FocusedItem.Text;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChosenProcess = lstProcesses.FocusedItem.Text;
            Close();
        }
    }
}