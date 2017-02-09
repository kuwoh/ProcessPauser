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
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace processpauser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void monoFlat_TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = monoFlat_TextBox1.Text;
            monoFlat_ThemeContainer1.Text = monoFlat_TextBox1.Text;
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            string prcname = monoFlat_TextBox2.Text.ToString();
            Process prctarget = Process.GetProcessesByName(prcname)[0];
            ProcessExtension.Suspend(prctarget);
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            string prcname = monoFlat_TextBox2.Text.ToString();
            Process prctarget = Process.GetProcessesByName(prcname)[0];
            ProcessExtension.Resume(prctarget);
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            string path = monoFlat_TextBox3.Text.ToString();
            Process.Start(path);
            //delay of process execution
            string delay = monoFlat_TextBox4.Text.ToString();
            int x = Int32.Parse(delay);
            Thread.Sleep(x);
            string proc = monoFlat_TextBox2.Text.ToString();
            Process prc = Process.GetProcessesByName(proc)[0];
            ProcessExtension.Suspend(prc);
        }

        private void monoFlat_Button4_Click(object sender, EventArgs e)
        {
            string procname = monoFlat_TextBox2.Text.ToString();
            foreach (var process in Process.GetProcessesByName(procname))
            {
                process.Kill();
            }
        }

        private void monoFlat_Panel1_MouseHover(object sender, EventArgs e)
        {
            this.Refresh();
            Thread.Sleep(1);
            string procstring = monoFlat_TextBox2.Text.ToString();
            Process[] getproc = Process.GetProcessesByName(procstring);
            if
                (getproc.Length == 0)
                monoFlat_HeaderLabel2.Text = monoFlat_TextBox2.Text + " Process Is Not Running";
            else
                monoFlat_HeaderLabel2.Text = monoFlat_TextBox2.Text + " Process Is Running";
            this.Refresh();
        }

        private void monoFlat_ThemeContainer1_MouseHover(object sender, EventArgs e)
        {
            this.Refresh();
            Thread.Sleep(1);
            string procstring = monoFlat_TextBox2.Text.ToString();
            Process[] getproc = Process.GetProcessesByName(procstring);
            if
                (getproc.Length == 0)
                monoFlat_HeaderLabel2.Text = monoFlat_TextBox2.Text + " Process Is Not Running";
            else
                monoFlat_HeaderLabel2.Text = monoFlat_TextBox2.Text + " Process Is Running";
            this.Refresh();
        }
    }
}
