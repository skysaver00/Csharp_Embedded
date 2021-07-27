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

namespace UDP_Send
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            String T

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client.Connect(ep);

            String msg = richTextBox1.Text;

            byte[] data = Encoding.ASCII.GetBytes(msg);
            client.Send(data, data.Length);
            client.Close();
        }
    }
}
