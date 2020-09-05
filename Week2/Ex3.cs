using System;

namespace Ex3
{
    class Program
    {
        public static bool isPrime(int n) 
        {
            if (n == 2) return true;
            if (n < 2 || n % 2 == 0) return false;
            int h = (int) Math.Sqrt((double) n);
            for (int i = 3; i <= h; i += 2) 
            {
                if (n % i == 0) 
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            if (isPrime(n)) Console.WriteLine(n + " la so nguyen to.");
            else Console.WriteLine(n + " khong phai so nguyen to.");
        }
    }
}