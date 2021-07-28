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

namespace UDP_Recv
{
    
    public partial class Form1 : Form
    {

        UdpClient listen = new UdpClient(8080); //포트 번호
        IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);

        public struct UdpState
        {
            public UdpClient u;
            public IPEndPoint e;
        }

        UdpState state = new UdpState();

        String data = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "수신 중...";

            state.u = listen;
            state.e = RemoteIP;
            listen.BeginReceive(new AsyncCallback(recv), state);

            /*for (int i = 0; i < 1000; i++)
            {
                try
                {
                }
                catch (Exception ex)
                {
                    richTextBox1.Text += ex.Message.ToString();
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPEndPoint sendIP = new IPEndPoint(IPAddress.Parse("220.76.184.210"), 8080);
            String sendMsg = richTextBox2.Text;
            byte[] sendByte = Encoding.UTF8.GetBytes(sendMsg);

            listen.Send(sendByte, sendByte.Length, sendIP);
        }

        void recv(IAsyncResult res)
        {
            UdpClient listen = ((UdpState)(res.AsyncState)).u;
            IPEndPoint RemoteIP = ((UdpState)(res.AsyncState)).e;
            byte[] received = listen.EndReceive(res, ref RemoteIP);

            IPEndPoint sendIP = new IPEndPoint(IPAddress.Parse("220.76.184.210"), 8080);
            byte[] sendByte = Encoding.ASCII.GetBytes("OK RECEIVED\n");
            listen.Send(sendByte, sendByte.Length, sendIP);

            listen.BeginReceive(new AsyncCallback(recv), state);
            data = Encoding.ASCII.GetString(received);

            string hexData = "";
            foreach (char each in data)
            {
                int value = Convert.ToInt32(each);
                hexData += String.Format("{0:X}", value);
                hexData += " ";
            }
            hexData += "\n";


            this.Invoke(new MethodInvoker(delegate
            {
                richTextBox1.Text += DateTime.Now.ToString("yy년 MM월 dd일 HH:mm:ss\n");
                richTextBox1.Text += RemoteIP.ToString();
                richTextBox1.Text += " ";
                richTextBox1.Text += hexData;
            }));
        }
    }
}
