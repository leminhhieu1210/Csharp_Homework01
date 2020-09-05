using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh vo so nghiem.");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem: {0}", -c / b);
                }
            }
            else
            {
                double delta, x1, x2;
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem.");
                else if (delta == 0)
                    Console.WriteLine("Phuong trinh co 1 nghiem kep: {0}", -b / (2 * a));
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet la: x1 = {0}, x2 = {1}", x1, x2);
                }
            }
        }
    }
}