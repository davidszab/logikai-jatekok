using System;
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
            if (!database.ConfigFileExists)
            {
                database.CreateConfigFile("localhost", "root", "3306", "");
                database.ConnectAndSetUpNewDB();
            }
            else database.ConnectToDatabase();
            do
            {
                switch (windowIndex)
                {
                    case Windows.MainWindow:
                        windowIndex = Windows.CloseWindows;
                        //Application.Run(new MainMenuForm()); 
                        //ha a felhasznalo valaszt jatekot, a valasztott index-re csereli a windowsIndexet
                        break;

                    case Windows.HangmanWindow:
                        windowIndex = Windows.MainWindow;
                        Application.Run(new Akasztófa());
                        break;

                    case Windows.MastermindWindow:
                        windowIndex = Windows.MainWindow;
                        Application.Run(new Mastermind());
                        break;

                    case Windows.MinesweeperWindow:
                        windowIndex = Windows.MainWindow;
                        Application.Run(new MinesweeperForm());
                        break;

                    case Windows.StatisticsWindow:
                        windowIndex = Windows.MainWindow;
                        Application.Run(new Statisztika());
                        break;

                    case Windows.CloseWindows:
                        runProgram = false;
                        break;
                }

            } while (runProgram);
        }
    }
}
