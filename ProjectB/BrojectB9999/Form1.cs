using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrojectB9999
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panlStart.Show();
            pnlFilmInfo.Hide();
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            
            pnlFilmInfo.Show();
            panlStart.Hide();
            labelFilmInfo.Text = "In de 25e James Bond-film No Time to Die heeft James Bond zijn\n" +
                " turbulente leven als geheim agent achter zich gelaten en leidt hij een rustig\n" +
                " bestaan op Jamaica.\n" +
                " Dit wordt abrupt onderbroken wanneer zijn oude vriend en CIA agent Felix Leiter\n" +
                " hem vraagt om een ontvoerde wetenschapper te helpen bevrijden.\n" +
                " Deze missie blijkt verraderlijker dan gedacht en brengt Bond op het spoor van een mysterieuze\n" +
                " schurk die gewapend is met levensgevaarlijke nieuwe technologie.\n" +
                " In No Time to Die keert Daniel Craig terug voor zijn vijfde film als Ian Flemings James Bond 007.\n" +
                " De cast bestaat verder uit Rami Malek, Léa Seydoux, Lashana Lynch, Ben Whishaw, \n" +
                "Naomie Harris, Billy Magnussen, Ana de Armas, Rory Kinnear, David Dencik, Dali Benssalah, \n" +
                "Jeffrey Wright en Ralph Fiennes.\n" +
                " Deze co-productie van Albert R. Broccoli’s EON Productions,\n" +
                " Metro Goldwyn Mayer Studios (MGM) en Universal Pictures International is geregisseerd door\n" +
                " Cary Joji Fukunaga (Beasts of No Nation, True Detective).\n" +
                " Het scenario is geschreven door Neal Purvis & Robert Wade (Spectre, Skyfall), Cary Joji Fukunaga, \n" +
                "Scott Z. Burns (Contagion, The Bourne Ultimatum) en Phoebe Waller-Bridge (Killing Eve, Fleabag)";
            picNoTime.Show();
            picPlus.Show();
            picBlodsHot.Hide();
            picLikeBoss.Hide();
            picOnWard.Hide();
            labelFilmDuurt.Text = "150 minuten";
            labelSoortFilm.Text = "Actie, Avontuur, Thriller";
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            pnlFilmInfo.Show();
            panlStart.Hide();
            labelFilmInfo.Text = "In deze verfilming van de populaire gelijknamige comic speelt Vin Dies\n" +
                "el de rol van Ray Garrison,\n een marinier die door de RTS Corporation opnieuw tot leven\n" +
                " gewekt wordt als de superheld Bloodshot\n" +
                "Met nanotechnologie in zijn aderen is hij sterker dan ooit en geneest hij meteen van \n" +
                "verwondingen.\n De RTS Corporation heeft niet alleen de controle over zijn lichaam, \n" +
                "maar ook over zijn geest en herinneringen.\nRay zet alles op het spel om de controle \n" +
                "over zijn leven terug te krijgen.";
            picNoTime.Hide();
            picOnWard.Hide();

            picBlodsHot.Show();
            picLikeBoss.Hide();
            labelFilmDuurt.Text = "130 minuten";
            labelSoortFilm.Text = "Actie";
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            pnlFilmInfo.Show();
            panlStart.Hide();
            labelFilmInfo.Text = "In de hilarische nieuwe komedie Like a Boss lijkt het de beste\n" +
                " vriendinnen Mia en Mel (Tiffany Haddish en Rose Byrne) voor de wind te gaan met hun \n" +
                "eigen cosmeticabedrijf. Helaas zitten ze flink in de schulden en een aanbod van de \n" +
                "keiharde cosmeticagigant Claire Luna (Salma Hayek) om de zaak over te kopen is dan \n" +
                "ook te aanlokkelijk om af te slaan. De levenslange vriendschap tussen Mel en Mia komt \n" +
                "hierna flink onder druk te staan.";
            picNoTime.Hide();

            picBlodsHot.Hide();
            picLikeBoss.Show();
            picOnWard.Hide();
            labelFilmDuurt.Text = "160 minuten";
            labelSoortFilm.Text = "Comedy";


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFilmInfo.Hide();
            panlStart.Show();
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            pnlFilmInfo.Show();
            panlStart.Hide();
            labelFilmInfo.Text = "De nieuwe Disney en Pixar film Onward vertelt het verhaal van twee \n" +
                "tiener elvenbroers. Samen beginnen ze aan een bijzondere en avontuurlijke zoektocht om" +
                "\n te ontdekken of er nog ergens in de wereld magie te vinden is. \n" +
                "Deze nieuwe animatiefilm van Pixar Animation Studios is geregisseerd door Dan Scanlon \n" +
                "en geproduceerd door Kori Rae - het team achter Monsters University. Onward is vanaf 4\n" +
                " maart 2020 te zien in de Nederlandse bioscopen. ";

            picNoTime.Hide();
            picBlodsHot.Hide();
            picLikeBoss.Hide();
            picOnWard.Show();
            labelFilmDuurt.Text = "120 minuten";
            labelSoortFilm.Text = "Animatie, Avontuur, Comedy, Kinderfilm";
        }


    }
}
