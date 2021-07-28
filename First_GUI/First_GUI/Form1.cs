using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle bounds = Screen.FromHandle(this.Handle).WorkingArea;
            int x_offset = SystemInformation.HorizontalResizeBorderThickness + SystemInformation.FixedFrameBorderSize.Width;
            int y_offset = SystemInformation.VerticalResizeBorderThickness + SystemInformation.FixedFrameBorderSize.Height;

            bounds.X -= x_offset;
            bounds.Width += (x_offset * 2);
            bounds.Height += y_offset;

            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MaximizedBounds = bounds;

            // 창 크기 최대화 처리
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
        }
    }
}
