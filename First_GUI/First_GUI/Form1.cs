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
using System.Drawing.Drawing2D;

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

        private async void Blink(bool ck)
        {
            while(true)
            {
                if (!ck) break;
                await Task.Delay(300);
                twoTLabelFirst.BackColor = twoTLabelFirst.BackColor == Color.Red ? Color.White : Color.Red;
            }

            return;
        }

        void Arrow(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 5); //Pen 객체 생성
            pen.StartCap = LineCap.ArrowAnchor; //Line의 시작점 모양 변경
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 180, 400, 380, 400); //Line 그리기

            Pen pen2 = new Pen(Color.White, 5);
            pen2.StartCap = LineCap.RoundAnchor;
            pen2.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen2, 1540, 400, 1740, 400);
        }

        public stationMainForm()
        {
            this.Paint += new PaintEventHandler(Arrow);
            UdpClient listen = new UdpClient(8080); //포트 번호
            IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);

            InitializeComponent();

            timeLabel.Text = DateTime.Now.ToString("yyyy년 MMMM dd일, dddd");

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

            IPEndPoint sendIP = new IPEndPoint(IPAddress.Parse("192.168.0.99"), 3644);
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

        int p = 0;
        public void check(String hex)
        {
            Debug.WriteLine(hex);
            string[] stringArr = new string[100];
            int i = 0;
            foreach(char each in hex)
            {
                if (each.Equals('A')) i++;;
                stringArr[i] += each;
            }

            if (p == 6) p = 0;
            else p++;

            if (p == 0) 
            {
                YT_Label.BackColor = Color.Red;
            } else if(p == 1)
            {
                YT_Label.BackColor = Color.White;
                B227AT_Label.BackColor = Color.Red;
            } else if(p == 2)
            { 
                B227AT_Label.BackColor = Color.White;
                twoTLabelFirst.BackColor = Color.Red;
            }
                else if(p == 3)
            {
                twoTLabelFirst.BackColor = Color.White;
                twoTLabelSecond.BackColor = Color.Red;
            } else if(p == 4)
            {
                twoTLabelSecond.BackColor = Color.White;
                B226BT_Label.BackColor = Color.Red;
            } else if(p == 5)
            {
                B226BT_Label.BackColor = Color.White;
                XT_Label.BackColor = Color.Red;
            } else
            {
                XT_Label.BackColor = Color.White;
            }

            if(stringArr[0] == "YES" || stringArr[0] == "yes" || stringArr[0] == "Yes")
            {
                twoTLabelFirst.BackColor = Color.Red;
                twoTLabelSecond.BackColor = Color.Red;
            } else if(stringArr[0] == "NO" || stringArr[0] == "no" || stringArr[0] == "No")
            {
                twoTLabelFirst.BackColor = Color.White;
                twoTLabelSecond.BackColor = Color.White;
            } else if(stringArr[0] == "HALT" || stringArr[0] == "halt" || stringArr[0] == "Halt")
            {

            }

            object send = speedLabel;
            safeSpeedText((Control)send, stringArr[1]);
        }
    }
}
