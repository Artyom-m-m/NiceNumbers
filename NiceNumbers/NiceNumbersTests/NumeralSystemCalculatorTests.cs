using NiceNumbers.Calculators;
using Xunit;

namespace NiceNumbersTests
{
    public sealed class NumeralSystemNumeralSystemCalculationHelperTests
    {
        [Theory]
        [InlineData(0, 0, 2)]
        [InlineData(0, 0, 3)]
        [InlineData(0, 0, 10)]
        [InlineData(0, 0, 13)]
        public void GetNumberOfCombinationsForSum_ZeroDigitsSumIs0_ReturnZero(int numberOfDigits, int sum, int numeralSystemBase)
        {
            Assert.Equal(0, NumeralSystemCalculator.GetNumberOfCombinationsForSum(numberOfDigits, sum, numeralSystemBase));
        }

        [Theory]
        [InlineData(1, 0, 2)]
        [InlineData(1, 0, 3)]
        [InlineData(1, 0, 10)]
        [InlineData(1, 0, 13)]
        public void GetNumberOfCombinationsForSum_OneDigitSumIs0_Return1(int numberOfDigits, int sum, int numeralSystemBase)
        {
            Assert.Equal(1, NumeralSystemCalculator.GetNumberOfCombinationsForSum(numberOfDigits, sum, numeralSystemBase));
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        [InlineData(1, 1, 10)]
        [InlineData(1, 1, 13)]
        public void GetNumberOfCombinationsForSum_OneDigitSumIs1_Return1(int numberOfDigits, int sum, int numeralSystemBase)
        {
            Assert.Equal(1, NumeralSystemCalculator.GetNumberOfCombinationsForSum(numberOfDigits, sum, numeralSystemBase));
        }

        [Theory]
        [InlineData(1, 12, 13, 1)]
        [InlineData(2, 0, 13, 1)]
        [InlineData(2, 2, 13, 3)]
        [InlineData(2, 23, 13, 2)]
        [InlineData(2, 22, 13, 3)]
        [InlineData(2, 24, 13, 1)]
        [InlineData(3, 2, 13, 6)]
        [InlineData(1, 9, 10, 1)]
        [InlineData(2, 2, 10, 3)]
        [InlineData(2, 3, 10, 4)]
        public void GetNumberOfCombinationsForNumeralSystem(int numberOfDigits, int sum, int numeralSystemBase, long expectedValue)
        {
            Assert.Equal(expectedValue, NumeralSystemCalculator.GetNumberOfCombinationsForSum(numberOfDigits, sum, numeralSystemBase));
        }
    }
}