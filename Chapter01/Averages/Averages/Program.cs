using Averages;

Console.WriteLine("Calculating the arithmetic mean of the input arguments");

try
{
    Console.WriteLine(string.Join(", ", args) + " => " + AverageCalculator.ArithmeticMean(args));
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
