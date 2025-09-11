using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area(5);

            //var jackpot1 = new[] { "@", "@", "@", "@", "@", "@" };
            //var jackpot2 = new[] { "@", "a", "@", "@", "@", "@" };
            //Console.WriteLine(IsJackpot(jackpot1));
            //Console.WriteLine(IsJackpot(jackpot2));

            //var footballResults = new Dictionary<string, int>
            //{
            //    { "მოგება", 2 },
            //    { "ფრე", 1 },
            //    { "წაგება", 3 }
            //};
            //Console.WriteLine(CalculatePoints(footballResults));

            var hours1 = new[] { 8, 8, 8, 8, 8, 0, 0 };
            //var hours2 = new[] { 8, 8, 8, 8, 8, 8, 0 };
            //var hours3 = new[] { 4, 4, 4, 4, 4, 0, 4 };
            //var hours4 = new[] { 5, 8, 8, 8, 8, 8, 8 };
            Console.WriteLine(CalculateWeeklySalary(hours1));
            //Console.WriteLine(CalculateWeeklySalary(hours2));
            //Console.WriteLine(CalculateWeeklySalary(hours3));
            //Console.WriteLine(CalculateWeeklySalary(hours4));

            //var training1 = new[] { 5, 8, 8, 9, 10 };
            //var training2 = new[] { 5, 5, 5, 5 };
            //Console.WriteLine(CountProgress(training1));
            //Console.WriteLine(CountProgress(training2));

            //var words = new[] { "Hello", "World", "Programming", "communication" };
            //PrintWordsOfLength(words, 7);
            //PrintWordsOfLength(words, 15);
        }


        static void Area(double radius)
        {
            var smallRectangleArea = 2 * radius * radius;
            var bigRectangleArea =  4 * radius * radius;
            var difference = bigRectangleArea - smallRectangleArea;
            Console.WriteLine($"Difference: {difference:F2}");
        }

        static string IsJackpot(string[] input)
        {
            return input.All(x => x == input[0]) ? "Yes" : "No";
        }
        static int CalculatePoints(Dictionary<string, int> results)
        {
            int points = 0;

            if (results.ContainsKey("მოგება"))
                points += results["მოგება"] * 3;

            if (results.ContainsKey("ფრე"))
                points += results["ფრე"] * 1;

            if (results.ContainsKey("წაგება"))
                points += results["წაგება"] * 0;

            return points;
        }

        static int CalculateWeeklySalary(int[] hours)
        {
            var total = 0;
            for (var i = 0; i < hours.Length; i++)
            {
                var h = hours[i];
                var baseHours = Math.Min(8, h);
                var overtimeHours = Math.Max(0, h - 8);

                var rate = 10;
                if (i >= 5)
                    rate *= 2;

                total += baseHours * rate + overtimeHours * (rate + 5);
            }
            return total;
        }
        static int CountProgress(int[] training)
        {
            return training
                .Skip(1)
                .Select((val, idx) => val > training[idx] ? 1 : 0)
                .Sum();
        }

        static void PrintWordsOfLength(string[] words, int N)
        {
            var result = words.Where(w => w.Length >= N);

            if (result.Any())
                Console.WriteLine(string.Join(", ", result));
            else
                Console.WriteLine("No elements found");
        }

    }
}
