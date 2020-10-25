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
            Person susan = new Person{Name = "Tom", BirthDate = DateTime.Parse("1998-10-25"), Age = 0};
            Console.WriteLine(susan.ToString());
            Console.WriteLine(susan.Name);
            Console.WriteLine(susan.BirthDate);
            Console.WriteLine(susan.Age);
            susan.Serialize("blablabla");
            Console.WriteLine(Person.Deserialize("susan").Name);
            Console.WriteLine(Person.Deserialize("blablabla").BirthDate);
            Console.WriteLine(Person.Deserialize("blablabla").Age);
            Console.ReadKey();
        }
    }
}
