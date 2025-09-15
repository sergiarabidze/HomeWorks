using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int[] Hours { get; set; }

        public Employee(string firstName, string lastName, int age, string position, int[] hours)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
            Hours = hours;
        }

        private int GetRate()
        {
            return Position switch
            {
                "მენეჯერი" => 40,
                "დეველოპერი" => 30,
                "ტესტერი" => 20,
                _ => 10
            };
        }

        public double WeeklySalary()
        {
            int totalHours = Hours.Sum();
            double salary = 0;

            for (int i = 0; i < Hours.Length; i++)
            {
                int dailyHours = Hours[i];
                int normalHours = Math.Min(dailyHours, 8);
                int overtime = Math.Max(0, dailyHours - 8);

                double dailyPay = normalHours * GetRate() + overtime * (GetRate() + 5);

                if (i >= 5) // შაბათი ან კვირა
                    dailyPay *= 2;

                salary += dailyPay;
            }

            if (totalHours > 50)
                salary *= 1.2;

            return salary;
        }
    }
}
