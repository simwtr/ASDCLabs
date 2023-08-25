using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int maxEl = a.Max();
            var maxInd = Enumerable.Range(0, n).Where(i => a[i] == maxEl);

            Console.WriteLine(string.Join(" ", maxInd));
        }
    }
}
