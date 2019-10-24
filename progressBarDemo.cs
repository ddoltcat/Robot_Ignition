using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_Ignition
{
    public partial class progressBarDemo : Form
    {
        public progressBarDemo()
        {
            InitializeComponent();
        }

        private void progressBarDemo_Load(object sender, EventArgs e)
        {
            button2.Enabled  =   false;
            button3.Enabled   = false;
            button4.Enabled = false;
        }

        public void LogOut(string str)
        {
            textBox2.AppendText(DateTime.Now.ToString() + str + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "")
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = Convert.ToInt32(textBox1.Text);
                    progressBar1.Step = -1;
                    progressBar1.Value = progressBar1.Maximum;

                    button1.Enabled = false;
                    button2.Enabled = true;
                    LogOut("时间正确设置,请按开始键继续...");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确秒数(数值为正整数)");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Minimum)
            {
                progressBar1.PerformStep();
                LogOut("进度条正在工作,已完成" + ((1 - Convert.ToDouble(progressBar1.Value) / Convert.ToDouble(progressBar1.Maximum)) * 100).ToString() + "%");
            }
            else
            {
                LogOut("进度已完成");
                timer1.Stop();
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                LogOut("进度已被暂停");
                button3.Text = "继续";
                timer1.Stop();
            }
            else
            {
                LogOut("进度继续工作");
                button3.Text = "暂停";
                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogOut("进度条停止工作\n");
            textBox2.AppendText("========================================\n");
            timer1.Enabled = false;
            progressBar1.Value = 0;
            button1.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }

    }
}
