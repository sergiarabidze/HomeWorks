using System;

namespace HomeworkExercises
{
    class Program
    {
        static void Main()
        {

             DivisibleBy5();
             Operations();
             Swap();
             MultiplicationTable();
             EvenSquares();
        }


        static void DivisibleBy5()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }


        static void Operations()
        {
            Console.Write("Enter first number (X): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number (Y): ");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            int product = x * y;

            int bigger = Math.Max(x, y);
            int smaller = Math.Min(x, y);

            Console.WriteLine("X + Y = " + sum);
            Console.WriteLine("X - Y = " + (bigger - smaller));
            Console.WriteLine("X * Y = " + product);

            if (smaller == 0)
                Console.WriteLine("Not Allowed To Divide By Zero");
            else
                Console.WriteLine("X / Y = " + (bigger / smaller));
        }


        static void Swap()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine("After swap: x = " + x + "; y = " + y);
        }
        static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }

        static void EvenSquares()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i+=2)
            {
                    Console.WriteLine(i * i);
            }
        }
    }
}
