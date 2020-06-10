using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EASendMail; 
namespace ProjectB
{
    public partial class IDEAL : Form
    {
        public IDEAL()
        {
            InitializeComponent();
            if(FormProfiel.loggedIn)
            {
                GebruikersNaamLabel.Text = FormProfiel.itemJson.username.ToString();
                EmailLabel.Text = FormProfiel.itemJson.email.ToString();
            }
            else
            {
                ShowLabel(false);
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
            BevestigEmail();
        }

        private void LogInKnopClick(object sender, EventArgs e)
        {
            if(FormProfiel.LogIn(GebruikersNaamBox,WachtWoordBox))
            {
                ShowLabel(true);
                GebruikersNaamLabel.Text = FormProfiel.itemJson.username.ToString();
                EmailLabel.Text = FormProfiel.itemJson.email.ToString();
            }
        }
        private static void BevestigEmail()
        {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                oMail.From = "Cinema4All1@gmail.com";
                oMail.To = FormProfiel.itemJson.email.ToString();
                oMail.Subject = "Bevestiging reservering";
                oMail.TextBody = "Beste "+ FormProfiel.itemJson.username.ToString()+ ",\n\n" +
                    "Wij hebben uw reservering ontvangen.\nHierbij melden wij dat uw reservering bevestigd is.\n\n" +
                    "Vriendelijke groet,\n" +
                    "Het Cinema4All team.";
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");
                oServer.User = "Cinema4All1@gmail.com";
                oServer.Password = "Projectb24";
                oServer.Port = 587;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                Console.WriteLine("start to send email over SSL ...");
                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);
                Console.WriteLine("email was sent successfully!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
        }
        public void ShowLabel(bool visibility)
        {
            GebruikersNaamLabel.Visible = visibility;
            EmailLabel.Visible = visibility;
            MailLabel.Visible = visibility;
            BankBox.Visible = visibility;
            BankLabel.Visible = visibility;
            BankNrBox.Visible = visibility;
            BevestigenKnop.Visible = visibility;
            BankNrLabel.Visible = visibility;
            GebruikersNaamBox.Visible = !(visibility);
            WachtwoordLabel.Visible = !(visibility);
            WachtWoordBox.Visible = !(visibility);
            LogInKnop.Visible = !(visibility);
        }
    }
}
