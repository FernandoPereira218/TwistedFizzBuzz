using System.Text;
using TwistedFizzBuzz.Exceptions;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzz
    {
        public static string FizzBuzzRange(int starterIndex, int endIndex, List<string> words = null, List<int> divisors = null)
        {
            SetDefaultValues(ref words, ref divisors);
            if (ValidValues(words, divisors))
                return FizzBuzzAlgorithm(words, divisors, true, starterIndex: starterIndex, endIndex: endIndex);

            throw new DifferentLengthException("Words and divisors must have the same length");
        }

        public static string FizzBuzzNonSequential(List<int> inputs, List<string> words = null, List<int> divisors = null)
        {
            SetDefaultValues(ref words, ref divisors);
            if (ValidValues(words, divisors))
                return FizzBuzzAlgorithm(words, divisors, false, inputs);

            throw new DifferentLengthException("Words and divisors must have the same length");
        }

        private static void SetDefaultValues(ref List<string> words, ref List<int> divisors)
        {
            if (words == null || !words.Any())
                words = new List<string>() { "Fizz", "Buzz" };

            if (divisors == null || !divisors.Any())
                divisors = new List<int>() { 3, 5 };
        }

        private static bool ValidValues(List<string> words, List<int> divisors)
        {
            return words.Count == divisors.Count;
        }

        private static string FizzBuzzAlgorithm(List<string> words, List<int> divisors, bool sequential = true, List<int> inputs = null, int starterIndex = 0, int endIndex = 0)
        {
            StringBuilder sb = new StringBuilder();
            if (sequential)
            {
                for (int i = starterIndex; i <= endIndex; i++)
                {
                    string word = GetWord(words, divisors, i);
                    if (string.IsNullOrEmpty(word))
                        word = i.ToString();

                    sb.Append(string.Format("{0}{1}", word, i == endIndex ? "" : ", "));
                }
            }
            else
            {
                int count = 0;
                foreach (var i in inputs)
                {
                    string word = GetWord(words, divisors, i);
                    if (string.IsNullOrEmpty(word))
                        word = i.ToString();

                    sb.Append(string.Format("{0}{1}", word, count == inputs.Count ? "" : ", "));
                    count++;
                }
            }

            return sb.ToString();
        }

        private static string GetWord(List<string> words, List<int> divisors, int i)
        {
            string word = "";
            foreach (var divisor in divisors)
            {
                if (i % divisor == 0)
                    word += words[divisors.IndexOf(divisor)];
            }

            return word;
        }
    }
}
