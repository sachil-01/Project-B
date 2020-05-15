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
        public FormProfiel()
        {
            InitializeComponent();
            panelAanmelden.Show();
            panelMyProfile.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool checker = false;
            string fileName = "users.json";
            string rawJson = File.ReadAllText(fileName);
            
            dynamic dynJson = JsonConvert.DeserializeObject(rawJson);
            
            foreach (var item in dynJson)
            {
                if(item.username == gebruikersnaam.Text && item.password == wachtwoord.Text)
                {
                    MessageBox.Show("You are logged in now!");
                    panelMyProfile.Show();
                    panelAanmelden.Hide();

                    naam.Text = gebruikersnaam.Text;
                    mail.Text = wachtwoord.Text;
                    checker = true;
                }
                
                
            }
            if(checker == false)
            {
                MessageBox.Show("Username or password are not correct!");
            }


        }


        private void labelMyAccount_MouseLeave(object sender, EventArgs e)
        {
            labelMyAccount.ForeColor = Color.Black;
        }

        private void labelMyAccount_MouseMove(object sender, MouseEventArgs e)
        {
            labelMyAccount.ForeColor = Color.White;
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

        private void labelContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactForm contactform = new contactForm();
            contactform.Show();
        }

        private void iconContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactForm contactform = new contactForm();
            contactform.Show();
        }

        private void iconMovis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Hoofdscherm = new Form1();
            Hoofdscherm.Show();
        }

        private void labelMovis_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 Hoofdscherm = new Form1();
            Hoofdscherm.Show();
        }

        private void FormProfiel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "users.json";
            string rawJson = File.ReadAllText(fileName);

            dynamic dynJson = JsonConvert.DeserializeObject(rawJson);
            bool checker2 = true;
            //foreach (var item in dynJson)
            //{
            //    if(username.Text == item.username)
            //    {
            //        MessageBox.Show("Error: Gebruikersnaam al in gebruik");
            //        checker2 = false;
            //    }
            //}




            if (password.Text != passwordrepeat.Text)
            {

                MessageBox.Show("Your password does not match!");

            }
            
            else if(IsValidEmail(email.Text))
            {
                MessageBox.Show("This mail is not correct");
            }
                   


            else if(checker2)
            {
                Users newuser = new Users
                {
                    username = username.Text,
                    password = password.Text,
                    email = email.Text

                };



                fileName = "users.json";

                rawJson = File.ReadAllText(fileName);

                List<Users> users = JsonConvert.DeserializeObject<List<Users>>(rawJson);


                users.Add(newuser);

                string newJson = JsonConvert.SerializeObject(users);


                File.WriteAllText(fileName, newJson);


                MessageBox.Show("Your account has been made!");
                panelMyProfile.Show();
                panelAanmelden.Hide();

                naam.Text = username.Text;
                mail.Text = email.Text;
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
