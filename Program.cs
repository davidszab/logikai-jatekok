using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logikai_jatekok
{
    static class Program
    {
        static public string player;
        static public Windows windowIndex = Windows.MainWindow;
        static public GameDatabase database;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                switch (windowIndex)
                {
                    case Windows.MainWindow:
                        Application.Run(new Form1());
                        break;

                    case Windows.HangmanWindow:
                        Application.Run(new Akasztófa());
                        windowIndex = Windows.MainWindow;
                        break;

                    case Windows.MastermindWindow:
                        Application.Run(new Mastermind());
                        windowIndex = Windows.MainWindow;
                        break;

                    case Windows.MinesweeperWindow:
                        //Application.Run(new mine);
                        windowIndex = Windows.MainWindow;
                        break;
                }
            }
        }
    }
}
