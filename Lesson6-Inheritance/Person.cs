using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Inheritance
{
    public class Person
    {
        protected long DNI;
        protected string name;
        protected string adress;

        public Person()
        {
            this.DNI = 0;
            this.name = string.Empty;
            this.adress = string.Empty;
        }

        public Person(long dni, string name, string adress)
        {
            this.DNI = dni;
            this.name = name;
            this.adress = adress;
        }

        public virtual void ShowData()
        {
            Console.WriteLine($" Name: {this.name}\n DNI:{this.DNI}\n Adress:{this.adress}\n");
        }

        public static string EmergencyNumber()
        {
            return "101, 911";
        }

    }
}

/*                                           virtual and override.
    utilizamos virtual para poder modificar algun metodo de la clase padre en un clase hija.
    y la palabra override es lo que usamos para hacer dicha sobreescritura o modificacion.
*/
