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
        private MySqlConnection MySql { get; set; }
        private MySqlConnection Database { get; set; }

        /// <param name="pathToConfigFile">
        /// Config file in which the datas are being stored for the connection.
        /// The order in the file:
        /// [server] /n [user] /n [password] (empty line if not set) /n [port]
        /// </param>
        /// <param name="setUpNewDB">Would you like to set up the database from scratch?</param>
        public GameDatabase(string pathToConfigFile, bool setUpNewDB)
        {
            GetConnectionDatas(pathToConfigFile);

            if (setUpNewDB) SetUpDatabase();
        }

        /// gets the datas needed for the MySql connection from the given file (server, user, password, port)
        private void GetConnectionDatas(string path)
        {
            StreamReader st = new StreamReader(path);

            string server = st.ReadLine();
            string user = st.ReadLine();
            string password = st.ReadLine();
            string port = st.ReadLine();

            st.Close();

            MySql = new MySqlConnection($"server = {server}; user = {user}; port = {port}; password = {password};");
            Database = new MySqlConnection($"server = {server}; user = {user}; password = {password}; database = logicgames;");
        }

        ///creates the LogicGames database and the tables with the values needed
        private void SetUpDatabase()
        {
            //logicgames database
            DoNonQuery("CREATE DATABASE LogicGames;", MySql);

            //player table
            DoNonQuery("CREATE TABLE player(player_id INT AUTO_INCREMENT, name VARCHAR(20), CONSTRAINT PRIMARY KEY(player_id));", Database);

            //game table
            DoNonQuery("CREATE TABLE game(game_id INT AUTO_INCREMENT, name VARCHAR(20), CONSTRAINT PRIMARY KEY(game_id));", Database);

            //score table
            DoNonQuery("CREATE TABLE score(score_id INT AUTO_INCREMENT, player_id INT, game_id INT, points INT, CONSTRAINT PRIMARY KEY(score_id));", Database);

            //insert into game table
            DoNonQuery("INSERT INTO game(name) VALUES('hangman');", Database);
            DoNonQuery("INSERT INTO game(name) VALUES('mastermind');", Database);
            DoNonQuery("INSERT INTO game(name) VALUES('minesweeper');", Database);
        }

        ///executes a nonquery. It is separate async method so that more than one of it can run asynchronously
        private void DoNonQuery(string command, MySqlConnection connection)
        {
            connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand(command, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Executes a query and returns back the results
        /// </summary>
        /// <param name="command">SQL command</param>
        /// <returns>List of objects which contains the results of the query</returns>
        public List<object> Query(string command)
        {
            Database.Open();

            MySqlCommand sqlCommand = new MySqlCommand(command, Database);
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            List<object> back = new List<object>();
            while (reader.Read()) back.Add(reader);

            reader.Close();
            Database.Close();

            return back;
        }

        /// <summary>
        /// Executes a query and returns back the result
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Object with the result</returns>
        public object SingleValue(string command)
        {
            Database.Open();

            MySqlCommand sqlCommand = new MySqlCommand(command, Database);

            object back = sqlCommand.ExecuteScalar();

            Database.Close();

            return back;
        }

        /// <summary>
        /// Adds new player to the database
        /// </summary>
        /// <param name="player">username</param>
        public void AddPlayer(string player)
        {
            DoNonQuery($"INSERT INTO player(name) VALUES('{player}');", Database);
        }

        /// <summary>
        /// Saves the data to the database
        /// </summary>
        /// <param name="player">username</param>
        /// <param name="game">hangman / mastermind / minesweeper</param>
        /// <param name="score">number of points</param>
        public void SaveData(string player, string game, int score)
        {
            int game_id = game == "hangman" ? 1 : game == "mastermind" ? 2 : game == "minesweeper" ? 3 : 0;
            if (game_id == 0) throw new ArgumentException($"There is no table called '{game}' in the database!");

            int player_id = Convert.ToInt32(SingleValue($"SELECT player.player_id FROM player WHERE player.name = '{player}'"));
            if (player_id == 0) throw new ArgumentException($"There is no player.name called '{player}' in the database!");

            DoNonQuery($"INSERT INTO score(player_id,game_id,points) VALUES({player_id},{game_id},{score})", Database);
        }
    }
}
