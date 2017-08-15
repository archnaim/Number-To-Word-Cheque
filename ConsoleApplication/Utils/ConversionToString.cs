namespace ConsoleApplication.Utils
{
    public interface ConversionToString
    {
        string charToString1Digit(char c);
        string charToString1Digit(int c);
        string charToString2Digit(string str);
        string tens(char c);

        string lastTwoDigits(char c1, char c2);
    }
}