using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectB

{
    public partial class FormProfiel : Form
    {

        public static bool loggedin = false;
        public static Users itemJson;
        public static string username = "";
        public static string email = "";
        public static string fileName = "users.json";
        public static string rawJson = File.ReadAllText(fileName);
        public static List<Users> dynJson = JsonConvert.DeserializeObject<List<Users>>(rawJson);

        public FormProfiel()
        {
            InitializeComponent();
            if (loggedin)
            {
                panelAanmelden.Hide();
                panelMyProfile.Show();
                labelNaam.Text = itemJson.username.ToString();
                labelMail.Text = itemJson.email.ToString();
                getReserveringen();
            }





            else
            {
                panelAanmelden.Show();
                panelMyProfile.Hide();

            }
            
            boxPassword.PasswordChar = '*';
            boxPasswordrepeat.PasswordChar = '*';
            boxWachtwoord.PasswordChar = '*';
        }
        public static bool LogIn(TextBox boxNaam, TextBox boxWachtword)
        {
            bool checker = false;
            fileName = "users.json";
            rawJson = File.ReadAllText(fileName);
            dynJson = JsonConvert.DeserializeObject<List<Users>>(rawJson);
            foreach (var item in dynJson)
            {
                if (item.username == boxNaam.Text && item.password == boxWachtword.Text)
                {
                    MessageBox.Show("You are logged in now!");

                    FormProfiel.loggedin = true;
                    FormProfiel.username = item.username.ToString();
                    FormProfiel.email = item.email;
                    FormProfiel.itemJson = item;
                    checker = true;
                    return true;
                }


            }
            if (checker == false)
            {
                MessageBox.Show("Username or password are not correct!");
                return false;
            }
            return false;
        }

        private void ButtonInloggenClick(object sender, EventArgs e)
        {
            if(LogIn(boxGebruikersnaam, boxWachtwoord))
            {
                panelMyProfile.Show();
                panelAanmelden.Hide();
                labelNaam.Text= boxGebruikersnaam.Text;
                labelMail.Text= email.ToString();
                getReserveringen();

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
            ContactForm contactform = new ContactForm();
            contactform.Show();
        }

        private void IconContactClick(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactform = new ContactForm();
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
                    email = boxEmail.Text,
                    chair = new string [0],
                    

                };
                fileName = "users.json";
                rawJson = File.ReadAllText(fileName);
                List<Users> users = JsonConvert.DeserializeObject<List<Users>>(rawJson);
                users.Add(newuser);
                string newJson = JsonConvert.SerializeObject(users);
                dynJson = JsonConvert.DeserializeObject<List<Users>>(rawJson);
                File.WriteAllText(fileName, newJson);
                MessageBox.Show("Your account has been made!");
                loggedin = true;
                panelMyProfile.Show();
                panelAanmelden.Hide();
                itemJson = newuser;
                getReserveringen();
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

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            loggedin = false;
            MessageBox.Show("U bent nu uitgelogd!");
            panelMyProfile.Hide();
            panelAanmelden.Show();
            boxGebruikersnaam.Clear();
            boxPassword.Clear();
            boxWachtwoord.Clear();
            boxUsername.Clear();
            boxEmail.Clear();
            boxPasswordrepeat.Clear();
        }
        public void getReserveringen()
        {
            if (itemJson.chair.Length == 0)
            {
                reserveringen.Text = "U hebt geen reserveringen";
            }
            else
            {
                reserveringen.Text = "";
                foreach (var item in itemJson.chair)
                {
                    reserveringen.Text += item + "\n";
                }
            }
        }
    }
}
