using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12
{
    public interface IFileStrategy
    {
        void Execute(string filePath);
    }

    public class ZipFileStrategy : IFileStrategy
    {
        public void Execute(string filePath)
        {
            string backupDir = "backup";
            if (!Directory.Exists(backupDir))
                Directory.CreateDirectory(backupDir);

            Console.WriteLine($"Unzipping {filePath} to {backupDir}/");
        }
    }

    public class JsonFileStrategy : IFileStrategy
    {
        public void Execute(string filePath)
        {
            string content = File.Exists(filePath)
                ? File.ReadAllText(filePath)
                : "File not found!";
            Console.WriteLine(content);
        }
    }

    public class TxtFileStrategy : IFileStrategy
    {
        public void Execute(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"{filePath} deleted.");
            }
            else Console.WriteLine("File not found.");
        }
    }

    public class FileContext
    {
        private readonly IFileStrategy _strategy;
        public FileContext(IFileStrategy strategy) => _strategy = strategy;

        public void Handle(string path) => _strategy.Execute(path);
    }

}
