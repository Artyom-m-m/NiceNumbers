using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NiceNumbersTests")]

namespace NiceNumbers.Calculators
{
    internal static class NumeralSystemCalculator
    {
        /// <summary>
        /// Returns number of possible digits combinations in a 6-length number in "numeralSystemBase" numeral system
        /// which sum equals "sum"
        /// </summary>
        /// <param name="numberOfDigits">Number of digits</param>
        /// <param name="sum">Expected sum of the  digits</param>
        /// <param name="numeralSystemBase">Numeral system base</param>
        /// <returns></returns>
        internal static long GetNumberOfCombinationsForSum(int numberOfDigits, int sum, int numeralSystemBase = 13)
        {
            if (numberOfDigits < 0)
            {
                throw new ArgumentException("Number of digits must be positive");
            }

            if (sum < 0)
            {
                throw new ArgumentException("Expected sum of digits must be positive");
            }

            if (numeralSystemBase <= 1)
            {
                throw new ArgumentException("Numeral system base must be greater than 1");
            }

            if (numberOfDigits == 0)
            {
                return 0;
            }

            if (sum == 0)
            {
                return 1;
            }

            if (numberOfDigits == 1)
            {
                if (sum <= numeralSystemBase - 1)
                {
                    return 1;
                }

                return 0;
            }

            var result = 0L;

            for (int i = 0; i <= numeralSystemBase - 1; i++)
            {
                if (sum >= i)
                {
                    // Если первая цифра в числе равна i, то сумма оставшихся цифр равна sum - i.
                    result += GetNumberOfCombinationsForSum(numberOfDigits - 1, sum - i, numeralSystemBase);
                }
            }

            return result;
        }
    }
}