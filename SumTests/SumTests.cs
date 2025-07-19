using Xunit;
using SumLibrary;

namespace SumTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(2.5, 2.5, 5)]
        [InlineData(-3, -7, -10)]
        public void Add_ReturnsExpected(double a, double b, double expected) =>
            Assert.Equal(expected, Sum.Add(a, b));

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(2.5, 1.2, 1.3)]
        public void Subtract_ReturnsExpected(double a, double b, double expected) =>
            Assert.Equal(expected, Sum.Subtract(a, b));
    }
}
