using System;
using TheModel;
using System.Data.SqlClient;

namespace DL
{
    public class SQLDbData
    {
        string connectionString
            = "Data Source = LAPTOP-GSQAHJBR; Initial Catalog = FameDirect; Integrated Security = true;";

            SqlConnection sqlConnection;

            public SQLDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Directors> GetDirectors()
        {
            string selectStatement = "SELECT Director, Movie FROM FameDirect";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Directors> director = new List<Directors>();

            SqlDataReader reader = selectCommand.ExecuteReader();


            while (reader.Read())
            {
                string Director = reader["Director"].ToString();
                string Movie = reader["Movie"].ToString();

                Directors readDirector = new Directors();
                readDirector.Director = Director;
                readDirector.Movie = Movie;

                director.Add(readDirector);

            }

            sqlConnection.Close();

            return director;

        }

        public int AddDirector (string Director, string Movie)
        {
            int success;

            string insertStatement = "INSERT INTO FameDirect VALUES (@Director, @Movie)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Director", Director);
            insertCommand.Parameters.AddWithValue("Movie", Movie);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public int UpdateDirector(string Director, string Movie)
        {
            int success;

            string updateStatement = $"UPDATE FameDirect SET Movie = @Movie WHERE Director = @Director";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@Movie", Movie);
            updateCommand.Parameters.AddWithValue("@Director", Director);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteDirector(string Director)
        {
            int success;

            string deleteStatement = $"DELETE FROM FameDirect WHERE Director = @Director";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@Director", Director);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

    }
}
