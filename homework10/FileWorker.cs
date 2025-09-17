using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10FileWorker
{
    internal abstract class FileWorker
    {
        protected int MaxFileSize;
        public FileWorker(int maxFileSize)
        {
            MaxFileSize = maxFileSize;
        }

        public abstract string FileExtension { get; }

        public abstract void Write();
        public abstract void Read();
        public abstract void Delete();
        public abstract void Edit();

    }
}
