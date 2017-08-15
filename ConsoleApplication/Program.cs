using System;
using System.Collections.Generic;
using ConsoleApplication.Utils;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringSplitter splt = new StringSplitterImpl();
            Classification c = new ClassificationImpl();
            while (true)
            {
                Console.WriteLine("\n\nConstraints: After comma must have 2-digit numbers");
//                Console.WriteLine("Please insert number between constraint");
                Console.WriteLine("Example : 123.45, 123, 123.10, 1.11 etc\n");
                string input = Console.ReadLine();
                string output = null;
                try
                {
                    output = input.TrimStart('0');
                    output = splt.splitByDot(output);
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