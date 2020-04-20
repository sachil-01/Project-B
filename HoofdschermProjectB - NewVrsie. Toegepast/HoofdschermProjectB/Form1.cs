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

        public Form1()
        {
            InitializeComponent();
            Showpanel(panel1);

        }

        private void labelMyaccountMouseMove(object sender, MouseEventArgs e)
        {
            labelMyaccount.ForeColor = Color.White;
        }

        private void labelMyaccountMouseLeave(object sender, EventArgs e)
        {
            labelMyaccount.ForeColor = Color.Black;
        }

        private void labelContactMouseMove(object sender, MouseEventArgs e)
        {
            labelContact.ForeColor = Color.White;
        }

        private void labelContactMouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.Black;
        }

        private void labelMovisMouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void labelMovisMouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;
        }



        private void ComboBox1SelectedValueChanged(object sender, EventArgs e)
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

        private void labelContactClick(object sender, EventArgs e)
        {
            this.Hide();
            
           contactForm ContactPagina = new contactForm();
            ContactPagina.Show();
            

        }





        private void PictureBoxContactClick1(object sender, EventArgs e)
        {
            this.Hide();

            contactForm ContactPagina = new contactForm();
            ContactPagina.Show();
            
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
