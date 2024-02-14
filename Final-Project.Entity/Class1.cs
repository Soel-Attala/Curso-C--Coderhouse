namespace Final_Project.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public long Stock { get; set; }
        public double SalePrice { get; set; }
        public int UserId { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public string Comments { get; set; }
    }

    public class SoldProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SaleId { get; set; }
        public long Stock { get; set; }
    }
}


