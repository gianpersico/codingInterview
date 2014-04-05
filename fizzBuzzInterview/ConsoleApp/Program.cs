﻿using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var target = int.Parse(args[0]);
            var output = "";
            for (int i = 1; i <= target; i++)
            {
                if (i%3==0)
                {
                    output += string.Format("{0} ", "Fizz");
                    continue;
                }
                output += string.Format("{0} ", i);
            }
            Console.Write(output.Trim());
        }
    }
}
