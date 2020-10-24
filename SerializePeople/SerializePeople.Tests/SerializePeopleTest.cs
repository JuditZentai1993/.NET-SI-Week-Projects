using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SerializePeople.Tests
{
    [TestFixture]
    public class SerializePeopleTest
    {
        [Test]
        public void CreateInstance_GivenPerson_ShouldReturnPerson()
        {
            Person person = new Person{ Name = "Pal", BirthDate = DateTime.Parse("1995.05.05") };
            Assert.AreEqual("Pal", person.Name);
        }

        [Test]
        public void ToString_ShouldReturnCustomText()
        {
            Person person = new Person { Name = "Pal", BirthDate = DateTime.Parse("1995.05.05") };
            Assert.AreEqual("A person has a name, birthdate and a gender.", person.ToString());
        }
    }
}
