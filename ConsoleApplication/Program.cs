using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
                Console.WriteLine("\n\nConstraints: Must be number and maximum 2 digits after comma");
//                Console.WriteLine("Please insert number between constraint");
                Console.WriteLine("Example : 123.45, 123, 123.10, 1.11 etc\n");
                string input = Console.ReadLine(); 
                string output = null;
                Regex regex = new Regex(@"\d+(\.\d{1,2})?");
                try
                {
                    if (input.Trim('0') == "")
                    {
                        output = "Zero Dollar";
                    }
                    else if (regex.IsMatch(input))
                    {
                        output = _money.inDollar(input);
                    }
                    else
                    {
                        throw new Exception();
                    }
                    
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Out of constraints");
//                    throw;
                }
                // Console.WriteLine("Hello World!");
                Console.WriteLine(output);
                Console.ReadKey(true);
            }
            
        }
    }
}