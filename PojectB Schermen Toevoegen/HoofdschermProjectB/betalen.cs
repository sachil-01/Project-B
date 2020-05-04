using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class betalen : Form
    {
        public betalen()
        {
            InitializeComponent();
        }

        private void IDEAL_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PayPal is geselecteerd.");
            button2.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {    
            MessageBox.Show("IDEAL is geselecteerd.");
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new IDEAL();
            newForm.Show(); 


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credit Card is geselecteerd.");
            button2.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("American Express is geselecteerd.");
            button2.Visible = true;
        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
