using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Giaiptbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiaipt_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
            if (a == 0)
                if (b == 0)
                    if (c != 0)
                        lblketqua.Text = "phương trình vô nghiệm";
                    else
                        lblketqua.Text = "phương trình có vô số nghiệm";
                else
                {
                    x1 = x2 = -c / b;
                    lblketqua.Text = "phương trình có nghiệm x =" + x1;
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    lblketqua.Text = "phương trình vô nghiệm";
                else
                {
                    x1 = x2 = -b / (2 * a);
                    if (delta == 0)
                        lblketqua.Text = "phương trình có nghiệm kép x1 = x2 =" + x1;



                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        lblketqua.Text = "Phương trình có 2 nghiệm phân biệt:" + "\nx1 = " + x1 + "\nx2 = " + x2;
                    }
                }
            }
        }
    }
}

