using System;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var limit = int.Parse(args[0]);
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            string fizzbuzz = fizzBuzzCalculator.CalculateFizzBuzz(limit);
            Console.Write(fizzbuzz);
        }
    }
}
