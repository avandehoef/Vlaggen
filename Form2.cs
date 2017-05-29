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
    public partial class alleVlaggen : Form
    {
                
        public alleVlaggen()
        {
            InitializeComponent();               
        }              
        // automatisch gegenereerd overzicht van alle vlaggen in resources

        private void alleVlaggen_Load(object sender, EventArgs e)
        {
            int nummerElement; // de zoveelste vlag vanuit resources en de corresponderende landnaam
            int positieHorizontaal = 10; //startpositie horizontaal vanuit de kantlijn voor zowel de vlaggen als de landnamen                        
            int positieVerticaalText = 110; // verticale positie van de text (deze is 10pt onder de vlagafbeelding (10pt start positie en 90 pt maximum hoogte van de vlag)                        
            int positieVerticaalVlag = 10; // startpositie verticaal van de vlaggen
            int afstand = 160; // de maximale hoogte van de vlag (90) + de maximale hoogte van de textbox (60) + 10pt zodat het er mooi uitziet

            for (nummerElement = 1; nummerElement <=197; nummerElement++)
            {
                if (nummerElement < 197)
                {
                    PictureBox vlag = new PictureBox();
                    vlag.Location = new Point(positieHorizontaal, positieVerticaalVlag);
                    vlag.Width = 160;
                    vlag.Height = 90;
                    vlag.SizeMode = PictureBoxSizeMode.Zoom;
                    vlag.Visible = true;
                    vlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + nummerElement);
                    Controls.Add(vlag);
                    
                    TextBox land = new TextBox();
                    land.Location = new Point(positieHorizontaal, positieVerticaalText);
                    land.Width = 160;
                    land.Height = 60;
                    land.Visible = true;
                    land.Font = new Font("Calibri", 9);
                    land.TextAlign = HorizontalAlignment.Center;
                    land.Multiline = true;
                    land.BackColor = Color.LightGray;
                    land.BorderStyle = BorderStyle.None;
                    Controls.Add(land);

                    List<string> landen = File.ReadAllLines(@"InfoLanden.txt").ToList();
                    var landOutput = landen.ElementAt(nummerElement);
                    land.Text = Convert.ToString(landOutput);

                    positieHorizontaal = positieHorizontaal + 170;

                    if (positieHorizontaal > 1360)
                    {
                        positieVerticaalText = positieVerticaalText + afstand;
                        positieVerticaalVlag = positieVerticaalVlag + afstand;
                        positieHorizontaal = 10;
                    }
                }
            }
        }
    }
}
