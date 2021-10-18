using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }
        
        [Test]
        public void TestNameValid() 
        {
            Person john = new Person("John Doe", "5.260.108-6");
            string expected = "John Doe";
            string actual = john.Name;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void TestIdValid() 
        {
            Person john = new Person("John Doe", "5.260.108-6");
            string expected = "5.260.108-6";
            string actual = john.ID;
            Assert.AreEqual(expected,actual);
        }
        
        [Test]
        public void TestNameInvalid() 
        {
            Person jane = new Person("", "8.765.432-1");
            string expected = null;
            string actual = jane.Name;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void TestIdInvalid() 
        {
            Person jane = new Person("Jane Doe", "8.765.432-1");
            string expected = null;
            string actual = jane.ID;
            Assert.AreEqual(expected,actual);
        }
    }
}