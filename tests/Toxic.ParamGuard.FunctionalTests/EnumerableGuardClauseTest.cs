namespace Toxic.ParamGuard.FunctionalTests
{
    public class EnumerableGuardClauseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EnumerableIsNull_IfNull()
        {
            List<int> list = null;
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
