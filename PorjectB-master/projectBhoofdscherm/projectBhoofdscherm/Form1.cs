using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectBhoofdscherm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelStartScherm.Show();

            panel2Next.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelStartScherm.Show();
        }

        private void NextKnopRecht_Click(object sender, EventArgs e)
        {
            panel2Next.Show();

            panelStartScherm.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelStartScherm.Show();

            panel2Next.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            qweerqweqwe.Form1 omak = new qweerqweqwe.Form1();
            omak.Show();
            Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            qweerqweqwe.Form1 omak = new qweerqweqwe.Form1();
            omak.Show();
            Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
