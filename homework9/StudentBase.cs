using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class StudentBase
    {
        public string Name { get; set; }

        public StudentBase(string name)
        {
            Name = name;
        }

        public virtual void Study() { Console.WriteLine($"{Name} studies"); }
        public virtual void Read() { Console.WriteLine($"{Name} reads"); }
        public virtual void Write() { Console.WriteLine($"{Name} writes"); }
        public virtual void Relax() { Console.WriteLine($"{Name} relaxes"); }
    }
}
