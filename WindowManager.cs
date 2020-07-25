using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace StayOnTop
{
    class WindowManager
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowText",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows",
        ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        private delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        private static readonly IntPtr HWND_TOPMOST_STATE = new IntPtr(-1);
        private static readonly IntPtr HWND_NORMAL_STATE = new IntPtr(-2);
        private static readonly IntPtr HWND_BOTTOMMOST_STATE = new IntPtr(1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 SWP_NOACTIVATE = 0x0010;
        private const UInt32 FLAGS = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE;

        public static bool SetStayOnTop(IntPtr hWnd)
        {
            return SetWindowPos(hWnd, HWND_TOPMOST_STATE, 0, 0, 0, 0, FLAGS);
        }

        public static bool SetStayNormal(IntPtr hWnd)
        {
            return SetWindowPos(hWnd, HWND_NORMAL_STATE, 0, 0, 0, 0, FLAGS);
        }

        public static bool SetStayOnBottom(IntPtr hWnd)
        {
            return SetWindowPos(hWnd, HWND_BOTTOMMOST_STATE, 0, 0, 0, 0, FLAGS);
        }

        private static List<WindowInfo> windowInfos = new List<WindowInfo>();

        public static List<WindowInfo> GetOpenWindowsList()
        {
            windowInfos = new List<WindowInfo>();
            EnumDesktopWindows(IntPtr.Zero, FilterCallback, IntPtr.Zero);
            return windowInfos;
        }

        private static bool FilterCallback(IntPtr hWnd, int lParam)
        {
            StringBuilder titleBuilder = new StringBuilder(1024);
            int length = GetWindowText(hWnd, titleBuilder, titleBuilder.Capacity);
            string title = titleBuilder.ToString();

            // If the window is visible and has a title, save it.
            if (IsWindowVisible(hWnd) && !string.IsNullOrEmpty(title))
            {
                windowInfos.Add(new WindowInfo(title, hWnd));
            }

            // Return true to indicate that we should continue enumerating windows.
            return true;
        }
    }
}
