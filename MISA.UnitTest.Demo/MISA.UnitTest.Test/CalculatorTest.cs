using MISA.UnitTest.Demo;
using NUnit.Framework;
namespace MISA.UnitTest.Test
{
    public class CalculatorTest
    {
        //[TestFixture]
        private Calculator calculator;


        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void OnePlusOneEqualTow()
        {
            Assert.AreEqual(2, calculator.add(1, 1));
        }

        [Test]
        public void TowPlusTowEqualFour()
        {
            Assert.AreEqual(4, calculator.add(2, 2));
        }

        [Test]
        public void TowDivideZeroEqualNull()
        {
            Assert.AreEqual(null, calculator.Division(2, 0));
        }

    }
}