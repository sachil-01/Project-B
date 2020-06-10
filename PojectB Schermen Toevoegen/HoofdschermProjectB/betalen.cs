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



        private void PictureBox1Click(object sender, EventArgs e)
        {
        
            Betaalbutton.Visible = true;
            Selcect2.Visible = true;
            Selcect1.Visible = false;

        }
        private void PictureBox2Click(object sender, EventArgs e)
        {
          
            Betaalbutton.Visible = true;
            Selcect1.Visible = true;
            Selcect2.Visible = false;

        }

        private void Button2Click(object sender, EventArgs e)
        {
           
            var newForm = new IDEAL();
            newForm.Show(); 


        }

        private void PictureBox3Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credit Card is geselecteerd.");
            Betaalbutton.Visible = true;
        }

        private void PictureBox4Click(object sender, EventArgs e)
        {
            MessageBox.Show("American Express is geselecteerd.");
            Betaalbutton.Visible = true;
        }

        private void LabelMovisMouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void LabelMovisMouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;
        }

        private void LabelContactMouseMove(object sender, MouseEventArgs e)
        {
            labelContact.ForeColor = Color.White;
        }

        private void LabelContactMouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.Black;
        }

        private void LabelMyaccountMouseMove(object sender, MouseEventArgs e)
        {
            labelMyaccount.ForeColor = Color.White;
        }

        private void LabelMyaccountMouseLeave(object sender, EventArgs e)
        {
            labelMyaccount.ForeColor = Color.Black;
        }

        private void LabelMovisClick(object sender, EventArgs e)
        {
            Movie hoofdScherm = new Movie();
            this.Hide();
            hoofdScherm.Show();
        }

        private void PictureBoxMovisClick(object sender, EventArgs e)
        {
            Movie hoofdScherm = new Movie();
            this.Hide();
            hoofdScherm.Show();
        }

        private void LabelContactClick(object sender, EventArgs e)
        {
            ContactForm contactPagina = new ContactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void PictureBoxContactClick(object sender, EventArgs e)
        {
            ContactForm contactPagina = new ContactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void LabelMyaccountClick(object sender, EventArgs e)
        {
            FormProfiel profielPagina = new FormProfiel();
            this.Hide();
            profielPagina.Show();
        }

        private void PictureBoxMyaccountClick(object sender, EventArgs e)
        {
            FormProfiel profielPagina = new FormProfiel();
            this.Hide();
            profielPagina.Show();
        }

        private void BetalenFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBackBetalenClick(object sender, EventArgs e)
        {
            FormStoelenScherm formStoelenScherm = new FormStoelenScherm();
            this.Hide();
            formStoelenScherm.Show();
        }
    }
}
