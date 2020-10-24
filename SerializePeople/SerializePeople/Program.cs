using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        { 
            Person susan = new Person { Name = "Susan", BirthDate = DateTime.Parse("1990-10-25") };
            Console.WriteLine(susan.ToString());
            Console.WriteLine(susan.Name);
            Console.WriteLine(susan.BirthDate);
            Console.WriteLine(susan.Age());
            Console.ReadKey();
        }
    }
}
