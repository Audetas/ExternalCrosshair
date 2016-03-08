using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExternalCrosshair
{
    static class Win32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, ref Rect lpRect);

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("User32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetProcessDPIAware();

        public static Size GetClientSize(IntPtr h)
        {
            Rect rect = new Rect();
            GetClientRect(h, ref rect);

            Size s = new Size();
            s.Width = rect.right - rect.left;
            s.Height = rect.bottom - rect.top;

            return s;
        }

        public static Point GetClientLocation(IntPtr h)
        {
            Point point = Point.Empty;
            ClientToScreen(h, ref point);

            return point;
        }
    }
}
