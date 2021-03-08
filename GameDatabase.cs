using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace logikai_jatekok
{
    class GameDatabase
    {
        private MySqlConnection Conn { get; set; }
        public bool ConfigFileExists
        {
            get => File.Exists("datas/DBcon.config") ? true : false;
        }

        /// gets the datas needed for the MySql connection from the given file (server, user, password, port)
        private void GetConnectionDatas()
        {
            StreamReader st = new StreamReader("datas/DBcon.config");

            string server = st.ReadLine();
            string user = st.ReadLine();
            string password = st.ReadLine();
            string port = st.ReadLine();

            st.Close();

            Conn = new MySqlConnection($"server = {server}; user = {user}; port = {port}; password = {password};");
        }

        public void ConnectToDatabase()
        {
            GetConnectionDatas();

            //connect to database
            DoNonQuery("USE logicgames;");
        }

        ///creates the LogicGames database and the tables with the values needed
        public void ConnectAndSetUpNewDB()
        {
            GetConnectionDatas();

            //creating database and tables
            DoNonQuery
            (
                //logicgames database
                "CREATE DATABASE logicgames;" +
                "USE logicgames;" +

                //player table
                "CREATE TABLE player(player_id INT AUTO_INCREMENT, name VARCHAR(20), CONSTRAINT PRIMARY KEY(player_id));" +

                //game table
                "CREATE TABLE game(game_id INT AUTO_INCREMENT, name VARCHAR(20), CONSTRAINT PRIMARY KEY(game_id));" +

                //score table
                "CREATE TABLE score(score_id INT AUTO_INCREMENT, player_id INT, game_id INT, points INT, date DATETIME, CONSTRAINT PRIMARY KEY(score_id));"
            );

            //insert into game table
            DoNonQuery
            (
                "INSERT INTO game(name) VALUES('hangman');" +
                "INSERT INTO game(name) VALUES('mastermind');" +
                "INSERT INTO game(name) VALUES('minesweeper');"
            );
        }



        public void CreateConfigFile(string server, string user, string port, string password)
        {
            Directory.CreateDirectory("datas");
            File.WriteAllText("datas/DBcon.config", $"{server}\n{user}\n{password}\n{port}");
        }

        ///executes a nonquery. It is separate async method so that more than one of it can run asynchronously
        private void DoNonQuery(string command)
        {
            Conn.Open();
            MySqlCommand sqlCommand = new MySqlCommand(command, Conn);
            sqlCommand.ExecuteNonQuery();
            Conn.Close();
        }

        /// <summary>
        /// Executes a query and returns back the results
        /// </summary>
        /// <param name="command">SQL command</param>
        /// <returns>List of objects which contains the results of the query</returns>
        public List<List<object>> Query(string command)
        {
            Conn.Open();

            MySqlCommand sqlCommand = new MySqlCommand(command, Conn);
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            List<List<object>> back = new List<List<object>>();
            while (reader.Read())
            {
                List<object> row = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader[i]);
                }
                back.Add(row);
            }

            reader.Close();
            Conn.Close();

            return back;
        }

        /// <summary>
        /// Executes a query and returns back the result
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Object with the result</returns>
        public object SingleValue(string command)
        {
            Conn.Open();

            MySqlCommand sqlCommand = new MySqlCommand(command, Conn);

            object back = sqlCommand.ExecuteScalar();

            Conn.Close();

            return back;
        }

        /// <summary>
        /// Adds new player to the database
        /// </summary>
        /// <param name="player">username</param>
        public void AddPlayer(string player)
        {
            DoNonQuery($"INSERT INTO player(name) VALUES('{player}');");
        }

        public List<string> GetPlayers()
        {
            List<string> back = new List<string>();
            List<List<object>> rows = Query("SELECT player.name FROM player");

            foreach (var row in rows)
            {
                back.Add(Convert.ToString(row[0]));
            }

            return back;
        }

        /// <summary>
        /// Saves the data to the database
        /// </summary>
        /// <param name="player">username</param>
        /// <param name="gameType">hangman / mastermind / minesweeper</param>
        /// <param name="score">number of points</param>
        public void SaveData(string player, GameTypes gameType, int score)
        {
            int game_id = (int)gameType;

            int player_id = Convert.ToInt32(SingleValue($"SELECT player.player_id FROM player WHERE player.name = '{player}'"));
            if (player_id == 0) throw new ArgumentException($"There is no player.name called '{player}' in the database!");

            DoNonQuery($"INSERT INTO score(player_id,game_id,points,date) VALUES({player_id},{game_id},{score},NOW())");
        }
    }
}
