using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactPagina;

namespace HoofdschermProjectB
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
            Showpanel(panel1);

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



        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string cBname = comboBox1.SelectedItem.ToString();
            if (cBname == "Horror")
            {
                Showpanel(panelHorror);

            }
            else if (cBname == "Comedy")
            {
                Showpanel(panelComedy);
            }
            else if (cBname == "Action")
            {
                Showpanel(panelAction);
            }
            else if (cBname == "All")
            {
                Showpanel(panel1);
            }

        }
        private void Showpanel(Panel panel)
        {
            HideAllPanels();
            panel.Show();
        }
        private void HideAllPanels()
        {
            panel1.Hide();
            panelAction.Hide();
            panelComedy.Hide();
            panelHorror.Hide();
        }

        private void labelContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            
           contactForm ContactPagina = new contactForm();
            ContactPagina.Show();
            

        }





        private void pictureBoxContact_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            contactForm ContactPagina = new contactForm();
            ContactPagina.Show();
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
