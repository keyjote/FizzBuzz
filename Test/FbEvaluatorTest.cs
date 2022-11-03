using FizzBuzz.Constants;
using FizzBuzz.Service;

namespace Test;

public class FbEvaluatorTest
{
    [Theory]
    [InlineData(1, FizzBuzzType.None)]
    [InlineData(15, FizzBuzzType.Fifteen)]
    [InlineData(2, FizzBuzzType.None)]
    [InlineData(35, FizzBuzzType.Five)]
    [InlineData(99, FizzBuzzType.Three)]
    [InlineData(100, FizzBuzzType.Five)]
    [InlineData(333, FizzBuzzType.Three)]
    [InlineData(150, FizzBuzzType.Fifteen)]
    [InlineData(225, FizzBuzzType.Fifteen)]
    [InlineData(11390625, FizzBuzzType.Fifteen)]
    [InlineData(-3, FizzBuzzType.Three)]
    public void CheckForMultiples(int number, FizzBuzzType expectedResult)
    {
        var type = FbEvaluator.Evaluate(number);
        Assert.Equal(expectedResult, type);
    }
}