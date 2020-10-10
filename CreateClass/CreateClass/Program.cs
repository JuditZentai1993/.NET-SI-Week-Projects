using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dude!");

            Person susan = new Person{Name = "Susan", BirthDate = DateTime.Parse("1990-01-25")};

            Console.WriteLine(susan.ToString());
            Console.WriteLine(susan.Name);
            Console.WriteLine(susan.BirthDate);

            Console.ReadLine();

        }
    }
}
