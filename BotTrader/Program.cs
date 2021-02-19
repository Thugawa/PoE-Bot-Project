using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var Bot_Engine = new Bot();
            Bot_Engine.Start();
            // launch the WinForms application like normal
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());

        }
    }
}
