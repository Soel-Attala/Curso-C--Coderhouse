using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_EntityFramework.models
{
    public class Product
    {

        public int Stock { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }

    }
}
