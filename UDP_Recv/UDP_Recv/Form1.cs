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

        String data = "";

        public Form1()
        {
            InitializeComponent();
            this.Doconnect();
        }

        public void Doconnect()
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            UdpState state = new UdpState();
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
                    byte[] sendByte = Encoding.ASCII.GetBytes("OK RECEIVED\n");
                    listen.Send(sendByte, sendByte.Length, RemoteIP);
                }
            }*/
        }

        void recv(IAsyncResult res)
        {
            UdpClient listen = ((UdpState)(res.AsyncState)).u;
            IPEndPoint RemoteIP = ((UdpState)(res.AsyncState)).e;
            byte[] received = listen.EndReceive(res, ref RemoteIP);
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
                richTextBox1.Text += DateTime.Now.ToString("yy년 MM월 dd일 hh:mm:ss\n");
                richTextBox1.Text += hexData;
            }));
        }
    }
}
