using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class FormStoelenScherm : Form
    {
        List<Button> chairs = new List<Button>();
        List<string> reservedChairsList = new List<string>();
        public static string[] reservedChairs;


        const int ButtonWidth = 45, ButtonHeight = 45;
        int counter = 1, chairCounter = 1;
        Button redChair, reserved;


        public FormStoelenScherm()

        {

            InitializeComponent();
            stoelNummer.Text = "Kies stoel nummer " + chairCounter;
            for (int countVertical = 1, buttonY = 100; countVertical < 11; countVertical++, buttonY += 50)
            {
                for (int countHorizontal = 1, buttonX = 502; countHorizontal < 11; buttonX += 50, counter++, countHorizontal++)
                {
                    Button chair = new Button();
                    chair.Location = new Point(buttonX, buttonY);
                    chair.Size = new Size(ButtonWidth, ButtonHeight);
                    chair.Name = "chair " + counter+", Movie: "+ Movie.movieChosen;
                    chair.Text = "" + counter;
                    chair.TabStop = false;
                    chair.FlatStyle = FlatStyle.Flat;
                    chair.FlatAppearance.BorderSize = 0;
                    chair.BackColor = Color.PeachPuff;
                    chair.Anchor = (AnchorStyles.None);
                    panelStoelen.Controls.Add(chair);
                    chairs.Add(chair);
                    chair.Click += new EventHandler(this.SelectChair);


                }

                reserved = Helper;
            }
            foreach (var item in FormProfiel.dynJson)
            {
                foreach(var chair in item.chair)
                {
                   foreach(Button c in chairs)
                        if(c.Name == chair)
                    {
                            c.BackColor = Color.Red;
                            c.Enabled = false;
                    }
                }
            }



        }

        private void SelectChair(object sender, EventArgs e)
        {

            reserved.BackColor = Color.PeachPuff;
            Button Chair = (Button)sender;       
            Chair.BackColor = Color.Blue;
            buttonVolgende.Enabled = true;
            reserved = Chair;
            redChair = reserved;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (chairCounter < Movie.aantalTickets)
            {
                redChair.BackColor = Color.Red;
                reservedChairsList.Add(redChair.Name);          
                redChair.Enabled = false;
                buttonVolgende.Enabled = false;
                reserved = Helper;
                chairCounter += 1;
                stoelNummer.Text = "Kies stoel nummer " + chairCounter;

            }
            else
            {
                foreach (Button Chair in chairs)
                {
                    Chair.Enabled = false;
                }
                reservedChairsList.Add(redChair.Name);
                redChair.BackColor = Color.Red;
                stoelNummer.Visible = false;
                buttonVolgende.Visible = false;
                buttonReserveerKnop.Visible = true;
            }
        }

        private void ReserveerKnopClick(object sender, EventArgs e)
        {
            this.Hide();
            Betalen BetalenScherm = new Betalen();
            BetalenScherm.Show();
            reservedChairs = reservedChairsList.ToArray();
        }

        private void LabelMovisMouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void LabelMovisMouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;
        }

        private void LabelContactMouseMove(object sender, MouseEventArgs e)
        {
            labelContact.ForeColor = Color.White;
        }

        private void LabelContactMouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.Black;
        }

        private void LabelMyaccountMouseMove(object sender, MouseEventArgs e)
        {
            labelMyaccount.ForeColor = Color.White;
        }

        private void LabelMyaccountMouseLeave(object sender, EventArgs e)
        {
            labelMyaccount.ForeColor = Color.Black;
        }

        private void LabelMovisClick(object sender, EventArgs e)
        {
            Movie hoofdScherm = new Movie();
            this.Hide();
            hoofdScherm.Show();
        }

        private void PictureBoxMovisClick(object sender, EventArgs e)
        {
            Movie hoofdScherm = new Movie();
            this.Hide();
            hoofdScherm.Show();
        }

        private void LabelContactClick(object sender, EventArgs e)
        {
            ContactForm contactScherm = new ContactForm();
            this.Hide();
            contactScherm.Show();
        }

        private void PictureBoxContactClick(object sender, EventArgs e)
        {
            ContactForm contactScherm = new ContactForm();
            this.Hide();
            contactScherm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            this.Hide();
            movie.Show();
        }

        private void LabelMyaccountClick(object sender, EventArgs e)
        {
            FormProfiel profielScherm = new FormProfiel();
            this.Hide();
            profielScherm.Show();
        }

        private void FormStoelenSchermFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxMyProfileClick(object sender, EventArgs e)
        {
            FormProfiel profielScherm = new FormProfiel();
            this.Hide();
            profielScherm.Show();
        }




    }
}


