using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaP_LR_01C
{
    public partial class FormLab1 : Form
    {
        public FormLab1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double x, a;
            x = double.Parse(textBoxX.Text);
            a = double.Parse(textBoxA.Text);

            OutputL(x, a);
        }

        private void OutputL(double x, double a)
        {
            double l = CalculateL(x, a);

            textBoxL.Text = l.ToString();
        }

        private double CalculateL(double x, double a)
        {
            double l;

            if (x < 0)
            {
                double ax = Math.Pow(a, x);

                l = Math.Max(x, ax);
            }
            else if (x > 1)
                l = 0;
            else
            {
                double min1, min2, min3, min, sinx;

                min1 = (x - a) / x;

                min2 = Math.Sqrt(a) + x;

                sinx = Math.Sin(x);
                min3 = sinx * sinx;

                min = Math.Min(min1, min2);
                l = Math.Min(min, min3);
            }

            return l;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
