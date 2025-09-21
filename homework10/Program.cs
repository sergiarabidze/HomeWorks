
using homework10FileWorker;
using homework10FinanceOperations;

namespace homework10;

    internal class Program
    {
        static void Main(string[] args)
        {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "example.txt");
        File.WriteAllText(path, "test1");
        Console.WriteLine("File created at: " + path);
        string text = File.ReadAllText("example.txt");
        Console.WriteLine("File contents:");
        Console.WriteLine(text);

    }
    }