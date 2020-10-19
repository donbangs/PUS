using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            textBox5.Text = client.Add(new ServiceReference1.Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new ServiceReference1.Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            textBox5.Text = client.Subtraction(new ServiceReference1.Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new ServiceReference1.Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            textBox5.Text = client.Multiply(new ServiceReference1.Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new ServiceReference1.Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            textBox5.Text = client.Division(new ServiceReference1.Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new ServiceReference1.Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
        }
    }
}
