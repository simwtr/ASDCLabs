using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            string[] num = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(num[i]);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
