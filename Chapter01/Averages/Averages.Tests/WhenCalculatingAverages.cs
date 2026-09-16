using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Averages.Tests;

[TestClass]
public class WhenCalculatingAverages
{
    [TestMethod]
    public void SingleInputShouldProduceSameValueAsResult()
    {
        string[] inputs = { "1" };
        double result = AverageCalculator.ArithmeticMean(inputs);
        Assert.AreEqual(1.0, result, 1E-14);
    }
    [TestMethod]
    public void MultipleInputsShouldProduceAverageAsResult()
    {
        string[] inputs = { "1", "2", "3" };
        double result = AverageCalculator.ArithmeticMean(inputs);
        Assert.AreEqual(2.0, result, 1E-14);
    }
    [TestMethod]
    public void NoInputShouldThrowArgumentException()
    {
        string[] inputs = { };
        Assert.Throws<ArgumentException>(() => AverageCalculator.ArithmeticMean(inputs));
    }
}