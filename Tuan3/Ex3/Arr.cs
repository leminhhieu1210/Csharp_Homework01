using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex3
{
    class Arr
    {
        private int n;
        private int[] a;

        public Arr()
        {
            n = 0;
            a = new int[n];
        }

        public Arr(int n)
        {
            this.n = n;
            a = new int[n];
        }

        public void input()
        {
            Console.Write("Nhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());

            a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void output()
        {
            for (int i = 0; i < n; ++i)
            {
                Console.Write("{0}\t", a[i]);
            }
        }

        public void sapxep(int thutu)
        {
            /*
             * https://www.geeksforgeeks.org/different-ways-to-sort-an-array-in-descending-order-in-c-sharp/
             */
            if (thutu == 0) Array.Sort(a);
            else a = a.OrderByDescending(c => c).ToArray();
        }

        public int timkiem(int m)
        {
            return Array.IndexOf(a, m);
        }
    }
}