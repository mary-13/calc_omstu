using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Operation(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(textBox1.Text);
            double secondnumber = Convert.ToDouble(textBox2.Text);
            ICalculator calc = Factory.CreateCalculator(((Button)sender).Name);
            double result = calc.Calculate(firstnumber, secondnumber);

            label1.Text = Convert.ToString(result);
        }
    }
}
