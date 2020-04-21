using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_B_cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IDEAL_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PayPal has been selected.");
            button2.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {    
            MessageBox.Show("IDEAL has been selected.");
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
          

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credit Card has been selected.");
            button2.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("American Express Card has been selected.");
            button2.Visible = true;
        }
    }
}
