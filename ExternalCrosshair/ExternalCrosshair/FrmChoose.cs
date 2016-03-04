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
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                    lstProcesses.Items.Add(p.ProcessName);
            }
        }

        private void lstProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProcesses.SelectedItem != null)
                btnChoose.Enabled = true;
        }

        private void lstProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstProcesses.SelectedItem != null)
            {
                ChosenProcess = lstProcesses.SelectedItem.ToString();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChosenProcess = lstProcesses.SelectedItem.ToString();
            Close();
        }
    }
}
