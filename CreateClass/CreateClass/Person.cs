using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public enum Genders
        {
            Male,
            Female
        }

        public override string ToString()
        {
            return "A person has a name, birthdate and a gender.";
        }
    }
}
