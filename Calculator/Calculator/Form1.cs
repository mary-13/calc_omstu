using System;
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
            try
            {
                double firstnumber = Convert.ToDouble(textBox1.Text);
                double secondnumber = Convert.ToDouble(textBox2.Text);
                ICalculator calc = Factory.CreateCalculator(((Button) sender).Name);
                double result = calc.Calculate(firstnumber, secondnumber);

                label1.Text = Convert.ToString(result);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Произошла ошибка: " + exception.Message);
            } 
        }

        private void SingleOperation(object sender, EventArgs e)
        {
            try
            {
                double firstnumber = Convert.ToDouble(textBox1.Text);
                IOneArg calc = SingleFactory.CreateCalc(((Button) sender).Name);
                double result = calc.Calc(firstnumber);

                label1.Text = Convert.ToString(result);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Произошла ошибка: " + exception.Message);
            }
        }
    }
}
