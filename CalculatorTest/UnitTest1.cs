using CalculatorLogic;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class UnitTest1
    {
        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            this.calculator = new Calculator();
        }
        [Test]
        public void TestSum()
        {
            var sum = calculator.Sum(100, 200);
            Assert.AreEqual(300, sum);
        }
        [Test]
        public void TestSubstract()
        {
            var sum = calculator.Subtract(100, 200);
            Assert.AreEqual(-100, sum);
        }
        [Test]
        public void TestMultiply()
        {
            var sum = calculator.Multiply(100, 200);
            Assert.AreEqual(20000, sum);
        }
        [Test]
        public void TestDivide()
        {
            var sum = calculator.Divide(100, 200);
            Assert.AreEqual(0.5, sum);
        }


    }
}
