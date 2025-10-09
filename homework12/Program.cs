internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(UnicalChar("hahads"));
        Console.WriteLine(PartsOfString(" Hello world this is C# "));
    }

    public static int UnicalChar(String str)
    {
        for (int i = 0; i < str.Length; i++)
        {

            if (!str.Remove(i,1).Contains(str[i]))
            {
                return i;
            }
        }
        return -1;
    }

    public static int PartsOfString(String str)
    {
       return str.Trim().Count(Char.IsWhiteSpace) + 1;
    }

    public static int Max(int[] arr)
    {
        return arr.Distinct().Max();
    }
}