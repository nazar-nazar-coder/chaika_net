using net.lab3;
namespace lab3_test
{
    [TestClass]
    public sealed class Calculation_abcTest
    {
        //усі числа більші за 15
        [TestMethod]
        public void AllGreaterThan15_ReturnsProduct()
        {
            Calculation_abc calc = new Calculation_abc(16, 20, 18);

            double result = calc.Calculate();

            Assert.AreEqual(16 * 20 * 18, result);
        }

        //не всі числа більші за 15
        [TestMethod]
        public void NotAllGreaterThan15_ReturnsSquareOfSum()
        {
            Calculation_abc calc = new Calculation_abc(10, 16, 18);

            double result = calc.Calculate();

            double expected = System.Math.Pow(10 + 16 + 18, 2);

            Assert.AreEqual(expected, result);
        }

        //усі рівні 15 
        [TestMethod]
        public void AllEqual15_ReturnsSquareOfSum()
        {
            Calculation_abc calc = new Calculation_abc(15, 15, 15);

            double result = calc.Calculate();
            double expected = System.Math.Pow(15 + 15 + 15, 2);

            Assert.AreEqual(expected, result);
        }
    }
}