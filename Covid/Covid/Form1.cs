using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid;
using Covid.ServiceReference1;


namespace Covid
{
    public partial class Form1 : Form
    {

        public CovidServiceClient client = new CovidServiceClient();
        public string ToString(PersonWithCovid covid)
        {
            string outString="";
            switch (covid.TypePerson)
            {
                case CovidPerson.Infected:
                    outString = covid.TypePerson + " : " + covid.Name;
                    break;
                case CovidPerson.ContactWithInfected:
                    outString = covid.TypePerson + " : " + covid.Name;
                    break;
            }
            return outString;
        }
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.AddInfected(CovidPerson.Infected,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.AddContact(CovidPerson.ContactWithInfected,textBox5.Text, textBox6.Text, textBox7.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                PersonWithCovid infected = client.GetInfected();
                listBox1.Items.Add(ToString(infected));


            var contacts = client.GetContacts();
            for (int x = 0; x < contacts.Count(); x++)
            {
                listBox1.Items.Add(ToString(contacts[x]));
            }

        }
    }
}
