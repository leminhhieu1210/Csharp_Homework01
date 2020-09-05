using System;

namespace Ex4
{
    class Program
    {
        public static bool isPerfect(int n) 
        {
            if (n % 2 == 1) return false;
            int sum = 1;
            for (int i = 2; i * i <= n; ++i) 
            {
                if (n % i == 0)
                {
                    if (i * i == n) sum += i;
                    else sum += i + n / i;
                } 
            }
            if (sum == n) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            if (isPerfect(n)) Console.WriteLine(n + " la so hoan hao.");
            else Console.WriteLine(n + " khong phai so hoan hao.");
        }
    }
}