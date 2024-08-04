using System.Text;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzz
    {
        public static string FizzBuzzRange(int starterIndex, int endIndex, List<string> words = null, List<int> divisors = null)
        {
            SetDefaultValues(ref words, ref divisors);
            return FizzBuzzAlgorithm(words, divisors, true, starterIndex: starterIndex, endIndex: endIndex);
        }

        public static string FizzBuzzNonSequential(List<int> inputs, List<string> words = null, List<int> divisors = null)
        {
            SetDefaultValues(ref words, ref divisors);
            return FizzBuzzAlgorithm(words, divisors, false, inputs);
        }

        private static void SetDefaultValues(ref List<string> words, ref List<int> divisors)
        {
            if (words == null || !words.Any())
                words = new List<string>() { "Fizz", "Buzz" };

            if (divisors == null || !divisors.Any())
                divisors = new List<int>() { 3, 5 };
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

                    sb.AppendLine(word);
                }
            }
            else
            {
                foreach (var i in inputs)
                {
                    string word = GetWord(words, divisors, i);
                    if (string.IsNullOrEmpty(word))
                        word = i.ToString();

                    sb.AppendLine(word);
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
