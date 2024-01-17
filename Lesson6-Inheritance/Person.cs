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

    }
}
