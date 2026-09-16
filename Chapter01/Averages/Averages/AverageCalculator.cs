namespace Averages;
using System.Linq;
public static class AverageCalculator
{
    public static double ArithmeticMean(string[] args)
    {
        if (args == null || args.Length == 0)
        {
            throw new ArgumentException("No input provided");
        }
        return args.Select(numText => double.Parse(numText)).Average();
    }
}