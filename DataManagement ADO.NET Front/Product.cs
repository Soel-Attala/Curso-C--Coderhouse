using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement_ADO.NET_Front
{
    public class Product
    {
        private int id;
        private string description;
        private double cost;
        private double sellingPrice;
        private double stock;
        private int userId;

        public int Id { get => this.id; set => this.id = value; }
        public string Description { get => this.description; set => this.description = value; }
        public double Cost { get => this.cost; set => this.cost = value; }
        public double SellingPrice { get => this.sellingPrice; set => this.sellingPrice = value; }
        public double Stock { get => this.stock; set => this.stock = value; }
        public int UserId { get => this.userId; set => this.userId = value; }

    }
}

