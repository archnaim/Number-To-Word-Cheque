namespace ConsoleApplication.Utils
{
    public interface Classification
    {
        [System.Obsolete("use nestedDivision instead",true)]
        string classification(string str);

        string nestedDivision(string str);

        string baseString(long div);
    }
}