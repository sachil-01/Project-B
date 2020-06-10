using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProjectB
{
    
    public partial class Movie : Form
    {
        public static string movieChosen;
        public static int aantalTickets;
        public Movie()
        {
            
            InitializeComponent();

            ShowPanel(panelMovies);

        }

        private void LabelMyaccountMouseMove(object sender, MouseEventArgs e)
        {
            LabelMyaccount.ForeColor = Color.White;
        }

        private void LabelMyaccountMouseLeave(object sender, EventArgs e)
        {
            LabelMyaccount.ForeColor = Color.Black;
        }

        private void LabelContactMouseMove(object sender, MouseEventArgs e)
        {
            LabelContact.ForeColor = Color.White;
        }

        private void LabelContactMouseLeave(object sender, EventArgs e)
        {
            LabelContact.ForeColor = Color.Black;
        }

        private void LabelMovisMouseMove(object sender, MouseEventArgs e)
        {
            LabelMovis.ForeColor = Color.White;
        }

        private void LabelMovisMouseLeave(object sender, EventArgs e)
        {
            LabelMovis.ForeColor = Color.Black;
        }

        private void ComboBox1SelectedValueChanged(object sender, EventArgs e)
        {
            ChooseGenre(comboBoxAll.SelectedItem.ToString());
        }
        private void ComboBox2SelectedValueChanged(object sender, EventArgs e)
        {
            ChooseGenre(comboBoxAction.SelectedItem.ToString());
        }
        private void ComboBox3SelectedValueChanged(object sender, EventArgs e)
        {
            ChooseGenre(comboBoxComedy.SelectedItem.ToString());
        }
        private void ComboBox4SelectedValueChanged(object sender, EventArgs e)
        {
            ChooseGenre(comboBoxHorror.SelectedItem.ToString());
        }
        private void ShowPanel(Panel panel)
        {
            HideAllPanels();
            panel.Show();
        }
        private void HideAllPanels()
        {
            panelMovies.Hide();
            panelAction.Hide();
            panelComedy.Hide();
            panelHorror.Hide();
            movieDescriptionPanel.Hide();
            ReserveerStoel.Hide();
        }

        private void labelContactClick(object sender, EventArgs e)
        {
            this.Hide();
            
           ContactForm ContactPagina = new ContactForm();
            ContactPagina.Show();
            

        }
        public void ChooseGenre(string genre)
        {
            switch(genre)
            {
                case "Horror":
                    ShowPanel(panelHorror);
                    break;
                case "Comedy":
                    ShowPanel(panelComedy);
                    break;
                case "Action":
                    ShowPanel(panelAction);
                    break;
                case "All":
                    ShowPanel(panelMovies);
                    break;
            }
        }

        private void PictureBoxContactClick1(object sender, EventArgs e)
        {
            this.Hide();

            ContactForm ContactPagina = new ContactForm();
            ContactPagina.Show();
            
        }
        private void LabelMyaccountClick(object sender, EventArgs e)
        {

            if (FormProfiel.loggedIn)
            {
                FormProfiel profielPagina = new FormProfiel();
                this.Hide();
                profielPagina.Show();
            }

            else
            {

                FormProfiel profielPagina = new FormProfiel();
                this.Hide();
                profielPagina.Show();
            }
        }

        private void LabelMovisClick(object sender, EventArgs e)
        {
            ShowPanel(panelMovies);
        }

        private void PictureBoxMovisClick(object sender, EventArgs e)
        {
            ShowPanel(panelMovies);
        }


        private void BtnQuitClick(object sender, EventArgs e)
        {
            Close();
        }

        // Sachil Code
        private void PictureBoxOnwardClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            


            movieTitle.Text = "Onward";
            movieChosen = "Onward";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "De nieuwe Disney en Pixar film Onward vertelt het\n" +
                "verhaal van twee tiener elvenbroers.\n" +
                "Samen beginnen ze aan een bijzondere\n" +
                "en avontuurlijke zoektocht om te ontdekken\n" +
                "of er nog ergens in de wereld magie te vinden is.";

            movieDetails.Text = "Genre: Animatie / Fantasy\n" +
                "Leeftijd: 3+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 41m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre: Animatie / Fantasy\n" +
                "Leeftijd: 3+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 41m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "5 maart 2021\n" +
                "13:00 - 15:00";



            pictureBoxBeschrijving.Image = Image.FromFile("resources\\Onward.png");
            moviePicture.Image = Image.FromFile("resources\\Onward.png");
        }

        private void PictureBoxBrooklynClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Brooklyn Affairs";
            movieChosen = "Brooklyn Affairs";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Motherless Brooklyn is een Amerikaanse neo-noir misdaadfilm\n" +
                "uit 2019, geschreven,geproduceerd en geregisseerd door Edward Norton,\n" +
                "gebaseerd op de gelijknamige roman uit 1999 van \n" +
                "Jonathan Lethem.\n" +
                "De film speelt zich af in 1957 in New York City\n" +
                "en volgt een privédetective met het Tourette-syndroom,\n" +
                "die vastbesloten is de moord op zijn mentor op te lossen. \n" +
                "Samen met Norton speelt de film ook Bruce Willis,\n" +
                "Gugu Mbatha-Raw, Bobby Cannavale, Cherry Jones, Alec Baldwin en Willem Dafoe.";

            movieDetails.Text = "Genre:  Crime, Drama, Mystery\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Crime, Drama, Mystery\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "14 april 2020\n" +
                "16:00 - 19:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\Brooklyn.jpg");
            moviePicture.Image = Image.FromFile("resources\\Brooklyn.jpg");
        }

        private void PictureBoxLikeABossClick(object sender, EventArgs e)

        {
            ShowPanel(movieDescriptionPanel);

            movieTitle.Text = "LIKE A BOSS";
            movieChosen = "LIKE A BOSS";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "In de hilarische nieuwe komedie Like a Boss lijkt het \n" +
                "de beste vriendinnen Mia en Mel\n" +
                "(Tiffany Haddish en Rose Byrne) voor de wind te gaan\n" +
                "met hun eigen cosmeticabedrijf.\n";

            movieDetails.Text = "Genre:  Comedy\n" +
                "Leeftijd: 12+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 23m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Comedy\n" +
                "Leeftijd: 12+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 23m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "14 april 2020\n" +
                "19:30 - 21:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\like a boss.png");
            moviePicture.Image = Image.FromFile("resources\\like a boss.png");
        }

        private void PictureBoxMidwayClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "MIDWAY";
            movieChosen = "MIDWAY";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Midway is een oorlogsfilm uit 2019,\n" +
                "geregisseerd door Roland Emmerich.\n" +
                "De film is gebaseerd op de Aanval op \n" +
                "Pearl Harbor en de daaropvolgende\n" +
                "Slag bij Midway tijdens de Tweede Wereldoorlog.";

            movieDetails.Text = "Genre:  Comedy\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 18m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Comedy\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 18m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 1)\n\n" +
                "Tijdstip:\n\n" +
                "15 april 2020\n" +
                "22:00 - 00:30";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\midway.jpg");
            moviePicture.Image = Image.FromFile("resources\\midway.jpg");
        }

        private void PictureBoxBadBoysClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Bad Boys for Life";
            movieChosen = "Bad Boys for Life";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Terwijl Mike Lowrey in een midlifecrisis zit is Marcus Burnett opgeklommen tot\n" +
                "politie-inspecteur.De twee herenigen wanneer ze tot de ontdekking komen dat\n" +
                "een Albanese huurmoordenaar hen dood wenst.Er blijkt een persoonlijk motief\n" +
                "achter te zitten sinds zijn broer gedood werd door Lowrey en Burnett.";

            movieDetails.Text = "Genre:  Actie\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 1m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Actie\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 1m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "16 april 2020\n" +
                "13:00 - 15:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\bad boys for life.jpg");
            moviePicture.Image = Image.FromFile("resources\\bad boys for life.jpg");
        }

        private void PictureBoxTrainingDayClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Training Day";
            movieChosen = "Training Day";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Jake Hoyt begint aan zijn eerste dag bij de narcoticabrigade.\n" +
                "lonzo Harris, de leider van het team, blijkt niet alles volgens het boekje te doen.\n" +
                "Op een onorthodoxe manier probeert hij Jake klaar te stomen voor de klus,\n" +
                "maar is de manier waarop hij dit doet wel geoorloofd? ";

            movieDetails.Text = "Genre:  Misdaad/Drama\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 2m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Misdaad/Drama\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 2m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "17 april 2020\n" +
                "16:00 - 18:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBoxBeschrijving.Image = Image.FromFile("resources\\trainingday.png");
            moviePicture.Image = Image.FromFile("resources\\trainingday.png");
        }

        private void PictureBoxHorsClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Hors Normes";
            movieChosen = "Hors Normes";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Bruno en Malik houden zich reeds 20 jaar op in de leefwereld van de kinderen\n" +
                "en jongvolwassenen met autisme.Ze hebben de leiding over twee non-profitorganisaties\n" +
                "waar ze kansarme jongeren helpen hulpverlener te worden,\n" +
                "om te zorgen voor extreme gevallen die door andere instellingen worden geweigerd.\n" +
                "Tussen deze buitengewone persoonlijkheden\n" +
                "groeit een intieme band. \n";

            movieDetails.Text = "Genre:  Komedie/Drama\n" +
                "Leeftijd: 12+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 4m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Komedie/Drama\n" +
                "Leeftijd: 12+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 4m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "17 april 2020\n" +
                "19:00 - 21:30";
            reserveerknop.Text = "Reserveer\n" + "een plek";

            pictureBoxBeschrijving.Image = Image.FromFile("resources\\hors_normes_banner.jpg");
            moviePicture.Image = Image.FromFile("resources\\hors_normes_banner.jpg");
        }

        private void PictureBoxAladdinClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Aladdin";
            movieChosen = "Aladdin";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Aladdin is een straatschoffie dat steelt om te overleven en verliefd is op een prinses,\n" +
                "de dochter van de Sultan. Vervolgens vindt hij een magische lamp, waaruit een Geest\n" +
                "verschijnt die in staat is wensen te vervullen. Met hulp van deze Geest probeert\n" +
                "Aladdin vervolgens het hart van de prinses te veroveren.";

            movieDetails.Text = "Genre:  Avontuur/Familie\n" +
                "Leeftijd: 9+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 8m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Avontuur/Familie\n" +
                "Leeftijd: 9+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 8m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 2)\n\n" +
                "Tijdstip:\n\n" +
                "18 april 2020\n" +
                "22:00 - 00:30";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\Alladin.jpg");
            moviePicture.Image = Image.FromFile("resources\\Alladin.jpg");
        }

        private void PictureBoxNoTimeToDieClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "No Time To Die";
            movieChosen = "No Time To Die";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "In 'No Time to Die' heeft James Bond zijn turbulente leven als geheim agent\n" +
                "achter zich gelaten en leidt hij een rustig bestaan op Jamaica.\n" +
                "Zijn rust is echter van korte duur wanneer zijn oude vriend Felix Leiter van de CIA\n" +
                "opduikt met de vraag naar hulp. Het brengt hem op het spoor van een mysterieuze schurk\n" +
                "gewapend met gevaarlijke nieuwe technologie.";

            movieDetails.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 13+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 13+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "18 april 2020\n" +
                "13:00 - 16:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\no-time-to-die.png");
            moviePicture.Image = Image.FromFile("resources\\no-time-to-die.png");
        }

        private void PictureBoxScapinClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Scapin the schemer";
            movieChosen = "Scapin the schemer";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "De amoureuze bedoelingen van Octave en Léandre worden gedwarsboomd door twee\n" +
                "autoritaire vaders die net zijn teruggekeerd van een reis, vastbesloten om hun\n" +
                "zonen met twee vreemden te trouwen. De jonge mannen wenden zich tot\n" +
                "de sluwe Scapin voor hulp en leggen hun lot in zijn handen ...\n";

            movieDetails.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 13+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 13+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 42m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "18 april 2020\n" +
                "17:00 - 20:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBoxBeschrijving.Image = Image.FromFile("resources\\scapin_poster.jpg");
            moviePicture.Image = Image.FromFile("resources\\scapin_poster.jpg");
        }
        private void PictureBoxMuseClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Muse";
            movieChosen = "Muse";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Een treurende Engelse literatuurprofessor die lijdt aan een vreselijk terugkerende\n" +
                "nachtmerrie, zal al snel worden ondergedompeld in een macabere wereld\n" +
                "van mythe en bijgeloof geregeerd door een verbond van zeven\n" +
                "kwaadaardige vrouwen.\n";

            movieDetails.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 47m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Actie/Avontuur\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 47m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "19 april 2020\n" +
                "20:30 - 22:30";
            reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBoxBeschrijving.Image = Image.FromFile("resources\\Muse.png");
            moviePicture.Image = Image.FromFile("resources\\Muse.png");
        }

        private void PictureBoxDachraClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "Dachra";
            movieChosen = "Dachra";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "De studente Yassmine doet samen met Walid en Bilel onderzoek naar de onopgeloste\n" +
                "zaak van Mongia, een vrouw die ruim twee decennia geleden verminkt teruggevonden\n" +
                "werd. Heden verblijft ze in een psychiatrische instelling en wordt ze van hekserij \n" +
                "beschuldigd. De vrienden gaan naar de plek waar ze destijds gevonden werd en\n" +
                "ontdekken er een oud en afgelegen bouwwerk genaamd Dachra, waarin zich bizarre\n" +
                "taferelen afspelen. Op uitnodiging van de charismatische sekteleider blijven\n" +
                " ze er een nachtje. Een nacht die evenwel hun laatste kan zijn. \n";

            movieDetails.Text = "Genre:  Horror\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 3m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Horror\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 3m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 3)\n\n" +
                "Tijdstip:\n\n" +
                "20 april 2020\n" +
                "23:00 - 01:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\dachra.jpg");
            moviePicture.Image = Image.FromFile("resources\\dachra.jpg");
        }

        private void PictureBoxAQuitPlaceClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "A quiet place";
            movieChosen = "A quiet place";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Een gezin moet sluipend, lippend en gebarend door het leven gaan.\n" +
                "Het minste geluid kan hen overleveren aan geheimzinnige wezens die\n" +
                "jagen op het gehoor. In het volle besef dat zelfs een voetstap of gefluister \n" +
                "dodelijk kunnen zijn, proberen Evelyn en Lee een manier te vinden om hun kinderen \n" +
                "koste wat kost te beschermen en hun loerende vijanden te overwinnen.\n";

            movieDetails.Text = "Genre:  Drama/Horror\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 30m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Drama/Horror\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 30m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 4)\n\n" +
                "Tijdstip:\n\n" +
                "21 april 2020\n" +
                "15:00 - 16:30";
            reserveerknop.Text = "Reserveer\n" + "een plek";

            pictureBoxBeschrijving.Image = Image.FromFile("resources\\aquietplace.jpg");
            moviePicture.Image = Image.FromFile("resources\\aquietplace.jpg");
        }

        private void PictureBoxTheFopClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "The fop reformed";
            movieChosen = "The fop reformed";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Het verhaal is dat van een jonge Parijzenaar wiens ouders een goede\n" +
                "match voor hem hebben gevonden,de dochter van een graaf. Maar wanneer hij\n" +
                "haar gaat bezoeken,kan de knappe jongen - wiens Parijse manieren ver\n" +
                "verwijderd zijn van de regels van het decorum die in de provincies heersen\n" +
                "zijn hart niet openen voor zijn lieftallige bedoeling. Stung, de laatste\n" +
                "besluit hem een ​​lesje te leren voor zijn arrogantie ... \n";

            movieDetails.Text = "Genre:  Comedy\n" +
                "Leeftijd: 3+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 16m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Comedy\n" +
                "Leeftijd: 3+\n" +
                "Prijs: $12\n" +
                "Filmduur:  2h 16m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 4)\n\n" +
                "Tijdstip:\n\n" +
                "22 april 2020\n" +
                "17:00 - 19:30";
            reserveerknop.Text = "Reserveer\n" + "een plek";


            pictureBoxBeschrijving.Image = Image.FromFile("resources\\thefopreformed_poster.jpg");
            moviePicture.Image = Image.FromFile("resources\\thefopreformed_poster.jpg");
        }
        private void PictureBoxTheNunClick(object sender, EventArgs e)
        {
            ShowPanel(movieDescriptionPanel);
            movieTitle.Text = "The Nun";
            movieChosen = "The Nun";
            movieDescription.Text = "Film beschrijving:\n\n" +
                "Het Vaticaan stuurt een priester met een spookachtig verleden en een novice\n" +
                "op de drempel van haar laatste geloften om de dood van een jonge non\n" +
                "in Roemenië te onderzoeken en het op te nemen tegen een kwaadaardige\n" +
                " kracht in de vorm van een demonische non.\n";

            movieDetails.Text = "Genre:  Horror/Myserie/Thriller\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 36m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            movieDetails2.Text = "Genre:  Horror/Myserie/Thriller\n" +
                "Leeftijd: 16+\n" +
                "Prijs: $12\n" +
                "Filmduur:  1h 36m\n" +
                "Te zien in: 3D, IMAX, Dolby Cinema";

            bioscoopDetails.Text = "Bioscoop kinepolis\n" +
                "(Zaal 4)\n\n" +
                "Tijdstip:\n\n" +
                "23 april 2020\n" +
                "20:00 - 22:00";
            reserveerknop.Text = "Reserveer\n" + "een plek";
            pictureBoxBeschrijving.Image = Image.FromFile("resources\\thenun.jpg");
            moviePicture.Image = Image.FromFile("resources\\thenun.jpg");
        }
        private void PictureBoxBrooklClick(object sender, EventArgs e)
        {
            PictureBoxBrooklynClick(sender, e);
        }

        private void PictureBoxMidwaClick(object sender, EventArgs e)
        {
            PictureBoxMidwayClick(sender, e);
        }

        private void PictureBoxTrainingClick(object sender, EventArgs e)
        {
            PictureBoxTrainingDayClick(sender, e);
        }

        private void PictureBoxNoTimeClick(object sender, EventArgs e)
        {
            PictureBoxNoTimeToDieClick(sender, e);
        }

        private void PictureBoxOnwarClick(object sender, EventArgs e)
        {
            PictureBoxOnwardClick(sender, e);
        }

        private void PictureBoxLikeABosClick(object sender, EventArgs e)
        {
            PictureBoxLikeABossClick( sender,  e);
        }

        private void PictureBoxAladinClick(object sender, EventArgs e)
        {
            PictureBoxAladdinClick( sender,  e);
        }

        private void PictureBoxScapiClick(object sender, EventArgs e)
        {
            PictureBoxScapinClick(sender, e);
        }

        private void PictureBoxBadBoyClick(object sender, EventArgs e)
        {
            PictureBoxBadBoysClick(sender, e);
        }

        private void PictureBoxHorClick(object sender, EventArgs e)
        {
            PictureBoxHorsClick(sender, e);
        }

        private void PictureBoxMusClick(object sender, EventArgs e)
        {
            PictureBoxMuseClick(sender, e);
        }

        private void PictureBoxDachrClick(object sender, EventArgs e)
        {
            PictureBoxDachraClick(sender, e);
        }

        private void PictureBoxAQuitClick(object sender, EventArgs e)
        {
            PictureBoxAQuitPlaceClick(sender, e);
        }

        private void PictureBoxTheFoClick(object sender, EventArgs e)
        {
            PictureBoxTheFopClick(sender, e);
        }

        private void PictureBoxTheNuClick(object sender, EventArgs e)
        {
            PictureBoxTheNunClick(sender, e);
        }

        // panel ReserveerStoel

        private void ReserveerknopClick(object sender, EventArgs e)
        {
            ShowPanel(ReserveerStoel);
        }
        int total = 0;

        private void NumberofPeopleSelectedValueChanged(object sender, EventArgs e)
        {
            total = 0;
            string numberOfPeople = NumberofPeople.SelectedItem.ToString();


            if (numberOfPeople == "1")
            {
                total = 12;
                labelTotalprice.Text = "$" + total;
            }
            else if (numberOfPeople == "2")
            {
                total = 24;
                labelTotalprice.Text = "$" + total;
            }
            else if (numberOfPeople == "3")
            {
                total = 36;
                labelTotalprice.Text = "$" + total;
            }
            else if (numberOfPeople == "4")
            {
                total = 48;
                labelTotalprice.Text = "$" + total;
            }
            else if (numberOfPeople == "5")
            {
                total = 60;
                labelTotalprice.Text = "$" + total;
            }
            aantalTickets = Int32.Parse(numberOfPeople);
        }
        
        private void ButtonKiesStoelClick(object sender, EventArgs e)
        {
            if (total < 12)
            {
                MessageBox.Show("Kies minimaal 1 persoon");

            }

            else
            {
                this.Hide();
                FormStoelenScherm formStoelen = new FormStoelenScherm();
                formStoelen.Show();
            }
        }

        private void Form1FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}