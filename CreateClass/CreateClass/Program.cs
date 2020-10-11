using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.WriteLine(susan.ToString());

            Employee bob = new Employee{BirthDate = DateTime.Parse("1985.02.02"), Name = "Bob", Profession = "ice-skater", Salary = 200000, Room = new Room{RoomNumber = 5}};
            Console.WriteLine(bob.Name);
            Console.WriteLine(bob.BirthDate);
            Console.WriteLine(bob.Room.RoomNumber);
            Console.WriteLine(bob.ToString());

            Employee Kovacs = new Employee{Name = "Géza", BirthDate = DateTime.Now, Salary = 1000, Profession = "léhűtő"};
            Kovacs.Room = new Room{RoomNumber = 111};
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs.Room.RoomNumber);
            Console.WriteLine(Kovacs2.ToString());
            Console.WriteLine(Kovacs2.Room.RoomNumber);
            Console.ReadKey();

            Console.ReadLine();

        }
    }
}
