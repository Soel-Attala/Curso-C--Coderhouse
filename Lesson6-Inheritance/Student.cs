using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_Inheritance
{
    public class Student : Person
    {
        protected string career;
        public Student(string career, long dni, string name, string adress)
            : base(dni, name, adress)
        {
            this.career = career;
        }
    }
}
