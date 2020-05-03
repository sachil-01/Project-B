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
    public partial class FormStoelen : Form
    {
        List<Button> chairs = new List<Button>();

        const int ButtonWidth = 45;
        const int ButtonHeight = 45;
        int n = 1;
        Button reserved;
        public FormStoelen()


        
        {
            InitializeComponent();
            for (int j = 1, ButtonY=100; j <11; j++,ButtonY+=50)
            {
                for ( int i = 1, ButtonX = 502; i < 11; ButtonX += 50,n++,i++)
                {
                    Button chair = new Button();
                    chair.Location = new Point(ButtonX, ButtonY);
                    chair.Size = new Size(ButtonWidth, ButtonHeight);
                    chair.Name = "chair " + n;
                    chair.Text = "" + n;
                    chair.TabStop = false;
                    chair.FlatStyle = FlatStyle.Flat;
                    chair.FlatAppearance.BorderSize = 0;
                    chair.BackColor = Color.PeachPuff;
                    panel1.Controls.Add(chair);
                    chairs.Add(chair);
                    chair.Click += new EventHandler(this.clickfun);


                }


            }
             reserved=chairs[0];

        }

         void clickfun(object sender, EventArgs e)
        {
            reserved.BackColor= Color.PeachPuff;
            Button chair = (Button)sender;
            chair.BackColor = Color.Blue;
            reserved = chair;
            
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
            Form1 hoofdscherm = new Form1();
            this.Hide();
            hoofdscherm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 hoofdscherm = new Form1();
            this.Hide();
            hoofdscherm.Show();
        }

        private void labelContact_Click(object sender, EventArgs e)
        {
            contactForm contactPagina = new contactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            contactForm contactPagina = new contactForm();
            this.Hide();
            contactPagina.Show();
        }

        private void labelMyaccount_Click(object sender, EventArgs e)
        {
            FormProfiel formProfiel = new FormProfiel();
            this.Hide();
            formProfiel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormProfiel formProfiel = new FormProfiel();
            this.Hide();
            formProfiel.Show();
        }
    }
    }


