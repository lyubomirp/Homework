using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using UnitTesting;

namespace DatabaseTest
{

    [TestFixture]
    public class DBTests
    {
        private const int arraySize = 16;
        [Test]
        public void EmptyConstructorShouldInitData()
        {

            Database db = new Database();

            Type type = typeof(Database);

            var field = (int[])type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(x => x.Name == "repo")
                .GetValue(db);

            var people = (Person[])type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(x => x.Name == "people")
                .GetValue(db);

            Assert.That(field.Length, Is.EqualTo(arraySize));
            Assert.That(people.Length, Is.EqualTo(arraySize));
        }

        [Test]
        public void CtorShoudlThrowInvalidOpWithLargerArray()
        {
            int[] arr = new int[17];

            Assert.Throws<InvalidOperationException>(() => new Database(arr));
        }

        [Test]
        public void AddShouldStopAt16()
        {
            int[] arr = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            Database db = new Database(arr);

            Assert.Throws<InvalidOperationException>(() => db.Add(17));
           
        }

        [Test]
        public void RemoveShouldRemoveLast()
        {
            int[] arr = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            Database db = new Database(arr);

            Assert.That(db.RemoveInt(), Is.EqualTo(0));
            Assert.That(db.Fetch().Last(), Is.EqualTo(15));
        }
    }
}
