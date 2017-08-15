using System;
using System.Collections.Generic;
using ConsoleApplication.Utils;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WordsIntoMoneyImpl _money = new WordsIntoMoneyImpl();
            while (true)
            {
                Console.WriteLine("\n\nConstraints: After comma must have 2-digit numbers");
//                Console.WriteLine("Please insert number between constraint");
                Console.WriteLine("Example : 123.45, 123, 123.10, 1.11 etc\n");
                string input = Console.ReadLine(); 
                string output = null;
                try
                {
                    if (input != null)
                    {
                        output = _money.inDollar(input);
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Out of constraints");
                    throw;
                }
                // Console.WriteLine("Hello World!");
                Console.WriteLine(output);
                Console.ReadKey(true);
            }
            
        }
    }
}