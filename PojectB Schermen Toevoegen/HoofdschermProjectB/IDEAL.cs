using System;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class IDEAL : Form
    {
        public IDEAL()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Betaling Bevestigd.");
            Transactie.Visible = true;
            check.Visible = true;
        }


    }
}
