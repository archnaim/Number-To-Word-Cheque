using System;

namespace ConsoleApplication.Utils
{
    public class ConversionToStringImpl:ConversionToString
    {
        public string charToString1Digit(char c)
        {
            string s = null;
            switch(c)
            {
                case '1':
                    s = "One";
                    break;
                case '2':
                    s = "Two";
                    break;
                case '3':
                    s = "Three";
                    break;
                case '4':
                    s = "Four";
                    break;
                case '5':
                    s = "Five";
                    break;
                case '6':
                    s = "Six";
                    break;
                case '7':
                    s = "Seven";
                    break;
                case '8':
                    s = "Eight";
                    break;
                case '9':
                    s = "Nine";
                    break;
                case '0':
                    // s = "Zero";
                    break;
                default: break;
            }
            return s;
        }

        public string charToString1Digit(int c)
        {
            string s = null;
            switch(c)
            {
                case 1:
                    s = "One";
                    break;
                case 2:
                    s = "Two";
                    break;
                case 3:
                    s = "Three";
                    break;
                case 4:
                    s = "Four";
                    break;
                case 5:
                    s = "Five";
                    break;
                case 6:
                    s = "Six";
                    break;
                case 7:
                    s = "Seven";
                    break;
                case 8:
                    s = "Eight";
                    break;
                case 9:
                    s = "Nine";
                    break;
                case 0:
                    // s = "Zero";
                    break;
                default: break;
            }
            return s;
        }

        public string charToString2Digit(string str)
        {
            string s = null;
            switch(str)
            {
                case "10":
                    s = "Ten";
                    break;
                case "11":
                    s = "Eleven";
                    break;
                case "12":
                    s = "Twelve";
                    break;
                case "13":
                    s = "Thirteen";
                    break;
                case "14":
                    s = "Fourteen";
                    break;
                case "15":
                    s = "Fiveteen";
                    break;
                case "16":
                    s = "Sixteen";
                    break;
                case "17":
                    s = "Seventeen";
                    break;
                case "18":
                    s = "Eighteen";
                    break;
                case "19":
                    s = "Nineteen";
                    break;
                default:                    
                    s = lastTwoDigits(str[0],str[1]);
                    break;
            }
            return s;
        }

        public string tens(char c)
        {
            string s = null;
            switch(c)
            {
                case '1':
                    s = "Ten";
                    break;
                case '2':
                    s = "Twenty";
                    break;
                case '3':
                    s = "Thirty";
                    break;
                case '4':
                    s = "Forty";
                    break;
                case '5':
                    s = "Fifty";
                    break;
                case '6':
                    s = "Sixty";
                    break;
                case '7':
                    s = "Seventy";
                    break;
                case '8':
                    s = "Eighty";
                    break;
                case '9':
                    s = "Ninety";
                    break;
            }    
            return s;
        }

        public string lastTwoDigits(char c1, char c2)
        {
            string output = null;
            if(c1 != '0' && c2 != '0')
            {
                output = tens(c1)+"-"+charToString1Digit(c2);
            }
            else if(c1 != '0' && c2 =='0')
            {
                output = tens(c1);
            }
            else if(c1 =='0' && c2 !='0')
            {
                output = charToString1Digit(c2);
            }
            return output;
        }
    }
}