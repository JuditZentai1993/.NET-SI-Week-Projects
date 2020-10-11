using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        public double Salary { get; set; }
        public string Profession { get; set; }

        public Room Room { get; set; }

        public override string ToString()
        {
            return Salary + ", " + Profession;
        }
    }
}
