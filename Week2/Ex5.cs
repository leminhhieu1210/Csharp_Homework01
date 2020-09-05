using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);

            foreach (int i in arr) Console.Write(i + " ");
        }
    }
}