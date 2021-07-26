using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int[] array = new int[1000];
            int value = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int value2 = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));

            for(int i = 0; i < value2; i++)
            {
                System.Random random = new System.Random();
                int num = random.Next(1, value + 1);

                bool flag = false;
                for(int j = 0; j < i; j++)
                {
                    if (array[j] == num)
                    {
                        flag = true;
                        break;
                    }
                }

                if(flag == true)
                {
                    i--;
                    continue;
                }
                else
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
