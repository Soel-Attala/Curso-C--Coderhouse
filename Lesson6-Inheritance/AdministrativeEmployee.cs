using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Inheritance
{
    public class AdministrativeEmployee : Employee
    {
        public AdministrativeEmployee(string id, long dni, string name, string adress)
            : base(id, dni, name, adress)
        {

        }
    }
}
