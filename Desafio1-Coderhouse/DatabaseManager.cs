using clase10.model;
using Desafio1_Coderhouse;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1_Coderhouse
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            this.connectionString = @"Server=SOEL-PC\\SQLEXPRESS.;Database=coderhouse;Trusted_Connection=True;";
        }

        public User GetUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM User where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int obtainedId = Convert.ToInt32(reader["id"]);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    User user = new User(obtainedId, firstName, lastName, username, password, email);

                    return user;
                }

                throw new Exception("Id not found");
            }
        }

        public bool AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO User (FirstName, LastName, Username, Password, Email) values (@firstName, @lastName, @username, @password, @email); select @@IDENTITY as ID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("firstName", user.FirstName);
                command.Parameters.AddWithValue("lastName", user.LastName);
                command.Parameters.AddWithValue("username", user.Username);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "DELETE FROM User WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateUserById(int id, User user)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE User SET FirstName = @firstName, LastName = @lastName, Username = @username, Password = @password, Email = @email WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("firstName", user.FirstName);
                command.Parameters.AddWithValue("lastName", user.LastName);
                command.Parameters.AddWithValue("username", user.Username);
                command.Parameters.AddWithValue("password", user.Password);
                command.Parameters.AddWithValue("email", user.Email);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateUserById(int id, string lastName)
        {
            throw new NotImplementedException("Method not implemented");
        }



        //product methods
        public Product GetProductById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "SELECT * FROM Product where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int obtainedId = Convert.ToInt32(reader["id"]);
                    string name = reader.GetString(1);
                    string description = reader.GetString(2);
                    double cost = Convert.ToDouble(reader["cost"]);
                    long stock = Convert.ToInt64(reader["stock"]);
                    double salePrice = Convert.ToDouble(reader["salePrice"]);

                    Product product = new Product(obtainedId, name, description, cost, stock, salePrice);

                    return product;
                }

                throw new Exception("Id not found");
            }
        }

        public bool AddProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "INSERT INTO Product (Name, Description, Cost, Stock, SalePrice) values (@name, @description, @cost, @stock, @salePrice); select @@IDENTITY as ID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("salePrice", product.SalePrice);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProductById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "DELETE FROM Product WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProductById(int id, Product product)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                string query = "UPDATE Product SET Name = @name, Description = @description, Cost = @cost, Stock = @stock, SalePrice = @salePrice WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("description", product.Description);
                command.Parameters.AddWithValue("cost", product.Cost);
                command.Parameters.AddWithValue("stock", product.Stock);
                command.Parameters.AddWithValue("salePrice", product.SalePrice);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProductById(int id, double cost)
        {
            throw new NotImplementedException("Method not implemented");
        }
    }
}
