using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class Teacher
    {
        public string Name { get; set; }
        public bool Certified { get; set; }

        public Teacher(string name, bool certified)
        {
            Name = name;
            Certified = certified;
        }

        public void CheckSubject(string subject)
        {
            if (subject == "მათემატიკა")
            {
                Random rnd = new Random();
                int a = rnd.Next(1, 10);
                int b = rnd.Next(1, 10);
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if (subject == "ქიმია")
            {
                Console.WriteLine("H2O");
            }
            else if (subject == "ინგლისური")
            {
                Console.WriteLine("Hello, how are you?");
            }
            else
            {
                Console.WriteLine($"მე არ ვარ კომპეტენტური საგანში: {subject}");
            }
        }
    }
}
