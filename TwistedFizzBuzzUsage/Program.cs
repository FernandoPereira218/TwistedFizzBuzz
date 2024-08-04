// See https://aka.ms/new-console-template for more information
Console.WriteLine("Output values from -20 to 127");
Console.WriteLine(TwistedFizzBuzz.TwistedFizzBuzz.FizzBuzzRange(-20, 127, words: new List<string> { "Fizz", "Buzz", "Bar" }, divisors: new List<int> { 5, 9, 27 }));
