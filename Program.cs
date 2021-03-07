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

            if (!database.ConfigFileExists) database.CreateConfigFile("localhost", "root", "3306", "");
            database.SetUpDatabase();

            database.AddPlayer("one");
            database.AddPlayer("as");
            database.AddPlayer("da");

            database.SaveData("one", GameTypes.hangman, 21);
            database.SaveData("da", GameTypes.hangman, 32);
            database.SaveData("one", GameTypes.mastermind, 55);
            database.SaveData("da", GameTypes.hangman, 83);
            database.SaveData("one", GameTypes.hangman, 44);
            database.SaveData("as", GameTypes.minesweeper, 3);
            database.SaveData("one", GameTypes.hangman, 94);
            database.SaveData("one", GameTypes.mastermind, 8);

            List<string> name = database.GetPlayers();

            Console.WriteLine("huhhhh");

            //do
            //{
            //    switch (windowIndex)
            //    {
            //        case Windows.MainWindow:
            //            //Application.Run(new MainMenuForm()); 
            //            //MainMenuForm belepesnel Windows.CloseWindows-ra allitja a windowsIndex-et
            //            //ha a felhasznalo valaszt jatekot akkor peddig a valasztott index-re csereli
            //            break;

            //        case Windows.HangmanWindow:
            //            Application.Run(new Akasztófa());
            //            windowIndex = Windows.MainWindow;
            //            break;

            //        case Windows.MastermindWindow:
            //            Application.Run(new Mastermind());
            //            windowIndex = Windows.MainWindow;
            //            break;

            //        case Windows.MinesweeperWindow:
            //            Application.Run(new MinesweeperForm());
            //            windowIndex = Windows.MainWindow;
            //            break;

            //        case Windows.StatisticsWindow:
            //            //Application.Run(new StatisticsForm());
            //            windowIndex = Windows.MainWindow;
            //            break;

            //        case Windows.CloseWindows:
            //            runProgram = false;
            //            break;
            //    }

            //} while (runProgram);
        }
    }
}
