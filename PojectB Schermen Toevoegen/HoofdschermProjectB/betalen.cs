using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Betalen : Form
    {
        public Betalen()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
            Betaalbutton.Visible = true;
            Selcect2.Visible = true;
            Selcect1.Visible = false;

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            Betaalbutton.Visible = true;
            Selcect1.Visible = true;
            Selcect2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            var newForm = new IDEAL();
            newForm.Show(); 


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credit Card is geselecteerd.");
            Betaalbutton.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("American Express is geselecteerd.");
            Betaalbutton.Visible = true;
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
            Movie hoofdScherm = new Movie();
            this.Hide();
            hoofdScherm.Show();
        }

        private void pictureBoxMovis_Click(object sender, EventArgs e)
        {
            Movie hoofdScherm = new Movie();
            this.Hide();
            hoofdScherm.Show();
        }

        private void labelContact_Click(object sender, EventArgs e)
        {
            ContactForm contactPagina = new ContactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void pictureBoxContact_Click(object sender, EventArgs e)
        {
            ContactForm contactPagina = new ContactForm();
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

        private void betalen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
