using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    class MaTran
    {
        private int m;
        private int n;
        private int[,] a;

        public MaTran()
        {
            m = n = 0;
            a = new int[0, 0];
        }

        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = 0;
                }
            }
        }

        public void input()
        {
            Console.Write("So hang cua ma tran: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("So cot cua ma tran: ");
            n = int.Parse(Console.ReadLine());

            a = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void output()
        {
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int getter_m()
        {
            return m;
        }

        public int getter_n()
        {
            return n;
        }

        public MaTran addMatrices(MaTran arr2)
        {
            MaTran mt = new MaTran(m, n);

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    mt.a[i, j] = a[i, j] + arr2.a[i, j]; 
                }
            }

            return mt;
        }

        public MaTran subMatrices(MaTran arr2)
        {
            MaTran mt = new MaTran(m, n);

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    mt.a[i, j] = a[i, j] - arr2.a[i, j];
                }
            }

            return mt;
        }

        public MaTran mulMatrices(MaTran arr2)
        {
            MaTran mt = new MaTran(m, arr2.n);

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < arr2.n; ++j)
                {
                    mt.a[i, j] = 0;
                    for (int k = 0; k < n; ++k)
                    {
                        mt.a[i, j] += a[i, k] * arr2.a[k, j];
                    }
                }
            }

            return mt;
        }
    }
}
