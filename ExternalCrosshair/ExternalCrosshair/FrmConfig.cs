﻿using Sights.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExternalCrosshair
{
    public partial class FrmConfig : Form
    {
        private Dictionary<string, CrosshairConfig> _configs;
        private FrmCrosshair _crosshair;
        private XmlSerializer _serializer;

        private IntPtr _lastWindow = IntPtr.Zero;

        public FrmConfig()
        {
            InitializeComponent();

            // Create crosshair form
            _crosshair = new FrmCrosshair();
            _crosshair.Show();

            // Load existing configurations
            _configs = new Dictionary<string, CrosshairConfig>();
            _serializer = new XmlSerializer(typeof(CrosshairConfig));

            try
            {
                foreach (string serialization in Settings.Default.SavedProfiles)
                {
                    // Replacement is done due to conflicts in the settings serialization mechanism
                    using (StringReader reader = new StringReader(serialization.Replace('|', '<').Replace('`', '>')))
                    {
                        CrosshairConfig config = (CrosshairConfig)_serializer.Deserialize(reader);
                        _configs.Add(config.TargetProcessName, config);
                        lstPrograms.Items.Add(config.TargetProcessName);
                    }
                }
            }
            catch
            {
                MessageBox.Show(
                    "Your settings seem to be corrupt and need to be reset. Press OK to continue.", 
                    "External Sights", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Settings.Default.Upgrade();
            }

            // AutoHide if already configured
            if (lstPrograms.Items.Count > 0)
            {
                var hid = true;
                Shown += (e, s) =>
                {
                    if (hid)
                    {
                        hid = false;
                        Hide();
                    }
                };
                icoTray.Visible = true;
                icoTray.ShowBalloonTip(2000, "External Sights", "Running with saved configs.", ToolTipIcon.None);
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            IntPtr foreground = Win32.GetForegroundWindow();

            // Foreground has changed so we should adjust the crosshair form
            if (foreground == _crosshair.Handle)
            {
                Win32.SetForegroundWindow(_lastWindow);
            }
            else if (foreground != _lastWindow)
            {
                _lastWindow = foreground;
                uint id;
                Win32.GetWindowThreadProcessId(foreground, out id);

                Process process = Process.GetProcessById((int)id);
                CrosshairConfig config;
                if (_configs.TryGetValue(process.ProcessName, out config))
                    _crosshair.SetConfig(config, process);
                else
                    _crosshair.Disable();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmChoose chooser = new FrmChoose();
            chooser.ShowDialog();

            if (chooser.ChosenProcess.Length == 0)
                return;

            CrosshairConfig config = new CrosshairConfig()
            {
                TargetProcessName = chooser.ChosenProcess,
                Color = Color.Red,
                OutlineColor = Color.Gray,
                CenterPoint = true,
                Thickness = 2,
                OutlineThickness = 1,
                Separation = 5,
                Size = 10,
                Rotation = 0,
                Opacity = 1
            };

            new FrmEdit(config).ShowDialog();

            if (_configs.ContainsKey(config.TargetProcessName))
                _configs.Add(config.TargetProcessName, config);
            else
                _configs[config.TargetProcessName] = config;

            if (!lstPrograms.Items.Contains(config.TargetProcessName))
                lstPrograms.Items.Add(config.TargetProcessName);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPrograms.SelectedItem != null)
            {
                _configs.Remove(lstPrograms.SelectedItem.ToString());
                lstPrograms.Items.Remove(lstPrograms.SelectedItem);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstPrograms.SelectedItem != null)
            {
                new FrmEdit(_configs[lstPrograms.SelectedItem.ToString()]).ShowDialog();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
            icoTray.Visible = true;
        }

        private void icoTray_Click(object sender, EventArgs e)
        {
            icoTray.Visible = false;
            Show();
        }

        private bool _exit = false;
        private void FrmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_exit;

            if (!_exit)
            {
                Hide();
                icoTray.Visible = true;
            }
            else
            {
                icoTray.Visible = false;

                // Save settings on exit
                using (StringWriter writer = new StringWriter())
                {
                    Settings.Default.SavedProfiles.Clear();
                    foreach (CrosshairConfig config in _configs.Values)
                    {
                        _serializer.Serialize(writer, config);
                        // Replacement is done due to conflicts in the settings serialization mechanism
                        Settings.Default.SavedProfiles.Add(writer.ToString().Replace('<', '|').Replace('>', '`'));
                    }
                    Settings.Default.Save();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to completely exit External Crosshair?", "External Crosshair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _exit = true;
                Close();
            }
        }

        private void FrmConfig_Shown(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}
