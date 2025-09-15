using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class LazyStudent : StudentBase
    {
        public LazyStudent(string name) : base(name) { }

        public override void Study() { Console.WriteLine($"{Name} barely studies"); }
        public override void Read() { Console.WriteLine($"{Name} rarely reads"); }
        public override void Write() { Console.WriteLine($"{Name} writes sloppily"); }
        public override void Relax() { Console.WriteLine($"{Name} relaxes all day"); }
    }
}
