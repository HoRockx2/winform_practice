using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1.interop
{
    public class InteropUser32
    {
        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;
        public static int WM_HOTKEY = 0x312;
        public static int WM_QUERYENDSESSION = 0x0011;

        private const string USER_32_DLL = "user32.dll";

        [DllImport(USER_32_DLL)]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport(USER_32_DLL)]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport(USER_32_DLL)]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport(USER_32_DLL)]
        internal static extern IntPtr GetForegroundWindow();
    }
}
