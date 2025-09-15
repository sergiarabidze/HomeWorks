using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class GoodStudent : StudentBase
    {
        public GoodStudent(string name) : base(name) { }

        public override void Study() { Console.WriteLine($"{Name} studies hard"); }
        public override void Read() { Console.WriteLine($"{Name} reads a lot"); }
        public override void Write() { Console.WriteLine($"{Name} writes neatly"); }
        public override void Relax() { Console.WriteLine($"{Name} relaxes productively"); }
    }
}
