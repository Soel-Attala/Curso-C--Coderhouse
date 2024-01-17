using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Inheritance
{
    public class Employee : Person
    {
        protected string id;

        public Employee(string id, long dni, string name, string adress) : base(dni, name, adress)
        {
            this.id = id;

        }
    }
}
