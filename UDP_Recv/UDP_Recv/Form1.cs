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

namespace UDP_Recv
{
    public partial class Form1 : Form
    {
        UdpClient listen = new UdpClient(8080); //포트 번호

        IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);
        String data = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    listen.BeginReceive(new AsyncCallback(recv), null);
                }
                catch (Exception ex)
                {
                    richTextBox1.Text += ex.Message.ToString();
                    byte[] sendByte = Encoding.ASCII.GetBytes("OK RECEIVED\n");
                    listen.Send(sendByte, sendByte.Length, RemoteIP);
                }
            }
        }

        void recv(IAsyncResult res)
        {
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
