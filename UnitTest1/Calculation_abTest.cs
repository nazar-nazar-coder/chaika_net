using net.lab3;
namespace lab3_test
{
    [TestClass]
    public class Calculation_abTest
    {
        //є числа кратні 14
        [TestMethod]
        public void RangeContainsMultiplesOf14_ReturnsProduct()
        {
            Calculation_ab calc = new Calculation_ab(10, 30);

            long result = calc.Calculate();

            Assert.AreEqual(392, result);
        }

        //немає кратних 14
        [TestMethod]
        public void RangeWithoutMultiplesOf14_ReturnsZero()
        {
            Calculation_ab calc = new Calculation_ab(1, 10);

            long result = calc.Calculate();

            Assert.AreEqual(0, result);
        }

        // (a > b)
        [TestMethod]
        public void ReversedRange_StillCalculatesCorrectly()
        {
            Calculation_ab calc = new Calculation_ab(50, 10);

            long result = calc.Calculate();

            Assert.AreEqual(16464, result);
        }

        // (a = b) та кратні 14
        [TestMethod]
        public void SingleValue_MultipleOf14_ReturnsThatNumber()
        {
            Calculation_ab calc = new Calculation_ab(14, 14);

            long result = calc.Calculate();

            Assert.AreEqual(14, result);
        }

        // (a = b), але не кратні 14
        [TestMethod]
        public void SingleValue_NotMultipleOf14_ReturnsZero()
        {
            Calculation_ab calc = new Calculation_ab(13, 13);

            long result = calc.Calculate();

            Assert.AreEqual(0, result);
        }
    }
}
