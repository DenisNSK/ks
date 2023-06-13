using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Работа_с_коандной_стракой
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C " + "shutdown /r");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C " + "shutdown /s");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C " + "shutdown /s/t 3600");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C " + "shutdown /r/t 7200");
        }
    }
}
