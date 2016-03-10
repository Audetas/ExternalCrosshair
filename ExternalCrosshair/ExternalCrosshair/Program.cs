﻿using System;
using System.Windows.Forms;

namespace ExternalCrosshair
{
	static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Win32.SetProcessDPIAware();
            Application.Run(new FrmConfig());
        }
    }
}
