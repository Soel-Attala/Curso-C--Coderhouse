namespace Final_Project.Data
{
    using System;
    using Final_Project.Entity;

    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            this.connectionString = "Server=.;Database=coderhouse;Trusted_Connection=True;";
        }

        public User GetUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int obtainedId = Convert.ToInt32(reader["Id"]);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    User user = new User(obtainedId, firstName, lastName, username, password, email);
                    return user;
                }

                return null; // Return null if the user with the specified id is not found
            }
        }


    }
}