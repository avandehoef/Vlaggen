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
    public partial class alleVlaggen4 : Form
    {
        public alleVlaggen4()
        {
            InitializeComponent();
        }

        int nr;
        int positieHorizontaal = 10;
        int positieHorizontaalTwee = 10;
        int positieHorizontaalDrie = 10;
        int positieHorizontaalVier = 10;
        int positieHorizontaalVijf = 10;

        int positieVerticaalText = 110;
        int positieVerticaalTextTwee = 270;
        int positieVerticaalTextDrie = 430;
        int positieVerticaalTextVier = 590;
        int positieVerticaalTextVijf = 750;

        int positieVerticaalVlag = 10;
        int positieVerticaalTweeVlag = 170;
        int positieVerticaalDrieVlag = 330;
        int positieVerticaalVierVlag = 490;
        int positieVerticaalVijfVlag = 650;

        private void alleVlaggen4_Load(object sender, EventArgs e)
        {
            for (nr = 121; nr <= 197; nr++)
            {
                if (nr < 129)
                {
                    PictureBox vlag = new PictureBox();
                    vlag.Location = new Point(positieHorizontaal, positieVerticaalVlag);
                    vlag.Width = 160;
                    vlag.Height = 90;
                    vlag.SizeMode = PictureBoxSizeMode.Zoom;
                    vlag.Visible = true;
                    vlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + nr);
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
                    var landOutput = landen.ElementAt(nr);
                    land.Text = Convert.ToString(landOutput);

                    positieHorizontaal = positieHorizontaal + 170;
                }
                else if (nr >= 129 && nr < 137)
                {
                    PictureBox vlag = new PictureBox();
                    vlag.Location = new Point(positieHorizontaalTwee, positieVerticaalTweeVlag);
                    vlag.Width = 160;
                    vlag.Height = 90;
                    vlag.SizeMode = PictureBoxSizeMode.Zoom;
                    vlag.Visible = true;
                    vlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + nr);
                    Controls.Add(vlag);

                    TextBox land = new TextBox();
                    land.Location = new Point(positieHorizontaalTwee, positieVerticaalTextTwee);
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
                    var landOutput = landen.ElementAt(nr);
                    land.Text = Convert.ToString(landOutput);

                    positieHorizontaalTwee = positieHorizontaalTwee + 170;
                }
                else if (nr >= 137 && nr < 145)
                {
                    PictureBox vlag = new PictureBox();
                    vlag.Location = new Point(positieHorizontaalDrie, positieVerticaalDrieVlag);
                    vlag.Width = 160;
                    vlag.Height = 90;
                    vlag.SizeMode = PictureBoxSizeMode.Zoom;
                    vlag.Visible = true;
                    vlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + nr);
                    Controls.Add(vlag);

                    TextBox land = new TextBox();
                    land.Location = new Point(positieHorizontaalDrie, positieVerticaalTextDrie);
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
                    var landOutput = landen.ElementAt(nr);
                    land.Text = Convert.ToString(landOutput);

                    positieHorizontaalDrie = positieHorizontaalDrie + 170;
                }
                else if (nr >= 145 && nr < 153)
                {
                    PictureBox vlag = new PictureBox();
                    vlag.Location = new Point(positieHorizontaalVier, positieVerticaalVierVlag);
                    vlag.Width = 160;
                    vlag.Height = 90;
                    vlag.SizeMode = PictureBoxSizeMode.Zoom;
                    vlag.Visible = true;
                    vlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + nr);
                    Controls.Add(vlag);

                    TextBox land = new TextBox();
                    land.Location = new Point(positieHorizontaalVier, positieVerticaalTextVier);
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
                    var landOutput = landen.ElementAt(nr);
                    land.Text = Convert.ToString(landOutput);

                    positieHorizontaalVier = positieHorizontaalVier + 170;
                }
                else if (nr >= 153 && nr < 161)
                {
                    PictureBox vlag = new PictureBox();
                    vlag.Location = new Point(positieHorizontaalVijf, positieVerticaalVijfVlag);
                    vlag.Width = 160;
                    vlag.Height = 90;
                    vlag.SizeMode = PictureBoxSizeMode.Zoom;
                    vlag.Visible = true;
                    vlag.Image = (Image)Properties.Resources.ResourceManager.GetObject("Vlag" + nr);
                    Controls.Add(vlag);

                    TextBox land = new TextBox();
                    land.Location = new Point(positieHorizontaalVijf, positieVerticaalTextVijf);
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
                    var landOutput = landen.ElementAt(nr);
                    land.Text = Convert.ToString(landOutput);

                    positieHorizontaalVijf = positieHorizontaalVijf + 170;
                }
            }
        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVolgendScherm_Click(object sender, EventArgs e)
        {
            alleVlaggen5 alleVlaggen5 = new alleVlaggen5();
            alleVlaggen5.Show();
            Close();            
        }

        private void btnVorigScherm_Click(object sender, EventArgs e)
        {
            alleVlaggen3 alleVlaggen3 = new alleVlaggen3();
            alleVlaggen3.Show();
            Close();
        }
    }
}
