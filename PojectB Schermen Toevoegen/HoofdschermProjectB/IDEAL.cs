using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace ProjectB
{
    public partial class IDEAL : Form
    {
        
        public IDEAL()
        {
            InitializeComponent();
            if(FormProfiel.loggedin)
            {
                GebruikersNaamLabel.Text = FormProfiel.itemJson.username.ToString();
                EmailLabel.Text = FormProfiel.itemJson.email.ToString();
            }
            else
            {
                GebruikersNaamLabel.Visible = false;
                EmailLabel.Visible = false;
                MailLabel.Visible = false;
                BankBox.Visible = false;
                BankLabel.Visible = false;
                BankNrBox.Visible = false;
                BevestigenKnop.Visible = false;
                BankNrLabel.Visible = false;
                GebruikersNaamBox.Visible = true;
                WachtwoordLabel.Visible = true;
                WachtWoordBox.Visible = true;
                LogInKnop.Visible = true;
                WachtWoordBox.PasswordChar = '*';

            }
        }


        private void Button2Click(object sender, EventArgs e)
        {
            string fileName = "users.json";
            string rawJson = File.ReadAllText(fileName);
            List<Users> dynJson = JsonConvert.DeserializeObject<List<Users>>(rawJson);
            foreach(var item in dynJson)
            {
                if (item.username.ToString() == FormProfiel.itemJson.username.ToString())
                {
                    item.chair = FormStoelenScherm.reservedChairs.Concat(FormProfiel.itemJson.chair).ToArray();
                    FormProfiel.itemJson.chair = item.chair;
                    string newJson = JsonConvert.SerializeObject(dynJson);
                    File.WriteAllText(fileName, newJson);
                }
            }
            MessageBox.Show("Betaling Bevestigd.");
            Transactie.Visible = true;
            check.Visible = true;     
        }

        private void LogInKnopClick(object sender, EventArgs e)
        {
            if(FormProfiel.LogIn(GebruikersNaamBox,WachtWoordBox))
            {
                GebruikersNaamLabel.Visible = true;
                EmailLabel.Visible = true;
                MailLabel.Visible = true;
                BankBox.Visible = true;
                BankLabel.Visible = true;
                BankNrBox.Visible = true;
                BevestigenKnop.Visible = true;
                BankNrLabel.Visible = true;
                GebruikersNaamBox.Visible = false;
                WachtwoordLabel.Visible = false;
                WachtWoordBox.Visible = false;
                LogInKnop.Visible = false;
                GebruikersNaamLabel.Text = FormProfiel.itemJson.username.ToString();
                EmailLabel.Text = FormProfiel.itemJson.email.ToString();
            }
        }
    }
}
