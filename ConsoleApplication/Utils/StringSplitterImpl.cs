using System;

namespace ConsoleApplication.Utils
{
    public class StringSplitterImpl:StringSplitter
    {
        readonly Classification c = new ClassificationImpl();
        public string splitByDot(string str)
        {
            string[] numbers;
            string output;
            if(str.Contains("."))
            {
                numbers = str.Split('.');
                if(numbers[1].Length==2 && numbers[1]!="00")
                {
                    output = c.nestedDivision(numbers[0])+" Dollars And "+c.nestedDivision(numbers[1])+" Cents";   
                }
                else 
                {
                    Console.WriteLine("After comma must have 2-digit numbers");
                    throw new NotImplementedException();
                }
            }
            else output = c.nestedDivision(str)+" Dollars";
            return output;
        }
    }
}