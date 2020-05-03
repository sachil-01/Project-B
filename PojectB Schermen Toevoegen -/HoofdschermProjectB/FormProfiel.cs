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
    public partial class FormProfiel : Form
    {
        public FormProfiel()
        {
            InitializeComponent();
            panelAanmelden.Show();
            panelMyProfile.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxGebruiksnaam.Text == "mohamad" && textBoxWachtword.Text == "1234")
            {
                panelMyProfile.Show();
                panelAanmelden.Hide();
            }
            else
            {
                MessageBox.Show("Gebruiksnaam of wachtwoord zijn onjuist");
            }
            
            
        }


        private void labelMyAccount_MouseLeave(object sender, EventArgs e)
        {
            labelMyAccount.ForeColor = Color.Black;
        }

        private void labelMyAccount_MouseMove(object sender, MouseEventArgs e)
        {
            labelMyAccount.ForeColor = Color.White;
        }

        private void labelContact_MouseMove(object sender, MouseEventArgs e)
        {
            labelContact.ForeColor = Color.White;
        }

        private void labelContact_MouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.Black;
        }

        private void labelMovis_MouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void labelMovis_MouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;

        }

        private void labelContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactForm contactform = new contactForm();
            contactform.Show();
        }

        private void iconContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactForm contactform = new contactForm();
            contactform.Show();
        }

        private void iconMovis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Hoofdscherm = new Form1();
            Hoofdscherm.Show();
        }

        private void labelMovis_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 Hoofdscherm = new Form1();
            Hoofdscherm.Show();
        }
    }
}
