namespace Toxic.ParamGuard.FunctionalTests
{
    public class StringGuardClauseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringIsNull_IfNull()
        {
            string val = null;
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowOn(val).IfNull());
        }

        [Test]
        public void StringIsNotNull_IfNull()
        {
            string val = " ";
            Assert.DoesNotThrow(() => Guard.ThrowOn(val).IfNull());
        }

        [Test]
        public void StringIsWhiteSpace_IfNullOrWhiteSpace()
        {
            string val = " ";
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowOn(val).IfNullOrWhiteSpace());
        }

        [Test]
        public void StringIsNull_IfNullOrWhiteSpace()
        {
            string val = null;
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowOn(val).IfNullOrWhiteSpace());
        }

        [Test]
        public void StringIsNull_IfNullOrEmpty()
        {
            string val = null;
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowOn(val).IfNullOrEmpty());
        }

        [Test]
        public void StringIsEmpty_IfNullOrEmpty()

        {
            string val = "";
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowOn(val).IfNullOrEmpty());
        }

        [Test]
        public void StringIsNotEmpty_IfNullOrEmpty()
        {
            string val = " ";
            Assert.DoesNotThrow(() => Guard.ThrowOn(val).IfNullOrEmpty());
        }

    }
}