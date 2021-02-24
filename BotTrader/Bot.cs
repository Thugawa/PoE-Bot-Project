using System;
using System.Windows.Forms;
using Microsoft.Win32;
using PoETradeBot.Services;

namespace BotTrader
{

    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }


        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void StartBot_Click(object sender, EventArgs e)
        {
            unCheck3.Visible = false;
            Check3.Visible = true;
        }

        private void StopBot_Click(object sender, EventArgs e)
        {
            unCheck3.Visible = true;
            Check3.Visible = false;
        }

    }

    public class Bot
    {
        private static string PoE_Path;
        private static string PoE_Logs_Dir;
        private static string PoE_Logs_File;

        public void Path()
        {
            //Assume if the Path of Exile isn't Steam
            var path = Registry.GetValue(@"HKEY_CURRENT_USER\Software\GGG\Path of Exile", "InstallLocationn", null);
            if (path != null)
            {
                PoE_Path = path.ToString();
                PoE_Logs_Dir = PoE_Path + @"\logs";
                PoE_Logs_File = PoE_Logs_Dir + @"\Client.txt";
                Console.WriteLine(PoE_Logs_File);
            }
            else
            {
                //Assume if the Path of Exile is Steam
                path = (@"C:\Program Files (x86)\Steam\steamapps\common\Path of Exile");
                PoE_Path = path.ToString();
                PoE_Logs_Dir = PoE_Path + @"\logs";
                PoE_Logs_File = PoE_Logs_Dir + @"\Client.txt";
                Console.WriteLine(PoE_Logs_File);
            }
            //Check if the Path of Exile Is Running
            if (!Win32.IsPoERun())
            {
                Console.WriteLine("Path of Exile isnot Running");
                unCheck3.Visible = false;
            }
            else
            {
                Console.WriteLine("Path of Exile is Running");
            }
        }
    }
}
