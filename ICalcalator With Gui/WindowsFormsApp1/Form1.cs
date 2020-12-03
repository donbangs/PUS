using ICalcalator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            var result = await client.AddAsync(new Complex { RealValue = double.Parse(textBox1.Text),
                ImagValue = double.Parse(textBox2.Text) }, new Complex { RealValue = double.Parse(textBox3.Text), 
                    ImagValue = double.Parse(textBox4.Text) });
            textBox5.Text = client.GetValue(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            var result = client.Subtraction(new Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
            textBox5.Text = client.GetValue(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            var result = client.Multiply(new Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
            textBox5.Text = client.GetValue(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
            try
            {
                var result = client.Division(new Complex { RealValue = double.Parse(textBox1.Text), ImagValue = double.Parse(textBox2.Text) }, new Complex { RealValue = double.Parse(textBox3.Text), ImagValue = double.Parse(textBox4.Text) });
                textBox5.Text = client.GetValue(result);
            }
            catch(FaultException<GreetingFault> ex){ MessageBox.Show(ex.Message); }
           

        }
        }
    }

