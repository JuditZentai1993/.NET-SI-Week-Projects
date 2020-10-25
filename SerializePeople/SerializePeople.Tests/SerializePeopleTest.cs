using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SerializePeople.Tests
{
    [TestFixture]
    public class SerializePeopleTest
    {
        [Test]
        public void CreateInstance_GivenPerson_ShouldShowPersonAttributes()
        {
            Person person = new Person{ Name = "Pal", BirthDate = DateTime.Parse("1995.05.05"), Gender = Person.Genders.Male};
            Assert.AreEqual("Pal", person.Name);
            Assert.AreEqual(DateTime.Parse("1995.05.05"), person.BirthDate);
            Assert.AreEqual(Person.Genders.Male,person.Gender);
            Assert.AreEqual(25,person.Age());
        }

        [Test]
        public void ToString_ShouldReturnCustomText()
        {
            Person person = new Person { Name = "Pal", BirthDate = DateTime.Parse("1995.05.05") };
            Assert.AreEqual("A person has a name, birthdate and a gender.", person.ToString());
        }

        [Test]
        public void Serialize_ShouldCreateFileWithObjectDetails()
        {
            File.Delete("test.bin");
            Person person = new Person { Name = "Pal", BirthDate = DateTime.Parse("1995.05.05") };
            person.Serialize("test");
            Assert.IsTrue(File.Exists("test.bin"));
        }

        [Test]
        public void Deserialize_ShouldReturnObjectDetails()
        {
            File.Delete("test.bin");
            Person person = new Person { Name = "Pal", BirthDate = DateTime.Parse("1995.05.05") };
            person.Serialize("test");
            Assert.AreEqual(person.Name,Person.Deserialize("test").Name);
        }
    }
}
