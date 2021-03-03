using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logikai_jatekok
{
    static class Program
    {
        static public string player = "Balint";
        static public GameDatabase database = new GameDatabase("datas/data.txt", false);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool playagain = true;
            while (playagain)
            {
                MinesweeperForm minesweeper = new MinesweeperForm();
                Application.Run(minesweeper);

                playagain = minesweeper.playagain;
            }
        }
    }
}
