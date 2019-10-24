namespace Robot_Ignition
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRobotIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRobotPort = new System.Windows.Forms.TextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_reset = new System.Windows.Forms.Button();
            this.but_ignition = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_IgnitionTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_Delaytime = new System.Windows.Forms.NumericUpDown();
            this.rad_Mode3 = new System.Windows.Forms.RadioButton();
            this.rad_Mode2 = new System.Windows.Forms.RadioButton();
            this.rad_Mode1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.but_Connect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_ConnectFlag = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_IgnitionTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Delaytime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ConnectFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_ConnectFlag);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtRobotIP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRobotPort);
            this.panel2.Location = new System.Drawing.Point(14, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 37);
            this.panel2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "连接至Robot:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // txtRobotIP
            // 
            this.txtRobotIP.Location = new System.Drawing.Point(126, 10);
            this.txtRobotIP.Name = "txtRobotIP";
            this.txtRobotIP.Size = new System.Drawing.Size(150, 21);
            this.txtRobotIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // txtRobotPort
            // 
            this.txtRobotPort.Location = new System.Drawing.Point(344, 10);
            this.txtRobotPort.Name = "txtRobotPort";
            this.txtRobotPort.Size = new System.Drawing.Size(100, 21);
            this.txtRobotPort.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "清空显示内容";
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(580, 81);
            this.but_Save.Name = "but_Save";
            this.but_Save.Padding = new System.Windows.Forms.Padding(5);
            this.but_Save.Size = new System.Drawing.Size(100, 30);
            this.but_Save.TabIndex = 14;
            this.but_Save.Text = "保存至Robot";
            this.but_Save.UseVisualStyleBackColor = true;
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(580, 126);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(100, 30);
            this.but_reset.TabIndex = 16;
            this.but_reset.Text = "重启Robot";
            this.but_reset.UseVisualStyleBackColor = true;
            // 
            // but_ignition
            // 
            this.but_ignition.Enabled = false;
            this.but_ignition.Location = new System.Drawing.Point(580, 171);
            this.but_ignition.Name = "but_ignition";
            this.but_ignition.Size = new System.Drawing.Size(100, 30);
            this.but_ignition.TabIndex = 17;
            this.but_ignition.Text = "实时点火";
            this.but_ignition.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "点火时长";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "延时时长";
            // 
            // num_IgnitionTime
            // 
            this.num_IgnitionTime.Location = new System.Drawing.Point(6, 89);
            this.num_IgnitionTime.Name = "num_IgnitionTime";
            this.num_IgnitionTime.Size = new System.Drawing.Size(81, 21);
            this.num_IgnitionTime.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.num_IgnitionTime);
            this.groupBox2.Controls.Add(this.num_Delaytime);
            this.groupBox2.Location = new System.Drawing.Point(435, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 124);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "点火时间设定";
            // 
            // num_Delaytime
            // 
            this.num_Delaytime.Location = new System.Drawing.Point(6, 37);
            this.num_Delaytime.Name = "num_Delaytime";
            this.num_Delaytime.Size = new System.Drawing.Size(81, 21);
            this.num_Delaytime.TabIndex = 0;
            // 
            // rad_Mode3
            // 
            this.rad_Mode3.AutoSize = true;
            this.rad_Mode3.Location = new System.Drawing.Point(16, 88);
            this.rad_Mode3.Name = "rad_Mode3";
            this.rad_Mode3.Size = new System.Drawing.Size(71, 16);
            this.rad_Mode3.TabIndex = 10;
            this.rad_Mode3.TabStop = true;
            this.rad_Mode3.Text = "实时点火";
            this.rad_Mode3.UseVisualStyleBackColor = true;
            // 
            // rad_Mode2
            // 
            this.rad_Mode2.AutoSize = true;
            this.rad_Mode2.Location = new System.Drawing.Point(16, 58);
            this.rad_Mode2.Name = "rad_Mode2";
            this.rad_Mode2.Size = new System.Drawing.Size(71, 16);
            this.rad_Mode2.TabIndex = 1;
            this.rad_Mode2.TabStop = true;
            this.rad_Mode2.Text = "单次点火";
            this.rad_Mode2.UseVisualStyleBackColor = true;
            // 
            // rad_Mode1
            // 
            this.rad_Mode1.AutoSize = true;
            this.rad_Mode1.Location = new System.Drawing.Point(16, 28);
            this.rad_Mode1.Name = "rad_Mode1";
            this.rad_Mode1.Size = new System.Drawing.Size(71, 16);
            this.rad_Mode1.TabIndex = 0;
            this.rad_Mode1.TabStop = true;
            this.rad_Mode1.Text = "循环点火";
            this.rad_Mode1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "信息显示:(点击右键工作间可清除显示)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Mode3);
            this.groupBox1.Controls.Add(this.rad_Mode2);
            this.groupBox1.Controls.Add(this.rad_Mode1);
            this.groupBox1.Location = new System.Drawing.Point(301, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 124);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "点火方式设定";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(16, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 14);
            this.progressBar1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(27, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 86);
            this.label3.TabIndex = 7;
            this.label3.Text = "计时";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 126);
            this.panel1.TabIndex = 19;
            // 
            // txt_Info
            // 
            this.txt_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Info.ContextMenuStrip = this.contextMenuStrip1;
            this.txt_Info.Location = new System.Drawing.Point(12, 231);
            this.txt_Info.Multiline = true;
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Info.Size = new System.Drawing.Size(668, 169);
            this.txt_Info.TabIndex = 15;
            // 
            // but_Connect
            // 
            this.but_Connect.Location = new System.Drawing.Point(580, 28);
            this.but_Connect.Name = "but_Connect";
            this.but_Connect.Padding = new System.Windows.Forms.Padding(2);
            this.but_Connect.Size = new System.Drawing.Size(100, 30);
            this.but_Connect.TabIndex = 18;
            this.but_Connect.Text = "连接至Robot";
            this.but_Connect.UseVisualStyleBackColor = true;
            this.but_Connect.Click += new System.EventHandler(this.but_Connect_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "* 连接至Robot时请确保与名为\"Robot\"的WiFi连接.";
            // 
            // pic_ConnectFlag
            // 
            this.pic_ConnectFlag.Image = global::Robot_Ignition.Properties.Resources.unconnect;
            this.pic_ConnectFlag.Location = new System.Drawing.Point(485, 10);
            this.pic_ConnectFlag.Name = "pic_ConnectFlag";
            this.pic_ConnectFlag.Size = new System.Drawing.Size(23, 20);
            this.pic_ConnectFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ConnectFlag.TabIndex = 13;
            this.pic_ConnectFlag.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 412);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_ignition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Info);
            this.Controls.Add(this.but_Connect);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_IgnitionTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Delaytime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ConnectFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRobotIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRobotPort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Button but_ignition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_IgnitionTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_Delaytime;
        private System.Windows.Forms.RadioButton rad_Mode3;
        private System.Windows.Forms.RadioButton rad_Mode2;
        private System.Windows.Forms.RadioButton rad_Mode1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Info;
        private System.Windows.Forms.Button but_Connect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pic_ConnectFlag;
    }
}