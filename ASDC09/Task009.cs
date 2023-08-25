using System;

namespace Task2
{
    class Program
    {
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int divider = b;
                b = a % b;
                a = divider;
            }
            return a;
        }

        static int NOK(int a, int b)
        {
            return (a * b) / NOD(a, b);
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int result = NOK(A, B);
            Console.WriteLine(result);
        }
    }
}
