using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PoETradeBot.Services
{
    public class Win32
    {
        private static Process PoE_Process = null;

        public static bool IsPoERun()
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process theProcess in processList)
            {
                string processName = theProcess.ProcessName;

                if (processName.ToLower().Contains("pathofexile"))
                {
                    PoE_Process = theProcess;

                    break;
                }
            }

            if (PoE_Process == null)
                return false;
            else
                return true;
        }
    }
}