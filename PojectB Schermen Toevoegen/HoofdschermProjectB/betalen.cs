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

        private void labelMovis_MouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void labelMovis_MouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;
        }

        private void labelContact_MouseMove(object sender, MouseEventArgs e)
        {
            labelContact.ForeColor = Color.White;
        }

        private void labelContact_MouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.Black;
        }

        private void labelMyaccount_MouseMove(object sender, MouseEventArgs e)
        {
            labelMyaccount.ForeColor = Color.White;
        }

        private void labelMyaccount_MouseLeave(object sender, EventArgs e)
        {
            labelMyaccount.ForeColor = Color.Black;
        }

        private void labelMovis_Click(object sender, EventArgs e)
        {
            Form1 hoofdScherm = new Form1();
            this.Hide();
            hoofdScherm.Show();
        }

        private void pictureBoxMovis_Click(object sender, EventArgs e)
        {
            Form1 hoofdScherm = new Form1();
            this.Hide();
            hoofdScherm.Show();
        }

        private void labelContact_Click(object sender, EventArgs e)
        {
            contactForm contactPagina = new contactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void pictureBoxContact_Click(object sender, EventArgs e)
        {
            contactForm contactPagina = new contactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void labelMyaccount_Click(object sender, EventArgs e)
        {
            FormProfiel profielPagina = new FormProfiel();
            this.Hide();
            profielPagina.Show();
        }

        private void pictureBoxMyaccount_Click(object sender, EventArgs e)
        {
            FormProfiel profielPagina = new FormProfiel();
            this.Hide();
            profielPagina.Show();
        }
    }
}
