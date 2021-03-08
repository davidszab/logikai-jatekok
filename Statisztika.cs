using System;
using System.Collections.Generic;
using System.IO;
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
            HTML,
            CSV
        }
        private LekerdezesAlap lekerdezesAlap;
        private Szures szures;
        private Kimenet kimenet;
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
                    cBCel.Items.Clear();
                    cBCel.Items.Add("Akasztófa");
                    cBCel.Items.Add("Mastermind");
                    cBCel.Items.Add("Aknakereső");
                    cBCel.SelectedIndex = 0;
                    break;
                case LekerdezesAlap.Jatekos:
                    lbCel.Text = "Játékos:";
                    cBCel.Items.Clear();
                    List<string> jatekosok = Program.database.GetPlayers();
                    foreach (string item in jatekosok)
                    {
                        cBCel.Items.Add(item);
                    }
                    cBCel.SelectedIndex = 0;
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
            else if (rBCSV.Checked)
                kimenet = Kimenet.CSV;
        }
        private void kimenetKepernyo(List<List<object>> eredmeny)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            List<string> fejlec = oszlopFejlec();
            for (int i = 0; i < eredmeny[0].Count; i++)
            {
                DataGridViewTextBoxColumn oszlop = new DataGridViewTextBoxColumn();
                oszlop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                oszlop.HeaderText = fejlec[i];
                oszlop.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns.Add(oszlop);
            }
            for (int i = 0; i < eredmeny.Count; i++)
            {
                dataGridView1.Rows.Add(eredmeny[i].ToArray());
                dataGridView1.Rows[i].HeaderCell.Value = $"{i + 1}.";
            }
        }
        private void kimenetHTML(List<List<object>> eredmeny)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "export";
            fileDialog.DefaultExt = "html";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "Egyfájlos weboldal | *.html";
            DialogResult fajlStatusz = fileDialog.ShowDialog();
            if (fajlStatusz == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                DateTime most = (DateTime)Program.database.SingleValue("SELECT NOW()");
                writer.Write(htmlBuilder(cimBuilder(), Program.player, most.ToString(), eredmeny));
                writer.Close();
                MessageBox.Show("Az exportálás sikeresen megtörtént!", "Exportálás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Az exportálás megszakítva!", "Exportálás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private string cimBuilder()
        {
            string cim = "";
            if (lekerdezesAlap == LekerdezesAlap.Rekord)
                cim += "Rekordok – játékonként";
            else
            {
                cim += $"{cBCel.SelectedItem} – ";
                if (szures == Szures.Osszes)
                    cim += "előzmények";
                else if (szures == Szures.Legjobb)
                    cim += "legjobb eredmények";
            }
            return cim;
        }
        private string htmlBuilder(string cim, string keszito, string keszult, List<List<object>> eredmeny)
        {
            string htmlString = "<!DOCTYPE html><html lang=\"hu\"><head> <meta charset=\"UTF-8\"> <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <style>*{box-sizing: border-box;}body{margin: 0; font-family: sans-serif; background-color: #40798cff; color: white;}.content{width: 80%; height: 100vh; max-width: 850px; margin: 0 auto; padding: 1rem;}.title-box h1,h4{margin: 0.25rem; font-weight: normal; text-transform: uppercase;}.highlight{color: #fcff4d; font-weight: bold;}.table-box{margin-top: 2rem;}table{border: 1px solid white; border-collapse: collapse; width: 100%;}th{text-align: left;}th,td{border: 1px solid white; padding: 0.25rem;}@media print{body{color: black; background-color: white;}.content{margin: 0 0; width: 100%;}.highlight{color: black;}table, th, td{border: 1px solid black;}}</style> <title>";
            htmlString += $"{cim}</title>";
            htmlString += $"</head><body><div class=\"content\"><div class=\"title-box\"><h1>{cim}</h1> <hr> <h4>készítette: <span class=\"highlight\">{keszito}</span>, készült: <span class=\"highlight\">{keszult}</span></h4> </div>";
            htmlString += "<div class=\"table-box\"><table><thead><tr>";
            List<string> fejlec = oszlopFejlec();
            fejlec.Insert(0, "#");
            foreach (string felirat in fejlec)
            {
                htmlString += $"<th>{felirat}</th>";
            }
            htmlString += "</tr></thead><tbody>";
            for (int i = 0; i < eredmeny.Count; i++)
            {
                List<object> sor = eredmeny[i];
                htmlString += $"<tr><td>{i + 1}</td>";
                foreach (var item in sor)
                {
                    htmlString += $"<td>{item}</td>";
                }
                htmlString += "</tr>";
            }
            htmlString += "</tbody> </table> </div></div></body></html>";
            return htmlString;
        }
        private void kimenetCSV(List<List<object>> eredmeny)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.FileName = "export";
            fileDialog.DefaultExt = "csv";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "CSV (pontosvesszővel tagolt, UTF-8) | *.csv";
            DialogResult fajlStatusz = fileDialog.ShowDialog();
            if (fajlStatusz == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                StreamWriter writer = new StreamWriter(path);
                writer.WriteLine(string.Join(";", oszlopFejlec()));
                for (int i = 0; i < eredmeny.Count; i++)
                {
                    writer.WriteLine(string.Join(";", eredmeny[i]));
                }
                writer.Close();
                MessageBox.Show("Az exportálás sikeresen megtörtént!", "Exportálás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Az exportálás megszakítva!", "Exportálás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void lekerdezes()
        {
            string sql = lekerdezesKeszito();
            if (sql.Length > 0)
            {
                List<List<object>> eredmeny = Program.database.Query(sql);
                if (kimenet == Kimenet.Kepernyo)
                    kimenetKepernyo(eredmeny);
                else if (kimenet == Kimenet.HTML)
                    kimenetHTML(eredmeny);
                else if (kimenet == Kimenet.CSV)
                    kimenetCSV(eredmeny);
            }
        }
        private List<string> oszlopFejlec()
        {
            if (lekerdezesAlap == LekerdezesAlap.Jatek)
                return new List<string>() { "Játékos", "Pontszám", "Időpont" };
            if (lekerdezesAlap == LekerdezesAlap.Jatekos)
                return new List<string>() { "Játék", "Pontszám", "Időpont" };
            else
                return new List<string>() { "Játék", "Játékos", "Pontszám", "Időpont" };
        }
        private string lekerdezesKeszito()
        {
            if (lekerdezesAlap == LekerdezesAlap.Jatek)
            {
                int jatekID = cBCel.SelectedIndex + 1;
                if (jatekID == 0)
                    return "";
                if (szures == Szures.Osszes)
                    return $"SELECT name, points, date FROM logicgames.score INNER JOIN logicgames.player ON score.player_id = player.player_id WHERE game_id = {jatekID} ORDER BY date; ";
                if (szures == Szures.Legjobb)
                    return $"SELECT name, MAX(points) max_points, date FROM logicgames.score INNER JOIN logicgames.player ON player.player_id = score.player_id WHERE game_id = {jatekID} GROUP BY score.player_id, game_id ORDER BY max_points DESC";
            }
            if (lekerdezesAlap == LekerdezesAlap.Jatekos)
            {
                string jatekos = (string)cBCel.SelectedItem;
                if (szures == Szures.Osszes)
                    return $"SELECT game.name, points, date FROM logicgames.score INNER JOIN logicgames.player ON score.player_id = player.player_id INNER JOIN logicgames.game ON score.game_id = game.game_id WHERE player.name = \"{jatekos}\" ORDER BY date; ";
                if (szures == Szures.Legjobb)
                    return $"SELECT game.name, points, date FROM logicgames.score INNER JOIN(SELECT game_id, MAX(points) max_points FROM logicgames.score INNER JOIN logicgames.player ON score.player_id = player.player_id WHERE name = \"{jatekos}\" GROUP BY game_id) m ON score.points = m.max_points INNER JOIN logicgames.game ON score.game_id = game.game_id ORDER BY score.game_id; ";
            }
            if (lekerdezesAlap == LekerdezesAlap.Rekord)
            {
                return "SELECT game.name, player.name, points, date FROM logicgames.score INNER JOIN(SELECT score.game_id, MAX(score.points) max_points FROM logicgames.score GROUP BY score.game_id) m ON m.max_points = score.points INNER JOIN logicgames.player ON player.player_id = score.player_id INNER JOIN logicgames.game ON score.game_id = game.game_id ORDER BY score.game_id; ";
            }
            return "";
        }
        public Statisztika()
        {
            InitializeComponent();
            rBJatek.Checked = true;
            rBOsszes.Checked = true;
            rBKepernyo.Checked = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lekerdezes();
        }
    }

}
