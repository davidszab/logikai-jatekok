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
        public Statisztika()
        {
            InitializeComponent();
        }
    }
    
}
