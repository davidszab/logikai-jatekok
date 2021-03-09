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
    public partial class Főmenü : Form
    {
        public Főmenü()
        {
            InitializeComponent();
        }

        private void Főmenü_Load(object sender, EventArgs e)
        {
            bool adatbazis = Program.database.ConfigFileExists;
            if (adatbazis)
            {
                panel_szerver.Visible = false;
                Program.database.ConnectToDatabase();
                List<string> jatekosok = Program.database.GetPlayers();
                foreach (var item in jatekosok)
                {
                    cb_jatekosneve.Items.Add(item);
                }
                cb_jatekosneve.SelectedItem = Program.player;
            } 
        }

        private void b_mentes_Click(object sender, EventArgs e)
        {
            panel_szerver.Visible = false;
            string szerver = tb_szervercim.Text;
            string felhasznev = tb_felhasznalonev.Text;
            string jelszo = tb_jelszo.Text;
            string portszam = tb_portszam.Text;
            Program.database.CreateConfigFile(szerver, felhasznev, portszam, jelszo);
            Program.database.ConnectAndSetUpNewDB();
        }

        private void b_aknakereso_Click(object sender, EventArgs e)
        {
            Program.windowIndex = Windows.MinesweeperWindow;
            this.Close();
        }

        private void b_mastermind_Click(object sender, EventArgs e)
        {
            Program.windowIndex = Windows.MastermindWindow;
            this.Close();
        }

        private void b_akasztofa_Click(object sender, EventArgs e)
        {
            Program.windowIndex = Windows.HangmanWindow;
            this.Close();
        }

        private void b_statisztika_Click(object sender, EventArgs e)
        {
            Program.windowIndex = Windows.StatisticsWindow;
            this.Close();
        }

        private void b_nevmentes_Click(object sender, EventArgs e)
        {
            if (cb_jatekosneve.Text != null && cb_jatekosneve.Text != "")
            {
                string jatekos = cb_jatekosneve.Text;
                if (!cb_jatekosneve.Items.Contains(jatekos))
                {
                    Program.database.AddPlayer(jatekos);
                }
                Program.player = jatekos;
            }
            else MessageBox.Show("Válassz ki vagy írj be egy nevet!");
        }
    }
}
