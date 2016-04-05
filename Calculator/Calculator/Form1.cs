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
            double result;
            switch(((Button)sender).Name)
                {
                case "button1":
                result = firstnumber + secondnumber;
                break;

                case "button2":
                result = firstnumber - secondnumber;
                break;

                case "button3":
                result = firstnumber * secondnumber;
                break;

                case "button4":
                result = firstnumber / secondnumber;
                break;

                default:
                    throw new Exception("Неизвестная операция");
            }
            label1.Text = Convert.ToString(result);
        }
    }
}
