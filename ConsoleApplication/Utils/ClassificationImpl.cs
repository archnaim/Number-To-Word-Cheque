using System;

namespace ConsoleApplication.Utils
{
    public class ClassificationImpl:Classification
    {
        readonly ConversionToString cts = new ConversionToStringImpl();
        
        //this method is obsolete, it was used as the first prototype of this program as its foundation.
        //I decided to write more reusable method that is nestedDivision()
        [System.Obsolete("use nestedDivision instead", true)]
        public string classification(string str)
        {
            int length = str.Length;
            char[] lastTwoDigits = new char[2];
            if(length>2)
            {
                lastTwoDigits[0] = str[length-2];
                lastTwoDigits[1] = str[length-1];
            }
            string result = null;
            switch (str.Length)
            {
                case 1:
                    result = cts.charToString1Digit(str[0]);
                    break;
                case 2: 
                    result = cts.charToString2Digit(str);
                    break;
                case 3:
                    result = cts.charToString1Digit(str[0])+" Hundred";
                    if (new string(lastTwoDigits) != "00")
                    {
                        result = result +" And "+ cts.charToString2Digit(new string(lastTwoDigits));
                    }
                    
                    break;
                case 4:
                    result = cts.charToString1Digit(str[0])+result +" Thousand ";
                    if(str[1] != '0')
                    {
                        result = result + cts.charToString1Digit(str[1]) +" Hundred And "; 
                    }
                    result = result +cts.charToString2Digit(new string(lastTwoDigits));
                    break;

                case 5:
                    result = cts.charToString2Digit(new string(new char[] { str[0], str[1] }))+" Thousand ";
                    if(str[2] != '0')
                    {
                        result = result + cts.charToString1Digit(str[2]) +" Hundred And "; 
                    }
                    result = result + cts.charToString2Digit(new string(lastTwoDigits));
                    break;

                case 6:
                    result = cts.charToString1Digit(str[0])+" Hundred";
                    if(str[1] !='0' || str[2] !='0')
                    {
                        result = result+" And " + cts.charToString2Digit(new string(new char[] { str[1], str[2] }));
                    }
                    result = result +" Thousand ";
                    if(str[3] != '0')
                    {
                        result = result + cts.charToString1Digit(str[3]) +" Hundred"; 
                    }
                    if (new string(lastTwoDigits) != "00")
                    {
                        result = result +" And "+ cts.charToString2Digit(new string(lastTwoDigits));
                    }
                    break;
                case 7:
                    result = cts.charToString1Digit(str[0])+" Million";
                    if (str[1] != '0')
                    {
                        result = result+" "+ cts.charToString1Digit(str[1])+" Hundred";
                    }
                    if(str[2] !='0' || str[3] !='0')
                    {
                        result = result+" And " + cts.charToString2Digit(new string(new char[] { str[2], str[3] }));
                    }
                    if(str[1] != '0' || str[2] != '0' || str[3] != '0')
                    {
                        result = result +" Thousand ";       
                    }
                    if(str[4] != '0')
                    {
                        result = result + cts.charToString1Digit(str[4]) +" Hundred"; 
                    }
                    if (new string(lastTwoDigits) != "00")
                    {
                        result = result +" And "+ cts.charToString2Digit(new string(lastTwoDigits));
                    }
                    break;
                case 8:
                    result = cts.charToString2Digit(new string(new char[] { str[0], str[1] }))+" Million";
                    if (str[2] != '0')
                    {
                        result = result+ " "+cts.charToString1Digit(str[2])+" Hundred";
                    }
                    if(str[3] !='0' || str[4] !='0')
                    {
                        result = result+" And " + cts.charToString2Digit(new string(new char[] { str[3], str[4] }));
                    }
                    if(str[2] != '0' || str[3] != '0' || str[4] != '0')
                    {
                        result = result +" Thousand ";       
                    }
                    if(str[5] != '0')
                    {
                        result = result + cts.charToString1Digit(str[5]) +" Hundred"; 
                    }
                    if (new string(lastTwoDigits) != "00")
                    {
                        result = result +" And "+ cts.charToString2Digit(new string(lastTwoDigits));
                    }
                    break;

                case 9:
                    result = cts.charToString1Digit(str[0])+" Hundred";
                    if(str[1] != '0' || str[2] !='0')
                    {
                        result = result+" And "+cts.charToString2Digit(new string(new char[] { str[1], str[2] }));                                
                    }
                    result = result +" Million";
                    if (str[3] != '0')
                    {
                        result = result+ " "+cts.charToString1Digit(str[3])+" Hundred";
                    }
                    if(str[4] !='0' || str[5] !='0')
                    {
                        result = result+" And " + cts.charToString2Digit(new string(new char[] { str[4], str[5] }));
                    }
                    if(str[3] != '0' || str[4] != '0' || str[5] != '0')
                    {
                        result = result +" Thousand ";       
                    }
                    if(str[6] != '0')
                    {
                        result = result + cts.charToString1Digit(str[6]) +" Hundred"; 
                    }
                    if (new string(lastTwoDigits) != "00")
                    {
                        result = result +" And "+ cts.charToString2Digit(new string(lastTwoDigits));
                    }
                    break;
                default: throw new NotImplementedException();
            }
            return result;
        }

        public string nestedDivision(string str)
        {
            string output = null;
            long div = (long)Math.Pow(10,Convert.ToInt64(str.Length - 1));
            long input = Convert.ToInt64(str);
            int temp = 0;
            while(div>10 && input!=0)
            {
                temp = (int)(input/div);
                
                if(temp>0)
                {
                    //2 digits
                    if((Math.Log10(div)+2)%3==0)
                    {
                        div = div/10;
                        temp = (int)(input/div);
                        output = output+ cts.charToString2Digit(Convert.ToString(temp));
//                        Console.WriteLine(div);
                        output = output + baseString(div);
                    }
                    //1 digit
                    else
                    {
                        output = output + cts.charToString1Digit(temp);
                        
                        if(Math.Log10(div)==2 ||((Math.Log10(div)+1)%3==0 && Math.Log10(div)>3))
                        {
                            output = output + " Hundred ";
                            if (input%100 != 0)
                            {
                                output = output + "And ";
                            }
                        }
                        else if(Math.Log10(div)%3==0)
                        {
                            output = output + baseString(div);
                        }
                    }
                    
                }
                input = input - (long)(temp*div);
                // Console.WriteLine(input);
                div = div/10;
                // Console.WriteLine(div);
                
            }
            if (input>9)
            {
                output = output + cts.charToString2Digit(Convert.ToString(input));
            }
            else
            {
                output = output + cts.charToString1Digit((int)input);
            }
            return output;
        }

        public string baseString(long div)
        {
            string output = null;
            switch (div)
            {
                case 1000:
                    output = " Thousand ";
                    break;
                case 1000000:
                    output = " Million ";
                    break;
                case 1000000000:
                    output = " Billion ";
                    break;
                default:
                    throw new NotImplementedException();
            }

            return output;
        }
    }
}