using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_ver._2._0
{
    public partial class kalkulator : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;


        public kalkulator()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operationPressed))
                result.Clear();

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";


        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;

            value = double.Parse(result.Text);
            operationPressed = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }

            operationPressed = false;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;

        }
    }
}
