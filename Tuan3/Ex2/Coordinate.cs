using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Coordinate
    {
        private double x, y;

        public Coordinate()
        {
            x = y = 0;
        }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void input()
        {
            Console.Write("Tung do: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Hoanh do: ");
            y = double.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }

        public double range(Coordinate b)
        {
            return Math.Sqrt((x - b.x) * (x - b.x) + (y - b.y) * (y - b.y));
        }
    }
}