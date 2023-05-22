using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corner_Grocery_Item_Tracking
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string myVar = Class1.DictionaryToString(Class1.CountItems());
            MessageBox.Show(myVar); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string textBoxText = textBox6.Text.ToLower();
            string displayCount = Class1.SaleCount(textBoxText);
            MessageBox.Show(displayCount);           
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string myVar = Class1.DictionaryToHistString(Class1.CountItems());
            MessageBox.Show(myVar);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
