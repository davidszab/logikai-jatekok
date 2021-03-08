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
        static public GameDatabase database = new GameDatabase();
        static public bool runProgram = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            do
            {
                switch (windowIndex)
                {
                    case Windows.MainWindow:
                        //Application.Run(new MainMenuForm()); 
                        //MainMenuForm belepesnel Windows.CloseWindows-ra allitja a windowsIndex-et
                        //ha a felhasznalo valaszt jatekot akkor peddig a valasztott index-re csereli
                        windowIndex = Windows.CloseWindows;
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
                        Application.Run(new MinesweeperForm());
                        windowIndex = Windows.MainWindow;
                        break;

                    case Windows.StatisticsWindow:
                        //Application.Run(new StatisticsForm());
                        windowIndex = Windows.MainWindow;
                        break;

                    case Windows.CloseWindows:
                        runProgram = false;
                        break;
                }

            } while (runProgram);
        }
    }
}
