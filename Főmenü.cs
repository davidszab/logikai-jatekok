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
            l_szervercim.Visible = false;
            l_felhasznalonev.Visible = false;
            l_jelszo.Visible = false;
            l_portszam.Visible = false;
            tb_szervercim.Visible = false;
            tb_felhasznalonev.Visible = false;
            tb_jelszo.Visible = false;
            tb_portszam.Visible = false;
        }
    }
}
