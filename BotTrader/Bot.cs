using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Click(object sender, EventArgs e)
        {

        }

        private void Check1_Click(object sender, EventArgs e)
        {

        }

        private void unCheck2_Click(object sender, EventArgs e)
        {

        }

        private void unCheck3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Bot
    {
        private static string PoE_Path;
        private static string PoE_Logs_Dir;
        private static string PoE_Logs_File;

        public Bot()
        {
            //Check if the Path of Exile isn't Steam
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
                //Check if the Path of Exile is Steam
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
                button1.Enabled = true;
            }
            else
            {
                Console.WriteLine("Path of Exile is Running");
            }
        }
        public void Start()
        {

        }
    }
}
