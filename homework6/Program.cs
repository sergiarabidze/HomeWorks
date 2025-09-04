using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            //FilterEvenOdd();
            //ContactsApp();
            //CountOccurrences();
            //TopNResults();
        }

        static void FilterEvenOdd()
        {
            Console.WriteLine("Enter array size:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] evens = arr.Where(x => x % 2 == 0).ToArray();
            int[] odds = arr.Where(x => x % 2 != 0).ToArray();

            Console.WriteLine("Array #1 (Even): " + string.Join(" ", evens));
            Console.WriteLine("Array #2 (Odd): " + string.Join(" ", odds));
        }

        static void ContactsApp()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("\nChoose option: add, update, delete, list, exit");
                string choice = Console.ReadLine().ToLower();

                if (choice == "add")
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone: ");
                    string phone = Console.ReadLine();
                    contacts[name] = phone;
                    Console.WriteLine("Contact added!");
                }
                else if (choice == "update")
                {
                    Console.Write("Enter name to update: ");
                    string name = Console.ReadLine();
                    if (contacts.ContainsKey(name))
                    {
                        Console.Write("Enter new phone: ");
                        string phone = Console.ReadLine();
                        contacts[name] = phone;
                        Console.WriteLine("Contact updated!");
                    }
                    else Console.WriteLine("Contact not found.");
                }
                else if (choice == "delete")
                {
                    Console.Write("Enter name to delete: ");
                    string name = Console.ReadLine();
                    if (contacts.Remove(name))
                        Console.WriteLine("Contact deleted!");
                    else
                        Console.WriteLine("Contact not found.");
                }
                else if (choice == "list")
                {
                    Console.WriteLine("All contacts:");
                    foreach (var c in contacts)
                        Console.WriteLine($"{c.Key}: {c.Value}");
                }
                else if (choice == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }

        static void CountOccurrences()
        {
            Console.WriteLine("Enter array size:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var groups = arr.GroupBy(x => x);

            foreach (var g in groups)
            {
                int count = g.Count();
                int sum = g.Sum();
                Console.WriteLine($"{g.Key} appears {count} times sum {sum}");
            }
        }

        static void TopNResults()
        {
            Console.WriteLine("Enter array size:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter how many top results you want:");
            int topN = int.Parse(Console.ReadLine());

            var topResults = arr.OrderByDescending(x => x).Take(topN);
            Console.WriteLine("Top results: " + string.Join(" ", topResults));
        }
    }
}
