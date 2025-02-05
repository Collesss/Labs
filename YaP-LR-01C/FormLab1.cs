﻿using System;
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

                if (x > ax)
                    l = x;
                else
                    l = ax;
            }
            else if (x > 1)
                l = 0;
            else
            {
                double min1, min2, min3, min;
                min1 = (x - a) / x;
                min2 = Math.Sqrt(a) + x;
                min3 = Math.Pow(Math.Sin(x), 2);

                if (min1 < min2)
                    min = min1;
                else
                    min = min2;

                if (min < min3)
                    l = min;
                else
                    l = min3;
            }
            return l;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
