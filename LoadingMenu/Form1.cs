using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingMenu
{
    public partial class Form1 : Form
    {
        public string srcPath { get; set; }
        public string destPath { get; set; }

        public int plength { get; set; }


        Thread thread1 { get; set; }

        FileStream fsWrite { get; set; }

        FileStream fsRead { get; set; }

        public Form1()
        {
            InitializeComponent();
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frombox_TextChanged(object sender, EventArgs e)
        {

            srcPath = frombox.Text;

        }

        private void tobox_TextChanged(object sender, EventArgs e)
        {

            destPath = tobox.Text;
        }


        private void suspendbtn_Click(object sender, EventArgs e)
        {
            copybtn.Enabled = false;
            abortbtn.Enabled = false;
            if (thread1.IsAlive)
                thread1.Suspend();
            else
                MessageBox.Show("False Command");

        }

        private void resumebtn_Click(object sender, EventArgs e)
        {
            copybtn.Enabled = false;
            abortbtn.Enabled = true;
            if (thread1.IsAlive)
                thread1.Resume();
            else
                MessageBox.Show("False Command");

        }

        private void abortbtn_Click(object sender, EventArgs e)
        {
            copybtn.Enabled = true;
            if (thread1 != null && thread1.IsAlive )
            {
                thread1.Abort();
                progressBar1.Value = 0;
                frombox.Text = string.Empty;
                tobox.Text = string.Empty;
            }
            else
                MessageBox.Show("False Command");
            


        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            abortbtn.Enabled = true;
            thread1 = new Thread(() =>
            {
                if (!File.Exists(srcPath))
                {
                    Console.WriteLine("File not exists");
                    return;
                }

                using (fsRead = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
                {

                    plength = (int)fsRead.Length;
                    progressBar1.Maximum = 100;
                    using (fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
                    {
                        var len = 1 * plength / 100;
                        var fileSize = fsRead.Length;
                        byte[] buffer = new byte[len];

                        int bytesRead;
                        while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fsWrite.Write(buffer, 0, bytesRead);

                            progressBar1.Value += 1;
                            fileSize -= bytesRead;
                            Thread.Sleep(200);
                        }
                    }
                }
            });
            thread1.IsBackground = true;
            thread1.Start();
        }


    }
}
