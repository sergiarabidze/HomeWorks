using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10FileWorker;

internal class MyFileWorker : FileWorker
{
    private readonly string _extension;
    public override string FileExtension => _extension;

    public MyFileWorker(int maxFileSize, string extension) : base(maxFileSize)
    {
        _extension = extension;
    }


    public override void Delete()
    {
       Console.WriteLine($"I can delete from {FileExtension} file with max storage {MaxFileSize}");
    }

    public override void Edit()
    {
        Console.WriteLine($"I can edit from {FileExtension} file with max storage {MaxFileSize}");
    }

    public override void Read()
    {
       Console.WriteLine($"I can read from {FileExtension} file with max storage {MaxFileSize}");
    }

    public override void Write()
    {
       Console.WriteLine($"I can write to {FileExtension} file with max storage {MaxFileSize}");
    }
}
