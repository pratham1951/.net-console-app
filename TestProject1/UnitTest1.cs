using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void TestAdd()
        {
            int expectedResult = 5;

            int result = calc.Add(2, 3);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSub()
        {
            int expectedResult = -2;

            int result = calc.Sub(-1, 1);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
