using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkSolutions
{
    class Program
    {
        static void Main(string[] args)
        {




        }

        static int CountPowersInRange(int a, int b, int n)
        {
            var count = 0;
            for (var i = (Int) Math.Sqrt(a); Math.Pow(i, n) <= b; i++)
            {
                var power = Math.Pow(i, n);
                if (power >= a && power <= b)
                    count++;
            }
            return count;
        }

        static int CountPairs(string input)
        {
            return input.GroupBy(c => c)
                        .Sum(g => g.Count() / 2);
        }

        static string LongestCommonSuffix(string s1, string s2)
        {
            var i = s1.Length - 1;
            var j = s2.Length - 1;
            var suffix = "";

            while (i >= 0 && j >= 0 && s1[i] == s2[j])
            {
                suffix = s1[i] + suffix;
                i--;
                j--;
            }

            return suffix;
        }

        static void ProcessList<T>(List<T> list)
        {
            if (typeof(T) == typeof(string))
            {
                foreach (var item in list.Cast<string>())
                    Console.WriteLine(item.ToUpper());
            }
            else if (typeof(T) == typeof(int))
            {
                Console.WriteLine(list.Cast<int>().Sum());
            }
            else if (typeof(T) == typeof(bool))
            {
                var boolList = list.Cast<bool>().ToList();
                Console.WriteLine($"First Element is {boolList.First()}");
                Console.WriteLine($"Last Element is {boolList.Last()}");
                Console.WriteLine($"Middle Element is {boolList[boolList.Count / 2]}");
            }
            else
            {
                throw new NotSupportedException($"Type {typeof(T)} is not supported.");
            }
        }

        static void PrintDigitsRecursive(string number, int index = 0)
        {
            if (index >= number.Length) return;

            Console.Write(number[index]);
            if (index < number.Length - 1)
                Console.Write(" - ");

            PrintDigitsRecursive(number, index + 1);
        }


        static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1) return false;

            var first = nums[0];
            var rest = nums.Skip(1).ToArray();

            if (rest.Contains(first)) return true;

            return ContainsDuplicate(rest);
        }


    }
}
