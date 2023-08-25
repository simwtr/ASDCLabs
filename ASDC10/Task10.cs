using System;

namespace Task3
{
    class Program
    {
        static int F(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
        
            return F(n - 1) + F(n - 2);
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result = F(N);
            Console.WriteLine(result);
        }
    }
}