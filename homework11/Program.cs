using System.Text.Json;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {


    }
    public static void PrintLastLine()
    {
        String filePath = "exercise11.txt";
        Console.WriteLine("line of codes:");
        int n = int.Parse(Console.ReadLine() ?? "0");
        for (int i = 0; i < n; i++)
        {
            String? inputLine = Console.ReadLine();

            File.AppendAllText(filePath, inputLine + Environment.NewLine);

        }
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length > 0)
        {
            string lastLine = lines[^1];
            Console.WriteLine("Last line: " + lastLine);
        }
        else
        {
            Console.WriteLine("File is empty!");
        }

    }

    public static void PrintMultiplicationTable()
    {
        String filePath = "exercise11_2.txt";
        Console.WriteLine("enter input: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    writer.Write($" {i} * {j} = {i * j} |");
                }
                writer.WriteLine();
            }
        }
    }

    public static void XMLString()
    {
        Console.Write("Enter the string to split: ");
        string input = Console.ReadLine() ?? "";
        Console.Write("Enter the number of parts: ");
        int n = int.Parse(Console.ReadLine() ?? "1");
        var parts = SplitString(input, n);
        XDocument doc = CreateXmlFromParts(parts);
        string filePath = "exercise11_3.xml";
        doc.Save(filePath);
        Console.WriteLine($"XML saved to {filePath}");
    }

    private static XDocument CreateXmlFromParts(List<string> parts)
    {
        XElement root = new XElement("root");

        for (int i = 0; i < parts.Count; i++)
        {
            string nodeName = parts[i];
            string nodeContent = $"string {i + 1}";
            XElement node = new XElement(nodeName, nodeContent);
            root.Add(node);
        }

        return new XDocument(root);
    }

    private static List<string> SplitString(string input, int n)
    {
        List<string> parts = new List<string>();
        int partLength = (int)Math.Ceiling((double)input.Length / n);

        for (int i = 0; i < input.Length; i += partLength)
        {
            string part = input.Substring(i, Math.Min(partLength, input.Length - i));
            parts.Add(part);
        }

        return parts;
    }
    static void DaysUntilBirthday()
    {
        string filePath = "birthday.json";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }
        string jsonText = File.ReadAllText(filePath);
        Dates dates = JsonSerializer.Deserialize<Dates>(jsonText);
        if (dates == null || string.IsNullOrEmpty(dates.CurrentDate) || string.IsNullOrEmpty(dates.Birthday))
        {
            Console.WriteLine("Invalid JSON content.");
            return;
        }
        DateTime currentDate = DateTime.Parse(dates.CurrentDate);
        DateTime birthday = DateTime.Parse(dates.Birthday);
        int daysLeft = (birthday - currentDate).Days;
        Console.WriteLine($"Days until birthday: {daysLeft}");
    }


    static void CaesarCipherFromFile()
    {
        String inputFile = "caesar_input.txt";
        String outputFile = "caesar_output.txt";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Input file not found!");
            return;
        }

        string[] lines = File.ReadAllLines(inputFile);
        if (lines.Length < 2)
        {
            Console.WriteLine("Input file must contain word and key (two lines).");
            return;
        }

        string word = lines[0];
        if (!int.TryParse(lines[1], out int key))
        {
            Console.WriteLine("Invalid key in input file.");
            return;
        }
        string ciphered = CaesarEncrypt(word, key);
        File.WriteAllText(outputFile, ciphered);

        Console.WriteLine($"Ciphered word saved to {outputFile}");
        Console.WriteLine($"Ciphered word: {ciphered}");
    }

    static string CaesarEncrypt(string word, int key)
    {
        char[] result = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            int shifted = ((c - 'A') + key) % 26;
            result[i] = (char)('A' + shifted);
        }

        return new string(result);
    }
}
public class Dates
{
    public string CurrentDate { get; set; }
    public string Birthday { get; set; }
}
