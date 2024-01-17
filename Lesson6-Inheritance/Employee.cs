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

        public override void ShowData()
        {
            Console.WriteLine($" ID: {this.id}\n Name: {this.name}\n DNI:{this.DNI}\n Adress:{this.adress}\n");
        }

        // esto que estamos haciendo se llama polimorfismo derivado, es decir, usamos una misma funcionalidad en 
        // clases padres e hijas, pero que cuando lo llamamos en cada uno hace algo distinto.


    }
}
