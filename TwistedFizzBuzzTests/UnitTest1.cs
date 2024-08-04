namespace TwistedFizzBuzzTests;

public class UnitTest1
{
    [Fact]
    public void TestSequential()
    {
        string result = TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzzRange(0, 10);
        Assert.Equal("FizzBuzz, 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz", result);
    }
}