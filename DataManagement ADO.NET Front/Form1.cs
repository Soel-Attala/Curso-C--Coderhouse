using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DataManagement_ADO.NET_Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=CoderHouse;Trusted_Connection=True;";


            List<Product> products = new List<Product>();
            var query = "SELECT Id, Cost, SellPrice, Stock from Product;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var Product = new Product();
                                Product.Id = Convert.ToInt32(reader["Id"]);
                                Product.Cost = Convert.ToDouble(reader["cost"]);
                                Product.SellingPrice = Convert.ToDouble(reader["SellPrice"]);
                                Product.Stock = Convert.ToDouble(reader["Stock"]);

                                products.Add(Product);


                            }
                        }
                    }
                }
                dataGridView1.DataSource = products;
                dataGridView1.AutoGenerateColumns = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}