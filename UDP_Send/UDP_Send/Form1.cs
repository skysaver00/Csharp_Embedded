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

        private string makeAddress()
        {
            string val = "";
            val += textBox1.Text;

            bool isNumber = int.TryParse(textBox1.Text, out int n);
            if (!isNumber) return "-";
            if (Int32.Parse(textBox1.Text) < 0 || Int32.Parse(textBox1.Text) > 256) return "-";

            val += ".";
            val += textBox2.Text;

            isNumber = int.TryParse(textBox2.Text, out n);
            if (!isNumber) return "-";
            if (Int32.Parse(textBox2.Text) < 0 || Int32.Parse(textBox2.Text) > 256) return "-";

            val += ".";
            val += textBox3.Text;


            isNumber = int.TryParse(textBox3.Text, out n);
            if (!isNumber) return "-";
            if (Int32.Parse(textBox3.Text) < 0 || Int32.Parse(textBox3.Text) > 256) return "-";

            val += ".";
            val += textBox4.Text;

            isNumber = int.TryParse(textBox4.Text, out n);
            if (!isNumber) return "-";
            if (Int32.Parse(textBox4.Text) < 0 || Int32.Parse(textBox4.Text) > 256) return "-";

            return val;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            string add = makeAddress();
            if(add == "-")
            {
                label5.Text = "IP 주소가 잘못되었습니다.";
                return;
            }
            label5.Text = add.ToString();

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(add), 8080);
            client.Connect(ep);

            String msg = richTextBox1.Text;

            byte[] data = Encoding.ASCII.GetBytes(msg);
            client.Send(data, data.Length);

            client.Close();
        }
    }
}
