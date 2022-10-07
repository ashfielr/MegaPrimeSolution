namespace MegaPrimeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMaxValue10()
        {
            List<uint> expected = new List<uint>() { 2,3,5,7};
            List<uint> actual = MegaPrime.getMegaPrimes(10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMaxValue37()
        {
            List<uint> expected = new List<uint>() { 2, 3, 5, 7, 23, 37 };
            List<uint> actual = MegaPrime.getMegaPrimes(37);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMaxValue0()
        {
            List<uint> expected = new List<uint>() { };
            List<uint> actual = MegaPrime.getMegaPrimes(0);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMaxValue1()
        {
            List<uint> expected = new List<uint>() { };
            List<uint> actual = MegaPrime.getMegaPrimes(1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMaxValue2()
        {
            List<uint> expected = new List<uint>() { 2 };
            List<uint> actual = MegaPrime.getMegaPrimes(2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMaxValue100()
        {
            List<uint> expected = new List<uint>() { 2,3,5,7,23,37,53,73};
            List<uint> actual = MegaPrime.getMegaPrimes(100);
            Assert.AreEqual(expected, actual);
        }
    }
}