using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace NewsMaking.DesktopApp.Misc
{
    public static class WindowSettings
    {

								// Import dwmapi.dll and define DwmSetWindowAttribute in C# corresponding to the native function.
								[DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
								private static extern void DwmSetWindowAttribute(IntPtr hwnd,
																																																									DWMWINDOWATTRIBUTE attribute,
																																																									ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
																																																									uint cbAttribute);

								private static bool _isWindows11OrGreater() => Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Build >= 22000; 

								public static void SetWindowCornerRound(Window window)
								{
												IntPtr hWnd = new WindowInteropHelper(window).EnsureHandle();
												var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
												var preference = _isWindows11OrGreater() ? DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND : DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_DONOTROUND;
												DwmSetWindowAttribute(hWnd, attribute, ref preference, sizeof(uint));
								}
				}
}
