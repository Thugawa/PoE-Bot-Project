using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BotTrader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            var Bot_Engine = new Bot();
            Bot_Engine.Path();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());
            // launch the WinForms application like normal
        }
    }
}
