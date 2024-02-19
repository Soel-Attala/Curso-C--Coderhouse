using Lesson_11_EntityFramework.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_EntityFramework.database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=SOEL-PC\SQLEXPRESS;Database=Coder290124; Trusted_Connection=True;");
        }
    }
}
