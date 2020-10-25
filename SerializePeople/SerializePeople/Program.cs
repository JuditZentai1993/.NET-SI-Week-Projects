using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        { 
            Person susan = new Person{Name = "susan", BirthDate = DateTime.Parse("1988-10-25"), Age = 0};
            Console.WriteLine(susan.ToString());
            Console.WriteLine(susan.Name);
            Console.WriteLine(susan.BirthDate);
            Console.WriteLine(susan.Age);
            susan.Serialize("susan");
            Console.WriteLine(Person.Deserialize("susan").Name);
            Console.WriteLine(Person.Deserialize("blablabla").BirthDate);
            Console.WriteLine(Person.Deserialize("blablabla").Age);



            Console.ReadKey();
        }
    }
}
