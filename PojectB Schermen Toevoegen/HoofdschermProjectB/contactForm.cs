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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            labelContact.Text = "Bioscoop CINEMA4U";
            labelInfo2.Text = "Plaats:\nKastanjeboom12\n3117HJ\nRotterdam";
            labeInfo.Text = "Heeft u vragen of een suggestie?\nvoor contact kunt u bellen of mailen naar\n- 0107283453\n- CINEMA4U@cin.nl";
        }

  

        private void PictureBoxMovieClick(object sender, EventArgs e)
        {
            

            this.Hide();
            Movie a = new Movie();
            a.Show();
           
        }

        private void LabelMovisClick(object sender, EventArgs e)
        {
            this.Hide();
            Movie a = new Movie();
            a.Show();
            
        }

        private void LabeProfileMouseMove(object sender, MouseEventArgs e)
        {
            labelMyAccountt.ForeColor = Color.White;
        }

        private void LabeProfileMouseLeave(object sender, EventArgs e)
        {
            labelMyAccountt.ForeColor = Color.Black;
        }

        private void LabelContactMouseMove(object sender, MouseEventArgs e)
        {
            labelContactt.ForeColor = Color.White;
        }

        private void LabelContacMouseLeave(object sender, EventArgs e)
        {
            labelContactt.ForeColor = Color.Black;
        }

        private void LabelMovisMouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void LabelMovisMouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;
        }



        private void LabelProfileClick(object sender, EventArgs e)
        {
         
            
            
            FormProfiel formProfiel = new FormProfiel();
            this.Hide();
            formProfiel.Show();
        }

        private void PictureBoxProfileClick(object sender, EventArgs e)
        {
            FormProfiel formProfiel = new FormProfiel();
            this.Hide();
            formProfiel.Show();
        }

        private void ContactFormFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
