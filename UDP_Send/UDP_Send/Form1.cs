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
        UdpClient cli = new UdpClient();
        string msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg = richTextBox1.Text;
            byte[] data = Encoding.UTF8.GetString(msg);
        }
    }
}
