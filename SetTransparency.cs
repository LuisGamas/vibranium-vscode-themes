using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace GlassIt
{
    public static class SetTransParency
    {
        public static bool SetTransparency(int pid, byte alpha)
        {
            Process mainproc = Process.GetProcessById(pid);
            foreach (Process proc in Process.GetProcessesByName(mainproc.ProcessName))
            {
                if (proc.StartInfo.FileName != mainproc.StartInfo.FileName)
                {
                    continue;
                }

                IntPtr hMainWnd = proc.MainWindowHandle;
                if (hMainWnd == IntPtr.Zero)
                {
                    continue;
                }

                uint tid = NativeMethods.GetWindowThreadProcessId(hMainWnd, out pid);
                bool result = NativeMethods.EnumThreadWindows(tid, delegate(IntPtr hWnd, IntPtr lParam) {
                    if (!NativeMethods.IsWindowVisible(hWnd))
                    {
                        return true;
                    }

                    WS windowLong = NativeMethods.GetWindowLong(hWnd, GWL.EXSTYLE);
                    NativeMethods.SetWindowLong(hWnd, GWL.EXSTYLE, windowLong | WS.EX_LAYERED);
                    return NativeMethods.SetLayeredWindowAttributes(hWnd, 0, alpha, LWA.ALPHA);
                }, IntPtr.Zero);

                if (!result)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

internal static class NativeMethods
{
    public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern bool EnumThreadWindows(uint dwThreadId, EnumWindowsProc lpEnumFunc, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

    [DllImport("user32.dll")]
    public static extern bool IsWindowVisible(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern WS GetWindowLong(IntPtr hWnd, GWL nIndex);

    [DllImport("user32.dll")]
    public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, WS dwNewLong);

    [DllImport("user32.dll")]
    public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, uint crKey, byte bAlpha, LWA dwFlags);
}

internal enum GWL : int
{
    EXSTYLE = -20,
}

[Flags]
internal enum WS : int
{
    EX_LAYERED = 0x80000,
}

internal enum LWA : int
{
    ALPHA = 2,
}
