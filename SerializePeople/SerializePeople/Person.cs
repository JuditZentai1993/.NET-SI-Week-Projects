using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializePeople
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }

        public enum Genders
        {
            Male,
            Female
        }

        public int Age()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            if (BirthDate.Month > DateTime.Today.Month)
            {
                return age-1;
            }
            else if (BirthDate.Month == DateTime.Today.Month)
            {
                if (BirthDate.Day > DateTime.Today.Day)
                {
                    return age-1;
                }
                else
                {
                    return age;
                }
            }
            else
            {
                return age;
            }
        }

        public void Serialize(string filename)
        {
            Stream stream = new FileStream(filename+".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public override string ToString()
        {
            return "A person has a name, birthdate and a gender.";
        }
    }
}
