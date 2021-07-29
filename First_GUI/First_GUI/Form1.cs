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
using System.Diagnostics;

namespace First_GUI
{
    public partial class stationMainForm : Form
    {
        delegate void CrossThreadSafetySetText(Control ctl, String text);
        public struct UdpState
        {
            public UdpClient u;
            public IPEndPoint e;
        }

        UdpState state = new UdpState();
        String data = "";

        private void safeSpeedText(Control ctl, String stringArr)
        {
            if(ctl.InvokeRequired)
            {
                ctl.Invoke(new CrossThreadSafetySetText(safeSpeedText), ctl, stringArr);
            } else
            {
                if (!string.IsNullOrEmpty(stringArr)) ctl.Text = stringArr.ToString();
                else ctl.Text = "";
            }
        }

        private void table1()
        {
            object sender = tableLayoutPanel1;
            var control = sender as Control;

            tableLayoutPanel1.SetColumnSpan(control, 2);
        }

        public stationMainForm()
        {
            table1();
            UdpClient listen = new UdpClient(8080); //포트 번호
            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);

            InitializeComponent();

            state.u = listen;
            state.e = RemoteIP;
            listen.BeginReceive(new AsyncCallback(recv), state);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
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

            check(data);
        }

        public void check(String hex)
        {
            Debug.WriteLine(hex);
            string[] stringArr = new string[100];
            int i = 0;
            foreach(char each in hex)
            {
                if (each.Equals(' ')) i++;;
                stringArr[i] += each;
            }

            if(stringArr[0] == "YES" || stringArr[0] == "yes" || stringArr[0] == "Yes")
            {
                label2.BackColor = Color.Red;
            } else if(stringArr[0] == "NO" || stringArr[0] == "no" || stringArr[0] == "No")
            {
                label2.BackColor = Color.White;
            }

            object send = speedLabel;
            safeSpeedText((Control)send, stringArr[1]);
        }
    }
}
