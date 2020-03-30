using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoofdschermProjectB
{
    public partial class Form1 : Form

    {
        string[] Horror = { "the Nun", "The Fop Reformed", "MUSE", "DACHRA", "A QUIET PLACE" };
        string[] Comedy = { "bad boys", "Like a boss", "Onward", "Aladdin", "Hors Normes", "Scapin The Schemer" };
        string[] Action = { "no time to die", "Midway", "Training Day", "Brooklyn Affairs" };
        public Form1()
        {
            InitializeComponent();
            panel1.Show();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string cBname = comboBox1.SelectedItem.ToString();
            if (cBname == "Horror")
            {

                foreach (Control item in panel1.Controls)
                {
                    if (item.Tag == cBname)
                    {
                        item.Show();

                    }
                    else
                    {
                        item.Hide();
                    }
                }

            }
            else if (cBname == "Action")
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Tag == cBname)
                    {

                        item.Show();


                    }
                    else
                    {
                        item.Hide();
                    }

                }

            }
            else if (cBname == "Comedy")
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Tag == cBname)
                    {
                        item.Show();

                    }
                    else
                    {
                        item.Hide();
                    }

                }

            }
            else if (cBname == "All")
            {

                foreach (Control item in panel1.Controls)
                {
                    item.Show();
                }

            }
            comboBox1.Show();
            panelBoven2.Show();
            panel1.Show();
            labelGenre.Show();
            btnExit.Show();
        }

        private void labelMyaccount_MouseMove(object sender, MouseEventArgs e)
        {
            labelMyaccount.ForeColor = Color.White;
        }

        private void labelMyaccount_MouseLeave(object sender, EventArgs e)
        {
            labelMyaccount.ForeColor = Color.Black;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        // sachil code

        private void panelBoven2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            onward.Show();
        }

        private void pictureBoxMovis_Click(object sender, EventArgs e)
        {
            onward.Hide();
        }

        private void labelMovis_Click(object sender, EventArgs e)
        {
            onward.Hide();
        }

        private void onward_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMovis_Click_1(object sender, EventArgs e)
        {
            onward.Hide();
        }

        private void OnwardDescription_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMovis_Click_1(object sender, EventArgs e)
        {
            onward.Hide();
            BrooklynAffairs.Visible = false;
            LikeABoss.Visible = false;
            MIDWAY.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            BrooklynAffairs.Show();
            LikeABoss.Hide();
            MIDWAY.Hide();
            onward.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            LikeABoss.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            MIDWAY.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }
    }
}
