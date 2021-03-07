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
    public partial class Statisztika : Form
    {
        private enum LekerdezesAlap
        {
            Jatek,
            Jatekos,
            Rekord
        }
        private enum Szures
        {
            Osszes,
            Legjobb
        }

        private enum Kimenet
        {
            Kepernyo,
            HTML
        }
        private LekerdezesAlap lekerdezesAlap = LekerdezesAlap.Jatek;
        private Szures szures = Szures.Osszes;
        private Kimenet kimenet = Kimenet.Kepernyo;
        private void handleLekerdezesAlapChange(object sender, EventArgs e)
        {
            if (rBJatek.Checked)
                lekerdezesAlap = LekerdezesAlap.Jatek;
            else if (rBJatekos.Checked)
                lekerdezesAlap = LekerdezesAlap.Jatekos;
            else if (rBRekord.Checked)
                lekerdezesAlap = LekerdezesAlap.Rekord;

            fLP_szuro.Enabled = lekerdezesAlap != LekerdezesAlap.Rekord;
            fLP_cel.Enabled = fLP_szuro.Enabled;

            switch (lekerdezesAlap)
            {
                case LekerdezesAlap.Jatek:
                    lbCel.Text = "Játék:";
                    break;
                case LekerdezesAlap.Jatekos:
                    lbCel.Text = "Játékos:";
                    break;
            }
        }
        private void handleSzuresChange(object sender, EventArgs e)
        {
            if (rBOsszes.Checked)
                szures = Szures.Osszes;
            else if (rBLegjobb.Checked)
                szures = Szures.Legjobb;
        }
        private void handleKimenetChange(object sender, EventArgs e)
        {
            if (rBKepernyo.Checked)
                kimenet = Kimenet.Kepernyo;
            else if (rBHtml.Checked)
                kimenet = Kimenet.HTML;
        }
        private string lekerdezesKeszito()
        {
            if(lekerdezesAlap == LekerdezesAlap.Jatek)
            {
                if (szures == Szures.Osszes)
                    return $"SELECT name, points FROM logicgames.score INNER JOIN player ON score.player_id = player.player_id WHERE game_id = 1;";
                if (szures == Szures.Legjobb)
                    return $"SELECT name, MAX(points) FROM logicgames.score INNER JOIN player ON score.player_id = player.player_id WHERE game_id = 1 GROUP BY name ORDER BY 2 DESC;";
            }
            if(lekerdezesAlap == LekerdezesAlap.Jatekos)
            {
                if(szures == Szures.Osszes)
                    return $"SELECT game_id, points FROM score INNER JOIN player ON score.player_id = player.player_id WHERE name = \"Játékos 1\";";
                if (szures == Szures.Legjobb)
                    return $"SELECT game_id, MAX(points) FROM score INNER JOIN player ON player.player_id = score.player_id WHERE player.name = \"Játékos 5\" GROUP BY game_id ORDER BY game_id;";
            }
            if(lekerdezesAlap == LekerdezesAlap.Rekord)
            {
                return "SELECT score.game_id, name, points FROM logicgames.score INNER JOIN(SELECT score.game_id, MAX(score.points) max_points FROM logicgames.score GROUP BY score.game_id) m ON m.max_points = score.points INNER JOIN player ON player.player_id = score.player_id ORDER BY score.game_id";
            }
            return "";
        }
        public Statisztika()
        {
            InitializeComponent();
        }
    }
    
}
