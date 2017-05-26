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
using System.Xml;
using System.Reflection;

namespace Vlaggen
{
    public partial class vlag : Form
    {
        
            

    public vlag()
        {
            InitializeComponent();
        }


        Image[] imagesVlaggenArray = new Image[197];
        int ScoreOutput = 0;

        Random randomNummer1 = new Random();
        Random randomNummer2 = new Random();
        Random randomNummer3 = new Random();
        Random randomNummer4 = new Random();
        Random randomNummer5 = new Random();

        private void pictureVlag_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStartOpnieuw_Click(object sender, EventArgs e)
        {
            int randomVlag = randomNummer1.Next(1, 197);
            int corresponderendeRandomLand = randomVlag;
            pictureVlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + randomVlag);

            List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
            var ding = landen.ElementAt(corresponderendeRandomLand);
            textBijAntwoordA.Text = Convert.ToString(ding);
            ScoreOutput = 0;
            textScoreOutput.Text = Convert.ToString(ScoreOutput);
        }

        private void btnAntwoordC_Click(object sender, EventArgs e)
        {

        }

        private void btnAntwoordD_Click(object sender, EventArgs e)
        {

        }

        private void btnVolgendeVlag_Click(object sender, EventArgs e)
        {                       
            int randomVlag = randomNummer1.Next(1, 197);
            int corresponderendeRandomLand = randomVlag;
            pictureVlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + randomVlag);

            List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
            var ding = landen.ElementAt(corresponderendeRandomLand);
            textBijAntwoordA.Text = Convert.ToString(ding);
            ScoreOutput = ScoreOutput + 1;
            textScoreOutput.Text = Convert.ToString(ScoreOutput);

        }

        private void btnAlleVlaggen_Click(object sender, EventArgs e)
        {
            alleVlaggen alleVlaggen = new alleVlaggen();
            alleVlaggen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
