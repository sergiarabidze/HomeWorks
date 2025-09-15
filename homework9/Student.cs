using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }

        private static string[] Subjects = { "მათემატიკა", "ქიმია", "ინგლისური", "ისტორია" };

        public Student(string name, int age, int year)
        {
            Name = name;
            Age = age;
            Year = year;
        }

        public string GetRandomSubject()
        {
            Random rnd = new Random();
            return Subjects[rnd.Next(Subjects.Length)];
        }

        public int YearsLeft()
        {
            return 4 - (DateTime.Now.Year - Year);
        }
    }
}
