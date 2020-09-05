using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Tong = {0}", a + b);
            Console.WriteLine("Hieu = {0}", a - b);
            Console.WriteLine("Tich = {0}", a * b);
            if (b != 0) Console.WriteLine("Thuong = {0}", a / b);
            else Console.WriteLine("Khong tinh duoc thuong.");
        }
    }
}