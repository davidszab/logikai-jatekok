using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logikai_jatekok
{
    public partial class Mastermind : Form
    {
        int kodHossz = 4;
        List<Szin> szinek = new List<Szin>()
        {
            new Szin("piros", 'q', Properties.Resources.golyo_piros),
            new Szin("narancs", 'w', Properties.Resources.golyo_narancs),
            new Szin("sárga", 'e', Properties.Resources.golyo_sarga),
            new Szin("zöld", 'r', Properties.Resources.golyo_zold),
            new Szin("kék", 't', Properties.Resources.golyo_kek),
            new Szin("lila", 'z', Properties.Resources.golyo_lila),
            new Szin("fekete", 'u', Properties.Resources.golyo_fekete),
            new Szin("fehér", 'i', Properties.Resources.golyo_feher)
        };
        List<Szin> kod = new List<Szin>();
        List<List<Szin>> probalkozasok = new List<List<Szin>>();
        private void szinTablazat()
        {
            tLP_szinek.SuspendLayout();
            int megjDb = szinek.Count(e => !e.isElrejtett);
            tLP_szinek.Controls.Clear();
            if (megjDb != 0)
            {
                float magassag = (float)Math.Floor((double)tLP_szinek.Height / megjDb);
                tLP_szinek.RowStyles.Clear();
                int megjCounter = 0;
                for (int i = 0; i < szinek.Count; i++)
                {
                    Szin szin = szinek[i];
                    if (!szin.isElrejtett)
                    {
                        tLP_szinek.RowCount = tLP_szinek.RowCount + 1;
                        tLP_szinek.RowStyles.Add(new RowStyle(SizeType.Absolute, magassag));
                        PictureBox kep = new PictureBox() { Image = szin.kep, SizeMode = PictureBoxSizeMode.Zoom, Anchor = AnchorStyles.None };
                        kep.Click += (object sender, EventArgs args) => szinKivalasztas(szin);
                        tLP_szinek.Controls.Add(kep, 0, megjCounter);
                        tLP_szinek.Controls.Add(new Label() { Text = szin.nev, Anchor = AnchorStyles.None, TextAlign = ContentAlignment.MiddleCenter }, 1, megjCounter);
                        tLP_szinek.Controls.Add(new Label() { Text = szin.billentyuKod.ToString(), Anchor = AnchorStyles.None, TextAlign = ContentAlignment.MiddleCenter }, 2, megjCounter);
                        CheckBox checkBox = new CheckBox() { Checked = true, Anchor = AnchorStyles.None, CheckAlign = ContentAlignment.MiddleCenter };
                        int index = i;
                        checkBox.CheckedChanged += (object sender, EventArgs args) => handleElrejtes(index);
                        tLP_szinek.Controls.Add(checkBox, 3, megjCounter);
                        megjCounter++;
                    }
                }
            }
            tLP_szinek.ResumeLayout();
        }
        private void handleElrejtes(int index)
        {
            szinek[index].isElrejtett = true;
            szinTablazat();
            int rejtettDb = szinek.Count(e => e.isElrejtett);
            lbRejtett.Text = $"Elrejtett színek száma: {rejtettDb} db";
        }
        private void handleTorles()
        {
            List<Szin> aktualisProbalkozas = probalkozasok.Last();
            int hossz = aktualisProbalkozas.Count;
            if (hossz < kodHossz && hossz > 0)
            {
                aktualisProbalkozas.RemoveAt(hossz - 1);
                tLP_Tabla.Controls.RemoveAt(tLP_Tabla.Controls.Count - 1);
            }
            if (aktualisProbalkozas.Count == 0)
                btnTorles.Enabled = false;
        }
        private void kodGeneralas()
        {
            Random random = new Random();
            List<int> indexek = new List<int>();
            while (indexek.Count < kodHossz)
            {
                int szam = random.Next(0, szinek.Count);
                if (!indexek.Contains(szam))
                    indexek.Add(szam);
            }
            foreach (int index in indexek)
            {
                kod.Add(szinek[index]);
            }
        }
        private void Mastermind_KeyPress(object sender, KeyPressEventArgs e)
        {
            char lenyomottKarakter = e.KeyChar;
            if (lenyomottKarakter == (char)8)
                handleTorles();
            else
            {
                Szin kivSzin = szinek.Find(element => element.billentyuKod == lenyomottKarakter);
                if (kivSzin != null)
                    szinKivalasztas(kivSzin);
            }

        }
        private void szinKivalasztas(Szin szin)
        {
            if (probalkozasok.Count == 0)
                probalkozasok.Add(new List<Szin>());
            int sorozatSz = probalkozasok.Count - 1;
            List<Szin> aktualisProbalkozas = probalkozasok[sorozatSz];
            if (aktualisProbalkozas.Count < kodHossz && !aktualisProbalkozas.Contains(szin))
            {
                aktualisProbalkozas.Add(szin);
                PictureBox golyo = new PictureBox()
                { Image = szin.kep, Width = 50, Height = 50, SizeMode = PictureBoxSizeMode.Zoom };
                tLP_Tabla.Controls.Add(golyo);
                if (aktualisProbalkozas.Count == 4)
                {
                    btnTorles.Enabled = false;
                    ertekeles();
                }
                else
                {
                    btnTorles.Enabled = true;
                }
            }
        }
        private TableLayoutPanel ertekeloMezo(int fekete, int feher)
        {
            TableLayoutPanel tabla = new TableLayoutPanel() { CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, Height = 40, Width = 40 };
            tabla.Margin = new Padding(0);
            tabla.RowStyles.Clear();
            tabla.ColumnStyles.Clear();
            tabla.RowCount = 2;
            tabla.AutoSize = false;
            tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            int oszlopSzam = (int)Math.Ceiling((double)(fekete + feher) / 2);
            oszlopSzam = oszlopSzam < 2 ? 2 : oszlopSzam;
            tabla.ColumnCount = oszlopSzam;
            for (int i = 0; i < oszlopSzam; i++)
            {
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            }
            for (int i = 0; i < fekete; i++)
            {
                PictureBox golyo = new PictureBox() { Image = Properties.Resources.golyo_fekete, SizeMode = PictureBoxSizeMode.Zoom };
                tabla.Controls.Add(golyo);
            }
            for (int i = 0; i < feher; i++)
            {
                PictureBox golyo = new PictureBox() { Image = Properties.Resources.golyo_feher, SizeMode = PictureBoxSizeMode.Zoom };
                tabla.Controls.Add(golyo);
            }
            return tabla;
        }
        private void ertekeles()
        {
            int fekete = 0;
            int feher = 0;
            List<Szin> probalkozas = probalkozasok.Last();
            for (int i = 0; i < probalkozas.Count; i++)
            {
                if (kod[i] == probalkozas[i])
                    fekete++;
                else if (kod.Contains(probalkozas[i]))
                    feher++;
            }
            fLP_ertekeles.Controls.Add(ertekeloMezo(fekete, feher));
            if (fekete == 4)
                MessageBox.Show("Gratulálok, teljesítetted a játékot!");
            else if (probalkozasok.Count < 10)
                probalkozasok.Add(new List<Szin>());
            else
                MessageBox.Show($"Játék vége! A kód: {kod[0].nev}, {kod[1].nev}, {kod[2].nev}, {kod[3].nev}");
        }
        public Mastermind()
        {
            InitializeComponent();
            szinTablazat();
            kodGeneralas();
        }

        private void btnRejtettVissza_Click(object sender, EventArgs e)
        {
            foreach (Szin item in szinek)
            {
                item.isElrejtett = false;
            }
            lbRejtett.Text = "Elrejtett színek száma: 0 db";
            szinTablazat();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            handleTorles();
        }
    }
    class Szin
    {
        public readonly string nev;
        public readonly char billentyuKod;
        public readonly Image kep;
        public bool isElrejtett;
        public Szin(string nev, char billentyuKod, Image kep)
        {
            this.nev = nev;
            this.billentyuKod = billentyuKod;
            this.kep = kep;
            isElrejtett = false;
        }
    }
}