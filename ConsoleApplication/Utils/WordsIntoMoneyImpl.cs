using System.Collections.Generic;

namespace ConsoleApplication.Utils
{
    public class WordsIntoMoneyImpl:WordsIntoMoney
    {
        private readonly StringSplitter _splt = new StringSplitterImpl();
        private readonly Classification _c = new ClassificationImpl();
        public string inDollar(string input)
        {
            input = input.TrimStart('0');
            List<string> list = _splt.splitByDot(input);
            int size = list.Count;
            string output;
            if (size > 1)
            {
                output = _c.nestedDivision(list[0])+" Dollars And "+_c.nestedDivision(list[1])+" Cents";
            }
            else
            {
                output = _c.nestedDivision(list[0])+" Dollars";
            }
            return output;
        }
    }
}