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
    public class Person : IDeserializationCallback, ISerializable
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        [field: NonSerialized] 
        private int _backingFieldAge;
        public int Age
        {
            get { return _backingFieldAge; }
            set { _backingFieldAge = SetAge(); }
        }

        public Person() { }
        protected Person(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            BirthDate = (DateTime)info.GetValue("BirthDate", typeof(DateTime));
            Gender = (Genders) info.GetValue("Gender", typeof(Genders));
            Age = SetAge();
        }


        public enum Genders
        {
            Male,
            Female
        }

        public int SetAge()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            if (BirthDate.Month > DateTime.Today.Month)
            {
                return age -1;
            }
            else if (BirthDate.Month == DateTime.Today.Month)
            {
                if (BirthDate.Day > DateTime.Today.Day)
                {
                    return age -1;
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
            Stream stream = new FileStream(filename + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public static Person Deserialize(string filename)
        {
            Person person = new Person(); // notice that Person should have a default constructor
            Stream stream = new FileStream(filename + ".bin", FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            person = (Person)formatter.Deserialize(stream);
            stream.Close();
            return person;
        }

        public override string ToString()
        {
            return "A person has a name, birthdate and a gender.";
        }

        public void OnDeserialization(object sender)
        {
            Age = SetAge();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("BirthDate", this.BirthDate);
            info.AddValue("Gender", this.Gender);
        }
    }
}
