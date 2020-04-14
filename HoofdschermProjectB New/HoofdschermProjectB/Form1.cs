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

namespace HoofdschermProjectB
{
    public partial class Form1 : Form

    {
        string[] Horror = { "the Nun", "The Fop Reformed", "MUSE", "DACHRA", "A QUIET PLACE" };
        string[] Comedy = { "bad boys", "Like a boss", "Onward", "Aladdin", "Hors Normes", "Scapin The Schemer" };
        string[] Action = { "no time to die", "Midway", "Training Day", "Brooklyn Affairs" };
        

        public Form1()
        {
            InitializeComponent();
            panel1.Show();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string cBname = comboBox1.SelectedItem.ToString();
            if (cBname == "Horror")
            {

                foreach (Control item in panel1.Controls)
                {
                    if (item.Tag == cBname)
                    {
                        item.Show();

                    }
                    else
                    {
                        item.Hide();
                    }
                }

            }
            else if (cBname == "Action")
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Tag == cBname)
                    {

                        item.Show();


                    }
                    else
                    {
                        item.Hide();
                    }

                }

            }
            else if (cBname == "Comedy")
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Tag == cBname)
                    {
                        item.Show();

                    }
                    else
                    {
                        item.Hide();
                    }

                }

            }
            else if (cBname == "All")
            {

                foreach (Control item in panel1.Controls)
                {
                    item.Show();
                }

            }
            comboBox1.Show();
            panelBoven2.Show();
            panel1.Show();
            labelGenre.Show();
            btnExit.Show();
        }

        private void labelMyaccount_MouseMove(object sender, MouseEventArgs e)
        {
            labelMyaccount.ForeColor = Color.White;
        }

        private void labelMyaccount_MouseLeave(object sender, EventArgs e)
        {
            labelMyaccount.ForeColor = Color.Black;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Sachil Code
        private void OnwardPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Onward";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "De nieuwe Disney en Pixar film Onward vertelt het\n" +
                "verhaal van twee tiener elvenbroers.\n" +
                "Samen beginnen ze aan een bijzondere\n" +
                "en avontuurlijke zoektocht om te ontdekken\n" +
                "of er nog ergens in de wereld magie te vinden is.";

            MovieDetails.Text = "Genre: Animatie / Fantasy\n" +
                "Leeftijd: 3+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 41m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "5 maart 2021\n" +
                "13:00 - 15:00";
            Reserveerknop.Text = "Reserveer\n" + "een plek";

            


            pictureBox6.Image = Image.FromFile("resources\\Onward.png");

        }

        private void BrooklynPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Brooklyn Affairs";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Motherless Brooklyn is een Amerikaanse neo-noir misdaadfilm\n" +
                "uit 2019, geschreven,geproduceerd en geregisseerd door Edward Norton,\n" +
                "gebaseerd op de gelijknamige roman uit 1999 van \n" +
                "Jonathan Lethem.\n" +
                "De film speelt zich af in 1957 in New York City\n" +
                "en volgt een privédetective met het Tourette-syndroom,\n" +
                "die vastbesloten is de moord op zijn mentor op te lossen. \n" +
                "Samen met Norton speelt de film ook Bruce Willis,\n" +
                "Gugu Mbatha-Raw, Bobby Cannavale, Cherry Jones, Alec Baldwin en Willem Dafoe.";

            MovieDetails.Text = "Genre:  Crime, Drama, Mystery\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "14 april 2020\n" +
                "14:00 - 17:00";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\Brooklyn.jpg");
        }

        private void pictureBoxMovis_Click(object sender, EventArgs e)
        {
            MovieDescriptionPanel.Hide();
            panel1.Show();
        }

        private void LikeabossPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "LIKE A BOSS";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "In de hilarische nieuwe komedie Like a Boss lijkt het \n" +
                "de beste vriendinnen Mia en Mel\n" +
                "(Tiffany Haddish en Rose Byrne) voor de wind te gaan\n" +
                "met hun eigen cosmeticabedrijf.\n";

            MovieDetails.Text = "Genre:  Comedy\n" +
                "Leeftijd: 12+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 23m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "14 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\like a boss.png");
        }

        private void MidwayPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "MIDWAY";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Midway is een oorlogsfilm uit 2019,\n" +
                "geregisseerd door Roland Emmerich.\n" +
                "De film is gebaseerd op de Aanval op \n" +
                "Pearl Harbor en de daaropvolgende\n" +
                "Slag bij Midway tijdens de Tweede Wereldoorlog.";

            MovieDetails.Text = "Genre:  Comedy\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 18m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "15 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\midway.jpg");
        }

        private void BadBoysPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Bad Boys for Life";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Terwijl Mike Lowrey in een midlifecrisis zit is Marcus Burnett opgeklommen tot\n" +
                "politie-inspecteur.De twee herenigen wanneer ze tot de ontdekking komen dat\n" +
                "een Albanese huurmoordenaar hen dood wenst.Er blijkt een persoonlijk motief\n" +
                "achter te zitten sinds zijn broer gedood werd door Lowrey en Burnett.";

            MovieDetails.Text = "Genre:  Actie\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 1m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "16 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\bad boys for life.jpg");
        }

        private void TrainingDayPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Training Day";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Jake Hoyt begint aan zijn eerste dag bij de narcoticabrigade.\n" +
                "lonzo Harris, de leider van het team, blijkt niet alles volgens het boekje te doen.\n" +
                "Op een onorthodoxe manier probeert hij Jake klaar te stomen voor de klus,\n" +
                "maar is de manier waarop hij dit doet wel geoorloofd? ";

            MovieDetails.Text = "Genre:  Misdaad/Drama\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 2m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "17 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBox6.Image = Image.FromFile("resources\\trainingday.png");
        }

        private void HorsNormesPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Hors Normes";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Bruno en Malik houden zich reeds 20 jaar op in de leefwereld van de kinderen\n" +
                "en jongvolwassenen met autisme.Ze hebben de leiding over twee non-profitorganisaties\n" +
                "waar ze kansarme jongeren helpen hulpverlener te worden,\n" +
                "om te zorgen voor extreme gevallen die door andere instellingen worden geweigerd.\n" +
                "Tussen deze buitengewone persoonlijkheden\n" +
                "groeit een intieme band. \n";

            MovieDetails.Text = "Genre:  Komedie/Drama\n" +
                "Leeftijd: 12+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 4m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "17 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";

            pictureBox6.Image = Image.FromFile("resources\\hors_normes_banner.jpg");
        }

        private void AlladinPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Aladdin";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Aladdin is een straatschoffie dat steelt om te overleven en verliefd is op een prinses,\n" +
                "de dochter van de Sultan. Vervolgens vindt hij een magische lamp, waaruit een Geest\n" +
                "verschijnt die in staat is wensen te vervullen. Met hulp van deze Geest probeert\n" +
                "Aladdin vervolgens het hart van de prinses te veroveren.";

            MovieDetails.Text = "Genre:  Avontuur/Familie\n" +
                "Leeftijd: 9+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 8m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "18 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";
            
            
            pictureBox6.Image = Image.FromFile("resources\\Alladin.jpg");
        }

        private void NotimetodiePicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "No Time To Die";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "In 'No Time to Die' heeft James Bond zijn turbulente leven als geheim agent\n" +
                "achter zich gelaten en leidt hij een rustig bestaan op Jamaica.\n" +
                "Zijn rust is echter van korte duur wanneer zijn oude vriend Felix Leiter van de CIA\n" +
                "opduikt met de vraag naar hulp. Het brengt hem op het spoor van een mysterieuze schurk\n" +
                "gewapend met gevaarlijke nieuwe technologie.";

            MovieDetails.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 13+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "18 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\no-time-to-die.png");
        }

        private void ScapintheschemerPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Scapin the schemer";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "De amoureuze bedoelingen van Octave en Léandre worden gedwarsboomd door twee\n" +
                "autoritaire vaders die net zijn teruggekeerd van een reis, vastbesloten om hun\n" +
                "zonen met twee vreemden te trouwen. De jonge mannen wenden zich tot\n" +
                "de sluwe Scapin voor hulp en leggen hun lot in zijn handen ...\n";

            MovieDetails.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 13+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "18 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBox6.Image = Image.FromFile("resources\\scapin_poster.jpg");
        }

        private void MusePicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Muse";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Een treurende Engelse literatuurprofessor die lijdt aan een vreselijk terugkerende\n" +
                "nachtmerrie, zal al snel worden ondergedompeld in een macabere wereld\n" +
                "van mythe en bijgeloof geregeerd door een verbond van zeven\n" +
                "kwaadaardige vrouwen.\n";

            MovieDetails.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 47m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "19 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBox6.Image = Image.FromFile("resources\\Muse.png");
        }

        private void DachraPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "Dachra";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "De studente Yassmine doet samen met Walid en Bilel onderzoek naar de onopgeloste\n" +
                "zaak van Mongia, een vrouw die ruim twee decennia geleden verminkt teruggevonden\n" +
                "werd. Heden verblijft ze in een psychiatrische instelling en wordt ze van hekserij \n" +
                "beschuldigd. De vrienden gaan naar de plek waar ze destijds gevonden werd en\n" +
                "ontdekken er een oud en afgelegen bouwwerk genaamd Dachra, waarin zich bizarre\n" +
                "taferelen afspelen. Op uitnodiging van de charismatische sekteleider blijven\n" +
                " ze er een nachtje. Een nacht die evenwel hun laatste kan zijn. \n";

            MovieDetails.Text = "Genre:  Horror\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 3m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "20 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\dachra.jpg");
        }

        private void AquietplacePicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "A quiet place";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Een gezin moet sluipend, lippend en gebarend door het leven gaan.\n" +
                "Het minste geluid kan hen overleveren aan geheimzinnige wezens die\n" +
                "jagen op het gehoor. In het volle besef dat zelfs een voetstap of gefluister \n" +
                "dodelijk kunnen zijn, proberen Evelyn en Lee een manier te vinden om hun kinderen \n" +
                "koste wat kost te beschermen en hun loerende vijanden te overwinnen.\n";

            MovieDetails.Text = "Genre:  Drama/Horror\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 30m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "21 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";

            pictureBox6.Image = Image.FromFile("resources\\aquietplace.jpg");
        }

        private void TheFopRevormedPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "The fop reformed";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Het verhaal is dat van een jonge Parijzenaar wiens ouders een goede\n" +
                "match voor hem hebben gevonden,de dochter van een graaf. Maar wanneer hij\n" +
                "haar gaat bezoeken,kan de knappe jongen - wiens Parijse manieren ver\n" +
                "verwijderd zijn van de regels van het decorum die in de provincies heersen\n" +
                "zijn hart niet openen voor zijn lieftallige bedoeling. Stung, de laatste\n" +
                "besluit hem een ​​lesje te leren voor zijn arrogantie ... \n";

            MovieDetails.Text = "Genre:  Comedy\n" +
                "Leeftijd: 3+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 16m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "22 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBox6.Image = Image.FromFile("resources\\thefopreformed_poster.jpg");
        }

        private void TheNunPicture_Click(object sender, EventArgs e)
        {
            panelBoven2.Show();
            MovieDescriptionPanel.Show();
            panel1.Hide();
            MovieTitle.Text = "The Nun";
            MovieDescription.Text = "Film beschrijving:\n\n" +
                "Het Vaticaan stuurt een priester met een spookachtig verleden en een novice\n" +
                "op de drempel van haar laatste geloften om de dood van een jonge non\n" +
                "in Roemenië te onderzoeken en het op te nemen tegen een kwaadaardige\n" +
                " kracht in de vorm van een demonische non.\n";

            MovieDetails.Text = "Genre:  Horror/Myserie/Thriller\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 36m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            BioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "23 april 2020\n" +
                "16:00 - 17:30";
            Reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBox6.Image = Image.FromFile("resources\\thenun.jpg");
        }
    }
}
