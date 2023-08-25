using System;

namespace Task1
{
    class Program
    {
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int divider = a % b;
                a = b;
                b = divider;
            }
            return a;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            int nod = NOD(a, b);
            Console.WriteLine("Наибольший общий делитель: " + nod);
        }
    }
}