using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication.Utils
{
    public class StringSplitterImpl:StringSplitter
    {
        readonly Classification c = new ClassificationImpl();
        public List<string> splitByDot(string str)
        {
            List<string> list = new List<string>();
            if(str.Contains("."))
            {
                string[] numbers = str.Split('.');
                if(numbers[1].Length==2 && numbers[1]!="00")
                {
                    
                    list.Add(numbers[0]);
                    list.Add(numbers[1]);
                }
                else if (numbers[1]=="00")
                {
                    list.Add(numbers[0]);
                }
                else if (numbers[1].Length==1 && numbers[1]!="0")
                {
                    list.Add(numbers[0]);
                    list.Add(numbers[1]+"0");
                }
                else 
                {
                    Console.WriteLine("No more than 2 digits after comma");
                    throw new NotImplementedException();
                }
            } 
            else
            {
                list.Add(str);
            }
            return list;
        }
    }
}