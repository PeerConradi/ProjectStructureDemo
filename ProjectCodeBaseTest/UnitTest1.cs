using NUnit.Framework;

namespace ProjectCodeBaseTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            var result = ProjectCodeBase.Class1.HighFive();
            Assert.AreEqual(5, result);
        }
    }
}