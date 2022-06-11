namespace Toxic.ParamGuard.FunctionalTests
{
    public class EnumerableGuardClauseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        public void RegisterPerson(Person item)
        {
            Guard.ThrowOn(item).IfNull();

            // Further processing here

        }

        public void RegisterPerson(Person item)
        {
            item.Throw().IfNull();

            // Further processing here

        }

        public class Person
        {
            private string _name;
            private string _lastName;
            private DateTime _birthDate;


            public Person(string name, string lastName)
            {
                _name = Guard.ThrowOn(name).IfNullOrWhiteSpace().Value;
                _lastName = Guard.ThrowOn(_lastName).IfNullOrWhiteSpace().Value;
            }

            public Person(string name, string lastName, DateTime birthDate)
            {
                _name = name.Throw().IfNullOrWhiteSpace().Value;
                _lastName = lastName.Throw().IfNullOrWhiteSpace().Value;
                _birthDate = birthDate.Throw().IfNull().Value;
            }
        }

        [Test]
        public void EnumerableIsNull_IfNull()
        {
            List<int> list = null;
            Guard.ThrowOn(list).IfNull().IfCountZero();
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowOn(list).IfNull());
        }

        [Test]
        public void EnumerableCountZero_IfCountZero()
        {
            List<int> list = new List<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowOn(list).IfCountZero());
        }
    }
}
