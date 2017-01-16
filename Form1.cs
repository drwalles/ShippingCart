using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double blend = 39.95;
            const int tax = 7;
            string name, stad, city, state;
            int zip, hm;
            name = textBox1.Text;
            stad = textBox2.Text;
            city = textBox3.Text;
            state = textBox4.Text;
            zip = Convert.ToInt32(textBox5.Text);
            hm = Convert.ToInt32(textBox6.Text);
            double hm1 = blend * hm;
            double totaltax = blend * hm * tax / 100;
            double total = hm1 + totaltax;
            label8.Text = "Your Name: " + name + "\nStreet Address: " + stad + "\nCity: " + city + "\nState: "
                + state + "\nZip Code: " + zip + "\nNumber of Blend: " + hm + "\nTax: " + tax + "%\nSingle piece Priece: "
                + blend.ToString("c") + "\nTotal Excluding Tax: " + hm1.ToString("c") + "\nTotal Tax: " + totaltax.ToString("c") + "\nTotal including Tax: " + total.ToString("c");
        }
    }
}
