using NiceNumbers.Calculators;

Console.WriteLine($"Number of nice numbers: {FindNiceNumbers()}");
Console.WriteLine("Press any key to stop the program...");
Console.ReadLine();

static long FindNiceNumbers()
{
    const int numeralSystemBase = 13;
    const int numberOfDigits = 6;
    var result = 0L;

    var numberOfPossibleSumsBySixDigits = (numeralSystemBase - 1) * numberOfDigits;

    for (var currentSum = 0; currentSum <= numberOfPossibleSumsBySixDigits; currentSum++)
    {
        var numberOfCombinations = NumeralSystemCalculator.GetNumberOfCombinationsForSum(numberOfDigits, currentSum);
        result += numberOfCombinations * numberOfCombinations;
    }

    return result * numeralSystemBase;
}