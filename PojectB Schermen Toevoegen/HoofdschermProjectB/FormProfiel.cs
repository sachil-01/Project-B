using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectB

{
    public partial class FormProfiel : Form
    {
        bool loggedin = false;
        public FormProfiel()
        {
            InitializeComponent();
            panelAanmelden.Show();
            panelMyProfile.Hide();
            boxPassword.PasswordChar = '*';
            boxPasswordrepeat.PasswordChar = '*';
            boxWachtwoord.PasswordChar = '*';
        }

        private void ButtonInloggenClick(object sender, EventArgs e)
        {
            bool checker = false;
            string fileName = "users.json";
            string rawJson = File.ReadAllText(fileName);
            
            dynamic dynJson = JsonConvert.DeserializeObject(rawJson);
            
            foreach (var item in dynJson)
            {
                if(item.username == boxGebruikersnaam.Text && item.password == boxWachtwoord.Text)
                {
                    MessageBox.Show("You are logged in now!");
                    panelMyProfile.Show();
                    panelAanmelden.Hide();

                    labelNaam.Text = boxGebruikersnaam.Text;
                    labelMail.Text = item.email.ToString();
                    checker = true;
                }
                
                
            }
            if(checker == false)
            {
                MessageBox.Show("Username or password are not correct!");
            }


        }


        private void LabelMyAccountMouseLeave(object sender, EventArgs e)
        {
            labelMyAccount.ForeColor = Color.Black;
        }

        private void LabelMyAccountMouseMove(object sender, MouseEventArgs e)
        {
            labelMyAccount.ForeColor = Color.White;
        }

        private void LabelContactMouseMove(object sender, MouseEventArgs e)
        {
            labelContact.ForeColor = Color.White;
        }

        private void LabelContactMouseLeave(object sender, EventArgs e)
        {
            labelContact.ForeColor = Color.Black;
        }

        private void LabelMovisMouseMove(object sender, MouseEventArgs e)
        {
            labelMovis.ForeColor = Color.White;
        }

        private void LabelMovisMouseLeave(object sender, EventArgs e)
        {
            labelMovis.ForeColor = Color.Black;

        }

        private void LabelContactClick(object sender, EventArgs e)
        {
            this.Hide();
            contactForm contactform = new contactForm();
            contactform.Show();
        }

        private void IconContactClick(object sender, EventArgs e)
        {
            this.Hide();
            contactForm contactform = new contactForm();
            contactform.Show();
        }

        private void IconMovisClick(object sender, EventArgs e)
        {
            this.Hide();
            Movie Hoofdscherm = new Movie();
            Hoofdscherm.Show();
        }

        private void LabelMovisClick(object sender, EventArgs e)
        {
            this.Hide();
           Movie Hoofdscherm = new Movie();
            Hoofdscherm.Show();
        }

        private void FormProfielFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAccountMakenClick(object sender, EventArgs e)
        {
            string fileName = "users.json";
            string rawJson = File.ReadAllText(fileName);

            dynamic dynJson = JsonConvert.DeserializeObject(rawJson);
            bool checker2 = true;
            foreach (var item in dynJson)
            {
                if (boxUsername.Text == item.username.ToString())
                {
                    MessageBox.Show("Error: Gebruikersnaam al in gebruik");
                    checker2 = false;
                }
            }

            foreach (var item in dynJson)
            {
                if (boxEmail.Text == item.email.ToString())
                {
                    MessageBox.Show("Error: Email al in gebruik");
                    checker2 = false;
                }
            }



            if (boxPassword.Text != boxPasswordrepeat.Text)
            {

                MessageBox.Show("Your password does not match!");

            }
            
            else if(IsValidEmail(boxEmail.Text))
            {
                MessageBox.Show("This mail is not correct");
            }
                   


            else if(checker2)
            {
                Users newuser = new Users
                {
                    username = boxUsername.Text,
                    password = boxPassword.Text,
                    email = boxEmail.Text

                };



                fileName = "users.json";

                rawJson = File.ReadAllText(fileName);

                List<Users> users = JsonConvert.DeserializeObject<List<Users>>(rawJson);


                users.Add(newuser);

                string newJson = JsonConvert.SerializeObject(users);


                File.WriteAllText(fileName, newJson);


                MessageBox.Show("Your account has been made!");
                loggedin = true;
                panelMyProfile.Show();
                panelAanmelden.Hide();

                labelNaam.Text = boxUsername.Text;
                labelMail.Text = boxEmail.Text;
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address != email;
            }
            catch
            {
                return true;
            }
        }

    }
}
