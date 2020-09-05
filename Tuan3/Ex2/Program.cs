using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate a = new Coordinate();
            Coordinate b = new Coordinate();

            a.input();
            a.output();
            b.input();
            b.output();

            Console.WriteLine("\n|AB| = " + a.range(b));
        }
    }
}
