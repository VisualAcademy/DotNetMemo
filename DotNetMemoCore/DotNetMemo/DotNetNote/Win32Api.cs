using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DotNetNote
{
    /// <summary>
    /// Windows의 API를 사용하기 위한 클래스.
    /// </summary>
    public class Win32Api
    {
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct MEMORYSTATUS
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public uint dwTotalPhys;
            public uint dwAvailPhys;
            public uint dwTotalPageFile;
            public uint dwAvailPageFile;
            public uint dwTotalVirtual;
            public uint dwAvailVirtual;
        }

        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS buf);

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern int ShellAbout(IntPtr hWnd, string szApp, string
            szOtherStuff, IntPtr hIcon);
    }
}