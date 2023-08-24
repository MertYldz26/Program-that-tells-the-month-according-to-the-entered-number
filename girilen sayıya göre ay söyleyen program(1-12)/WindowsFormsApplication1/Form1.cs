using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay;
            ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1:
                    label1.Text = "ocak";
                    break;
                case 2:
                    label1.Text = "şubat";
                    break;
                case 3:
                    label1.Text = "mart";
                    break;
                case 4:
                    label1.Text = "nisan";
                    break;
                case 5:
                    label1.Text = "mayıs";
                    break;
                case 6:
                    label1.Text = "haziran";
                    break;
                case 7:
                    label1.Text = "temmuz";
                    break;
                case 8:
                    label1.Text = "ağustos";
                    break;
                case 9:
                    label1.Text = "eylül";
                    break;
                case 10:
                    label1.Text = "ekim";
                    break;
                case 11:
                    label1.Text = "kasım";
                    break;
                case 12:
                    label1.Text = "aralık";

                    break;
                default:
                    label1.Text = "1-12 arasında sayı giriniz";
                    break;
                    

            }
        }
    }
}
