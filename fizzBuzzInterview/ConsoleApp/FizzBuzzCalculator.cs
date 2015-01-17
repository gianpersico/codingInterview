using System;
using System.Text;

namespace ConsoleApp
{
    public class FizzBuzzCalculator
    {
        public string CalculateFizzBuzz(int limit)
        {
            var result = new StringBuilder();
            const string fizz = "Fizz";
            const string buzz = "Buzz";

            for (var i = 1; i <= limit; i++)
            {
                string outputResult;
                if (i % 15 == 0)
                {
                    outputResult = fizz + buzz;
                }
                else if (i % 3 == 0)
                {
                    outputResult = fizz;
                }
                else if (i % 5 == 0)
                {
                    outputResult = buzz;
                }
                else
                {
                    outputResult = i.ToString();
                }

                result.AppendFormat("{0} ", outputResult);
            }

            return result.ToString().TrimEnd();
        }
    }
}