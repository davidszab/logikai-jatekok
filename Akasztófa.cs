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

namespace logikai_jatekok
{
    public partial class Akasztófa : Form
    {
        public Akasztófa()
        {
            InitializeComponent();
            Beolvasás();
            SzóKiválaszt();
            GombHozzáad();
            LabelsHozzáad();
        }
        public string[] szavak;
        public string[] alapbetuk = {"A","Á","B","C","D","E","É","F","G","H","I","Í","J","K","L","M","N","O",
            "Ó","Ö","Ő","P","Q","R","S","T","U","Ú","Ü","Ű","V","W","X","Y","Z"};
        public string aktszo;
        public List<Label> labels = new List<Label>();
        public Random random = new Random();
        public enum HangState
        {
            Üres, Alap, FüggOszlop, VizOszlop, Kötél, Fej, Test, BalKar, BalKéz, JobbKar, JobbKéz, BalLáb, Jobbláb
        }
        public HangState AktHangState = HangState.Üres;
        public HangState HangStateSize = HangState.Jobbláb;
        public void Beolvasás()
        {
            string[] sorok = File.ReadAllLines("szavak.txt");
            szavak = new string[sorok.Length];
            for (int i = 0; i < szavak.Length; i++)
            {
                szavak[i] = sorok[i].ToUpper();
            }
        }
        private void SzóKiválaszt()
        {
            int r = random.Next(0, szavak.Length);
            aktszo = szavak[r];
        }
        private void GombHozzáad()
        {
            for (int i = 0; i < alapbetuk.Length; i++)
            {
                Button b = new Button();
                b.Text = alapbetuk[i];
                b.Parent = flp_buttons;
                b.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                b.Size = new Size(30, 30);
                b.BackColor = Color.Lavender;
                b.Click += B_Click;
            }
        }
        private void LabelsHozzáad()
        {
            gb_kitalalndo.Controls.Clear();
            labels.Clear();
            char[] letters = aktszo.ToCharArray();
            int hossz = letters.Length;
            int hely = gb_kitalalndo.Width / hossz;
            for (int i = 0; i < hossz; i++)
            {
                Label l = new Label();
                l.Text = " __ ";
                l.Location = new Point(10 + i * hely, gb_kitalalndo.Height - 30);
                l.Parent = gb_kitalalndo;
                l.BringToFront();
                labels.Add(l);
            }
            l_szohossz.Text = "A szó hossza: " + Convert.ToString(hossz);
            l_hibalehetoseg.Text = "Hibalehetőség: " + Convert.ToInt32(HangStateSize);
        }
        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            char betuclicked = b.Text.ToCharArray()[0];
            b.Enabled = false;

            if ((aktszo = aktszo.ToUpper()).Contains(betuclicked))
            {
                l_info.Text = "Fantasztikus!";
                l_info.ForeColor = Color.DarkGreen;
                char[] betuk = aktszo.ToCharArray();
                for (int i = 0; i < aktszo.Length; i++)
                {
                    if (betuk[i] == betuclicked)
                    {
                        labels[i].Text = betuclicked.ToString();
                        labels[i].Font = new Font(FontFamily.GenericSansSerif, 14);
                    }
                }
                if (labels.Where(x => x.Text.Equals(" __ ")).Any())
                {
                    return;
                }
                l_info.Text = "Gratulálok! Nyertél! :)";
                l_info.ForeColor = Color.DarkGreen;
                flp_buttons.Enabled = false;
                flp_word.Enabled = false;
            }
            else
            {
                l_info.Text = "Nem jó!";
                l_info.ForeColor = Color.DarkRed;
                if (AktHangState != HangState.Jobbláb)
                {
                    AktHangState++;
                }
                l_hibalehetoseg.Text = "Hibalehetőség: " + Convert.ToInt32(HangStateSize - AktHangState);
                tb_rosszvalaszok.Text += betuclicked.ToString() + ", ";
                if (AktHangState == HangState.Jobbláb)
                {
                    l_info.Text = "Vesztettél!";
                    l_info.ForeColor = Color.DarkRed;
                    flp_buttons.Enabled = false;
                    flp_word.Enabled = false;

                    for (int i = 0; i < aktszo.Length; i++)
                    {
                        if (labels[i].Text.Equals(" __ "))
                        {
                            labels[i].Text = aktszo[i].ToString();
                            labels[i].ForeColor = Color.DarkBlue;
                            labels[i].Font = new Font(FontFamily.GenericSansSerif, 14);
                        }
                    }
                }
            }
        }
        private void p_hangman_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.DarkBlue, 5);
            Graphics g = e.Graphics;
            if (AktHangState >= HangState.Alap)
            {
                //Alap
                g.DrawLine(p, 250, 300, 50, 300);          
            }      
            if (AktHangState >= HangState.FüggOszlop)
            {
                //Függőleges oszlop
                g.DrawLine(p, 200, 300, 200, 25);
            }
            if (AktHangState >= HangState.VizOszlop)
            {
                //Vízszintes oszlop
                g.DrawLine(p, 205, 25, 80, 25);
            }
            if (AktHangState >= HangState.Kötél)
            {
                //Kötél
                g.DrawLine(p, 100, 80, 100, 25);
            }
            if (AktHangState >= HangState.Fej)
            {
                //Fej
                Rectangle fej = new Rectangle(82, 80, 35, 35);
                g.DrawEllipse(p, fej);
            }
            if (AktHangState >= HangState.Test)
            {
                //Test
                g.DrawLine(p, 100, 117, 100, 190);
            }
            if (AktHangState >= HangState.BalKar)
            {
                //Bal kar
                g.DrawLine(p, 100, 120, 75, 170);
            }
            if (AktHangState >= HangState.BalKéz)
            {
                //Bal kéz
                Rectangle bkez = new Rectangle(70, 170, 5, 5);
                g.DrawEllipse(p, bkez);
            }
            if (AktHangState >= HangState.JobbKar)
            {
                //Jobb kar
                g.DrawLine(p, 100, 120, 125, 170);
            }
            if (AktHangState >= HangState.JobbKéz)
            {
                //Jobb kéz
                Rectangle jkez = new Rectangle(125, 170, 5, 5);
                g.DrawEllipse(p, jkez);
            }
            if (AktHangState >= HangState.BalLáb)
            {
                //Bal láb
                g.DrawLine(p, 100, 185, 80, 250);
            }
            if (AktHangState >= HangState.Jobbláb)
            {
                //Jobb láb
                g.DrawLine(p, 100, 185, 120, 250);
            }
            l_proba.Text = "Próba: " + AktHangState;
        }
        private void b_ujjatek_Click(object sender, EventArgs e)
        {
            flp_buttons.Controls.Clear();
            l_info.Text = " - ";
            tb_rosszvalaszok.Clear();
            flp_buttons.Enabled = true;
            HangStateSize = HangState.Jobbláb;
            AktHangState = HangState.Üres;
            p_hangman.Controls.Clear();
            SzóKiválaszt();
            GombHozzáad();
            LabelsHozzáad();
        }
        private void b_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
