namespace Calculations.Test
{
    public class CalculatrTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calculator = new Calculator();
            var result = calculator.AddDouble(1.1, 2.2);
            Assert.Equal(3.3, result, 1);
        }
    }
}