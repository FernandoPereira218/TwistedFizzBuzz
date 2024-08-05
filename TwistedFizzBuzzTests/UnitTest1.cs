using TwistedFizzBuzz.Exceptions;

namespace TwistedFizzBuzzTests;

public class UnitTest1
{
    [Fact]
    public void TestRange()
    {
        string result = TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzzRange(0, 10);
        Assert.Equal("FizzBuzz, 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz", result);
    }

    [Fact]
    public void TestNonSequential()
    {
        string result = TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzzNonSequential(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Assert.Equal("FizzBuzz, 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz", result);
    }

    [Fact]
    public void TestErrorNonSequential()
    {
        Assert.Throws<DifferentLengthException>(() => 
            TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzzNonSequential(
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 
                new List<string> { "Fizz", "Buzz" },
                new List<int> { 5, 9, 27 }));
    }

    [Fact]
    public void TestErrorRange()
    {
        Assert.Throws<DifferentLengthException>(() =>
            TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzzRange(
                0, 10,
                new List<string> { "Fizz", "Buzz", "Strange" },
                new List<int> { 5, 9 }));
    }
}