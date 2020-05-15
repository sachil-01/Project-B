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
    public partial class contactForm : Form
    {
        public contactForm()
        {
            InitializeComponent();
            labelContact.Text = "Bioscoop Kinepolis";
            label3.Text = "Plaats:\nKastanjeboom12\n3117HJ\nRotterdam";
            label4.Text = "Heeft u vragen of een suggestie?\nvoor contact kunt u bellen of mailen naar\n- 0107283453\n- kinepolis@cin.nl";
        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            this.Hide();
            Form1 a = new Form1();
            a.Show();
           
        }

        private void labelMovis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
            
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void labelMovis_MouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void labelMovis_MouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
            
            
            FormProfiel formProfiel = new FormProfiel();
            this.Hide();
            formProfiel.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormProfiel formProfiel = new FormProfiel();
            this.Hide();
            formProfiel.Show();
        }

        private void contactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
