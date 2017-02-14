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
using System.Management;

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
        //change window title
        private void monoFlat_TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = monoFlat_TextBox1.Text;
            monoFlat_ThemeContainer1.Text = monoFlat_TextBox1.Text;
        }
        //suspend process state
        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            string prcname = monoFlat_TextBox2.Text.ToString();
            Process prctarget = Process.GetProcessesByName(prcname)[0];
            ProcessExtension.Suspend(prctarget);
        }
        //resume process state
        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            string prcname = monoFlat_TextBox2.Text.ToString();
            Process prctarget = Process.GetProcessesByName(prcname)[0];
            ProcessExtension.Resume(prctarget);
        }
        //start process and suspend it in chosen ms
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
        //shows if process is running or not
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
        //shows if process is running or not
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<String> proclists = new List<string>();
            Process[] procclist = Process.GetProcesses();
            foreach (Process processlist in procclist)
            {
                proclists.Add(processlist.ProcessName);
                monoFlat_TextBox5.Text = String.Join(Environment.NewLine, proclists);
            }
        }

        private void monoFlat_SocialButton1_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_Button5_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_Label5_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_SocialButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            monoFlat_TextBox5.Text = String.Empty;
            List<String> proclists = new List<string>();
            Process[] procclist = Process.GetProcesses();
            foreach (Process processlist in procclist)
            {
                proclists.Add(processlist.ProcessName);
                monoFlat_TextBox5.Text = String.Join(Environment.NewLine, proclists);
            }
            this.Refresh();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            
            
        }


        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void monoFlat_TextBox3_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}

