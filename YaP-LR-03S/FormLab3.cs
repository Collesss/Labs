using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaP_LR_03S
{
    public partial class FormLab3 : Form
    {
        public FormLab3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(double.Parse(textBox2X.Text), double.Parse(textBox1E.Text));

            //Math.Log()
        }


        private void Calculate(double x, double e)
        {
            listBox1ApproximateRoot.Items.Clear();
            listBox2Iteration.Items.Clear();

            double ResX = Math.Log(1+x);

            double ApproximateX = x;

            int n = 1;

            double Root = 0;

            do
            {
                listBox1ApproximateRoot.Items.Add(ApproximateX.ToString());
                
                ApproximateX += Root;

                listBox2Iteration.Items.Add(n.ToString());

                Root = Math.Pow(-1, n) * (Math.Pow(x, n + 1) / (n + 1));

                //Console.WriteLine(Root);

                n++;
            }
            while (Math.Abs(Root) > e);


        }
    }
}
