using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vlaggen
{
    public partial class vlag : Form
    {

    public vlag()
        {
            InitializeComponent();
        }

        /** Er zijn 196 vlaggen; op het eerste scherm kan een spelletje gespeeld worden waarbij 
            landen met vlaggen gecombineerd moeten worden. Op het tweede scherm is een overzicht van 
            alle vlaggen */

        Image[] imagesVlaggenArray = new Image[197];
        int ScoreOutput = 0;
        int HighScoreOutput = 0;
        int randomVlag;
        int randomPlaatsingText;        
                        
        Random randomNummer1 = new Random();
        Random randomNummer2 = new Random();
        Random randomNummer3 = new Random();
        Random randomNummer4 = new Random();
        Random randomNummer5 = new Random();
        Random randomNummer6 = new Random();
        Random randomNummer7 = new Random();
        Random randomNummer8 = new Random();
        Random randomNummer9 = new Random();
        Random randomNummer10 = new Random();

        private void pictureVlag_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStartOpnieuw_Click(object sender, EventArgs e)
        {
            textHoofdstad.Text = "";
            textOppervlakte.Text = "";
            textInwoners.Text = "";
            textAntwoordCorrect.Text = "";
            textAntwoordInCorrect.Text = "";
            textToelichtingJuisteAntwoord.Text = "";
            btnVolgendeVlag.Enabled = false;
            btnAntwoordA.Enabled = true;
            btnAntwoordB.Enabled = true;
            btnAntwoordC.Enabled = true;
            btnAntwoordD.Enabled = true;

            randomVlag = randomNummer1.Next(1, 197);
            randomPlaatsingText = randomNummer5.Next(1, 5);
                       
            int corresponderendeRandomLand = randomVlag;
            pictureVlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + randomVlag);
            
            List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
            var juisteAntwoord = landen.ElementAt(corresponderendeRandomLand);            

            if (randomPlaatsingText == 1)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1,44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1,44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordA.Text = Convert.ToString(juisteAntwoord);                
                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
            else if (randomPlaatsingText == 2)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordB.Text = Convert.ToString(juisteAntwoord);
                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
            else if (randomPlaatsingText == 3)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordC.Text = Convert.ToString(juisteAntwoord);
                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
            else if (randomPlaatsingText == 4)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordD.Text = Convert.ToString(juisteAntwoord);
                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
        }
        
        private void btnVolgendeVlag_Click(object sender, EventArgs e)
        {
            textToelichtingJuisteAntwoord.Text = "";
            btnVolgendeVlag.Enabled = false;
            btnAntwoordA.Enabled = true;
            btnAntwoordB.Enabled = true;
            btnAntwoordC.Enabled = true;
            btnAntwoordD.Enabled = true;
            randomVlag = randomNummer1.Next(1, 197);
            randomPlaatsingText = randomNummer5.Next(1, 5);

            int corresponderendeRandomLand = randomVlag;
            pictureVlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + randomVlag);

            List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
            var juisteAntwoord = landen.ElementAt(corresponderendeRandomLand);

            if (randomPlaatsingText == 1)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordA.Text = Convert.ToString(juisteAntwoord);
                textAntwoordCorrect.Text = "";
                textAntwoordInCorrect.Text = "";
                textHoofdstad.Text = "";
                textOppervlakte.Text = "";
                textInwoners.Text = "";
            }
            else if (randomPlaatsingText == 2)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordB.Text = Convert.ToString(juisteAntwoord);
                textAntwoordCorrect.Text = "";
                textAntwoordInCorrect.Text = "";
                textHoofdstad.Text = "";
                textOppervlakte.Text = "";
                textInwoners.Text = "";
            }
            else if (randomPlaatsingText == 3)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordD.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordC.Text = Convert.ToString(juisteAntwoord);
                textAntwoordCorrect.Text = "";
                textAntwoordInCorrect.Text = "";
                textHoofdstad.Text = "";
                textOppervlakte.Text = "";
                textInwoners.Text = "";
            }
            else if (randomPlaatsingText == 4)
            {
                if (randomVlag < 45)
                {
                    int randomVlagTwee = randomNummer6.Next(45, 85);
                    int randomVlagDrie = randomNummer7.Next(85, 135);
                    int randomVlagVier = randomNummer8.Next(135, 197);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag > 152)
                {
                    int randomVlagTwee = randomNummer6.Next(1, 63);
                    int randomVlagDrie = randomNummer7.Next(63, 120);
                    int randomVlagVier = randomNummer8.Next(120, 152);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                else if (randomVlag >= 45 && randomVlag <= 152)
                {
                    int randomVlagTwee = randomVlag - randomNummer9.Next(1, 44);
                    int randomVlagDrie = randomVlag + randomNummer10.Next(1, 44);
                    int randomVlagVier = randomNummer4.Next(10, 190);
                    var alternatiefAntwoordEen = landen.ElementAt(randomVlagTwee);
                    var alternatiefAntwoordTwee = landen.ElementAt(randomVlagDrie);
                    var alternatiefAntwoordDrie = landen.ElementAt(randomVlagVier);
                    textBijAntwoordB.Text = Convert.ToString(alternatiefAntwoordEen);
                    textBijAntwoordC.Text = Convert.ToString(alternatiefAntwoordTwee);
                    textBijAntwoordA.Text = Convert.ToString(alternatiefAntwoordDrie);
                }
                textBijAntwoordD.Text = Convert.ToString(juisteAntwoord);
                textAntwoordCorrect.Text = "";
                textAntwoordInCorrect.Text = "";
                textHoofdstad.Text = "";
                textOppervlakte.Text = "";
                textInwoners.Text = "";
            }
        }

        private void btnAlleVlaggen_Click(object sender, EventArgs e)
        {
            ScoreOutput = 0;
            textScoreOutput.Text = Convert.ToString(ScoreOutput);
            alleVlaggen alleVlaggen = new alleVlaggen();
            alleVlaggen.Show();
        }        

        private void btnAntwoordA_Click(object sender, EventArgs e)
        {
            btnVolgendeVlag.Enabled = true;
            btnAntwoordA.Enabled = false;
            btnAntwoordB.Enabled = false;
            btnAntwoordC.Enabled = false;
            btnAntwoordD.Enabled = false;

            if (randomPlaatsingText == 1)
            {
                textAntwoordCorrect.ForeColor = Color.Lime;
                textAntwoordCorrect.Text = "Dat is goed!";
                textAntwoordInCorrect.Text = "";
                ScoreOutput++;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);

                List<string> hoofdsteden = File.ReadAllLines(@"Hoofdsteden.txt").ToList();
                var hoofdstad = hoofdsteden.ElementAt(randomVlag);
                string hoofdstadText = Convert.ToString(hoofdstad);
                textHoofdstad.Text = "De hoofdstad van dit land is " + hoofdstadText;

                List<string> alleOppervlakten = File.ReadAllLines(@"Oppervlakte.txt").ToList();
                var oppervlakte = alleOppervlakten.ElementAt(randomVlag);
                string oppervlakteText= Convert.ToString(oppervlakte);
                textOppervlakte.Text = "De oppervlakte is ongeveer " + oppervlakteText + " km2";

                List<string> alleInwoners = File.ReadAllLines(@"Inwoners.txt").ToList();
                var inwoners = alleInwoners.ElementAt(randomVlag);
                string inwonersText = Convert.ToString(inwoners);
                textInwoners.Text = "Het aantal inwoners is ongeveer " + inwonersText;
            }
            else
            {
                textAntwoordInCorrect.Text = "Dat is niet goed";
                HighScoreOutput = Convert.ToInt32(textHighScoreOutput.Text);
                if (HighScoreOutput < ScoreOutput)
                {
                    textHighScoreOutput.Text = Convert.ToString(ScoreOutput);
                }

                List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
                var juisteAntwoord = landen.ElementAt(randomVlag);

                textToelichtingJuisteAntwoord.Text = "Dit is de vlag van " + juisteAntwoord;

                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);

            }
        }

        private void btnAntwoordB_Click(object sender, EventArgs e)
        {
            btnVolgendeVlag.Enabled = true;
            btnAntwoordA.Enabled = false;
            btnAntwoordB.Enabled = false;
            btnAntwoordC.Enabled = false;
            btnAntwoordD.Enabled = false;

            if (randomPlaatsingText == 2)
            {
                textAntwoordCorrect.ForeColor = Color.Lime;
                textAntwoordCorrect.Text = "Dat is goed!";
                textAntwoordInCorrect.Text = "";
                ScoreOutput++;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);

                List<string> hoofdsteden = File.ReadAllLines(@"Hoofdsteden.txt").ToList();
                var hoofdstad = hoofdsteden.ElementAt(randomVlag);
                string hoofdstadText = Convert.ToString(hoofdstad);
                textHoofdstad.Text = "De hoofdstad van dit land is " + hoofdstadText;

                List<string> alleOppervlakten = File.ReadAllLines(@"Oppervlakte.txt").ToList();
                var oppervlakte = alleOppervlakten.ElementAt(randomVlag);
                string oppervlakteText = Convert.ToString(oppervlakte);
                textOppervlakte.Text = "De oppervlakte is ongeveer " + oppervlakteText + " km2";

                List<string> alleInwoners = File.ReadAllLines(@"Inwoners.txt").ToList();
                var inwoners = alleInwoners.ElementAt(randomVlag);
                string inwonersText = Convert.ToString(inwoners);
                textInwoners.Text = "Het aantal inwoners is ongeveer " + inwonersText;
            }
            else
            {
                textAntwoordInCorrect.Text = "Dat is niet goed";
                HighScoreOutput = Convert.ToInt32(textHighScoreOutput.Text);
                if (HighScoreOutput < ScoreOutput)
                {
                    textHighScoreOutput.Text = Convert.ToString(ScoreOutput);
                }

                List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
                var juisteAntwoord = landen.ElementAt(randomVlag);

                textToelichtingJuisteAntwoord.Text = "Dit is de vlag van " + juisteAntwoord;

                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
        }

        private void btnAntwoordC_Click(object sender, EventArgs e)
        {
            btnVolgendeVlag.Enabled = true;
            btnAntwoordA.Enabled = false;
            btnAntwoordB.Enabled = false;
            btnAntwoordC.Enabled = false;
            btnAntwoordD.Enabled = false;

            if (randomPlaatsingText == 3)
            {
                textAntwoordCorrect.ForeColor = Color.Lime;
                textAntwoordCorrect.Text = "Dat is goed!";
                textAntwoordInCorrect.Text = "";
                ScoreOutput++;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);

                List<string> hoofdsteden = File.ReadAllLines(@"Hoofdsteden.txt").ToList();
                var hoofdstad = hoofdsteden.ElementAt(randomVlag);
                string hoofdstadText = Convert.ToString(hoofdstad);
                textHoofdstad.Text = "De hoofdstad van dit land is " + hoofdstadText;

                List<string> alleOppervlakten = File.ReadAllLines(@"Oppervlakte.txt").ToList();
                var oppervlakte = alleOppervlakten.ElementAt(randomVlag);
                string oppervlakteText = Convert.ToString(oppervlakte);
                textOppervlakte.Text = "De oppervlakte is ongeveer " + oppervlakteText + " km2";

                List<string> alleInwoners = File.ReadAllLines(@"Inwoners.txt").ToList();
                var inwoners = alleInwoners.ElementAt(randomVlag);
                string inwonersText = Convert.ToString(inwoners);
                textInwoners.Text = "Het aantal inwoners is ongeveer " + inwonersText;
            }
            else
            {
                textAntwoordInCorrect.Text = "Dat is niet goed";
                HighScoreOutput = Convert.ToInt32(textHighScoreOutput.Text);
                if (HighScoreOutput < ScoreOutput)
                {
                    textHighScoreOutput.Text = Convert.ToString(ScoreOutput);
                }

                List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
                var juisteAntwoord = landen.ElementAt(randomVlag);

                textToelichtingJuisteAntwoord.Text = "Dit is de vlag van " + juisteAntwoord;

                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
        }

        private void btnAntwoordD_Click(object sender, EventArgs e)
        {
            btnVolgendeVlag.Enabled = true;
            btnAntwoordA.Enabled = false;
            btnAntwoordB.Enabled = false;
            btnAntwoordC.Enabled = false;
            btnAntwoordD.Enabled = false;

            if (randomPlaatsingText == 4)
            {
                textAntwoordCorrect.ForeColor = Color.Lime;
                textAntwoordCorrect.Text = "Dat is goed!";
                textAntwoordInCorrect.Text = "";
                ScoreOutput++;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);

                List<string> hoofdsteden = File.ReadAllLines(@"Hoofdsteden.txt").ToList();
                var hoofdstad = hoofdsteden.ElementAt(randomVlag);
                string hoofdstadText = Convert.ToString(hoofdstad);
                textHoofdstad.Text = "De hoofdstad van dit land is " + hoofdstadText;

                List<string> alleOppervlakten = File.ReadAllLines(@"Oppervlakte.txt").ToList();
                var oppervlakte = alleOppervlakten.ElementAt(randomVlag);
                string oppervlakteText = Convert.ToString(oppervlakte);
                textOppervlakte.Text = "De oppervlakte is ongeveer " + oppervlakteText + " km2";

                List<string> alleInwoners = File.ReadAllLines(@"Inwoners.txt").ToList();
                var inwoners = alleInwoners.ElementAt(randomVlag);
                string inwonersText = Convert.ToString(inwoners);
                textInwoners.Text = "Het aantal inwoners is ongeveer " + inwonersText;
            }
            else
            {
                textAntwoordInCorrect.Text = "Dat is niet goed";
                HighScoreOutput = Convert.ToInt32(textHighScoreOutput.Text);
                if (HighScoreOutput < ScoreOutput)
                {
                    textHighScoreOutput.Text = Convert.ToString(ScoreOutput);
                }

                List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
                var juisteAntwoord = landen.ElementAt(randomVlag);

                textToelichtingJuisteAntwoord.Text = "Dit is de vlag van " + juisteAntwoord;

                ScoreOutput = 0;
                textScoreOutput.Text = Convert.ToString(ScoreOutput);
            }
        }

        private void textOpeningsTekst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
