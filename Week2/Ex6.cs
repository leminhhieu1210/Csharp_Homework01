using System;

namespace Ex6
{
    class Program
    {
        public static double range(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        public static double sumOfSegments(double[] x, double[] y)
        {
            double sum = range(x[0], y[0], x[1], y[1]);
            for (int i = 1; i < x.Length - 1; ++i)
            {
                sum += range(x[i], y[i], x[i + 1], y[i + 1]);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            double[] x = new double[n];
            double[] y = new double[n];
            for (int i = 0; i < n; ++i)
            {
                x[i] = double.Parse(Console.ReadLine());
                y[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Do dai duong gap khuc = " + sumOfSegments(x, y));
        }
    }
}