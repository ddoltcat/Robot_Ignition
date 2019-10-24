using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;



namespace Robot_Ignition
{
    public partial class Main : Form
    {
       #region 变量定义
        //----------------------------------------------------------------------------------------
          //定义接收数据的长度
          private static int DataCount = 1024;
        //定义数据接收缓冲区
          private static byte[] DataBuff = new byte[DataCount];
        //定义套接字
        private static Socket Tcp_Socket;
        //定义连接按钮状态,1连接,0断开
        private static int but_connect_Flag = 1;
        //----------------------------------------------------------------------------------------
        #endregion
        private delegate void InvokeDelegate(string msg);
       
        public Main()
        {
            InitializeComponent();
        }


        private void but_Connect_Click(object sender, EventArgs e)
        {
            if (but_connect_Flag == 1)
            {
                //连接到网络
                if (string.IsNullOrEmpty(txtRobotIP.Text) || string.IsNullOrEmpty(txtRobotPort.Text))
                {
                    UpInfoBox("请输入IP地址或端口号!");
                }
                else
                {
                    if (!Common.CheckIP(txtRobotIP.Text))
                    {
                        UpInfoBox("请输入正确格式IP地址!");
                    }
                    else
                    {
                        if (TcpConnect(txtRobotIP.Text.Trim(), txtRobotPort.Text.Trim()))
                        {
                            //网络连接成功后需要做的几件是:
                            //1.在信息显示中显示连接成功信息.
                            //2.更改连接按钮text为断开
                            //3.更改连接按钮Flag为0
                            this.but_Connect.Text = "断开";
                            but_connect_Flag = 0;
                            pic_ConnectFlag.Image = Properties.Resources.connect;
                           
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            else
            {
                
                if (TcpSafeClose(Tcp_Socket))
                {
                    UpInfoBox("连接与成功断开!");
                    pic_ConnectFlag.Image = Properties.Resources.unconnect;
                    this.but_Connect.Text = "连接";
                    but_connect_Flag = 1;
                }
                else
                {
                    UpInfoBox("网络连接 功断开失败!");
                }
                    

            }
  
           
        }
        #region 更新信息显示
        /// <summary>
        /// 更新信息显示
        /// </summary>
        /// <param name="msg"></param>
        public void UpInfoBox(string msg)
        {
            if (txt_Info.InvokeRequired)
            {
                InvokeDelegate objSet = new InvokeDelegate(UpInfoBox);
                txt_Info.Invoke(objSet, new object[] { msg });
            }
            else
            {
                this.txt_Info.AppendText(DateTime.Now.ToString() + " : " + msg + "\r\n");
            }
            
        }
        #endregion

        #region 网络操作

        /// <summary>
        /// TCP网络连接,
        /// </summary>
        /// <param name="IP_Address"></param>
        /// <param name="Port"></param>
        /// <returns></returns>

        private bool TcpConnect(string IP_Address, string Port)
        {
            //实例化新的socket
            Tcp_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //绑定IP和端口
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(IP_Address), Convert.ToInt32(Port));
            //连接到指定的IP和端口
            try
            {
                //连接到指定的IP
                Tcp_Socket.Connect(ipEndPoint);
                UpInfoBox("已成功与Robot(" + Tcp_Socket.RemoteEndPoint.ToString() + ")建立连接,等待Robot回传配置信息.....");
                //开启异步接收模式
                Tcp_Socket.BeginReceive(DataBuff, 0, DataCount, SocketFlags.None, ReceiveCB, null);
                return true;
            }
            catch (SocketException)
            {
                UpInfoBox("与Robot连接失败,请检查IP,端口,Robot状态...");
                return false;
                
            }
            

        }

        /// <summary>
        /// 接收异步回调函数 
        /// </summary>
        /// <param name="ar"></param>
        private void ReceiveCB(IAsyncResult ar)
        {
            //在回调函数中做以下几项工作
            //1.
            
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 安全关闭连接
        /// </summary>
        /// <param name="socket"></param>
        private bool TcpSafeClose(Socket socket)
        {
            if (socket == null)
                return true;
            if (!socket.Connected)
                return true;
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch (SocketException)
            {
                return false;
            }
            try
            {
                socket.Close();
            }
            catch (SocketException)
            {

                return false;
            }
            return true;
        }
        #endregion

    }
}
