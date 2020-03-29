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
    }
}
