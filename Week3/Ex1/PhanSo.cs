using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public PhanSo()
        {
            TuSo = 1;
            MauSo = 0;
        }

        public void input()
        {
            Console.Write("Tu so: ");
            TuSo = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Mau so: ");
                MauSo = int.Parse(Console.ReadLine());

                if (MauSo == 0) 
                    Console.WriteLine("Mau so khong hop le!");
            } while (MauSo == 0);     
        }

        public void output()
        {
            Console.Write("{0}/{1}", TuSo, MauSo);
        }

        public int getterTuso()
        {
            return TuSo;
        }

        public int findGCD(int a, int b)
        {
            int t;
            while (b != 0)
            {
                t = a % b;
                a = b;
                b = t;
            }
            return a;
        }

        public void reduceFraction()
        {
            int gcd = findGCD(TuSo, MauSo);
            TuSo = TuSo / gcd;
            MauSo = MauSo / gcd;
        }

        public PhanSo addPs(PhanSo p)
        {
            PhanSo ps = new PhanSo();

            ps.TuSo = TuSo * p.MauSo + MauSo * p.TuSo;
            ps.MauSo = MauSo * p.MauSo;
            ps.reduceFraction();

            this.output();
            Console.Write(" + ");
            p.output();
            Console.Write(" = ");

            return ps;
        }

        public PhanSo subPs(PhanSo p)
        {
            PhanSo ps = new PhanSo();

            ps.TuSo = TuSo * p.MauSo - MauSo * p.TuSo;
            ps.MauSo = MauSo * p.MauSo;
            ps.reduceFraction();

            this.output();
            Console.Write(" - ");
            p.output();
            Console.Write(" = ");

            return ps;
        }

        public PhanSo mulPs(PhanSo p)
        {
            PhanSo ps = new PhanSo();

            ps.TuSo = TuSo * p.TuSo;
            ps.MauSo = MauSo * p.MauSo;
            ps.reduceFraction();

            this.output();
            Console.Write(" * ");
            p.output();
            Console.Write(" = ");

            return ps;
        }

        public PhanSo divPs(PhanSo p)
        {
            PhanSo ps = new PhanSo();

            ps.TuSo = TuSo * p.MauSo;
            ps.MauSo = MauSo * p.TuSo;
            ps.reduceFraction();

            this.output();
            Console.Write(" / ");
            p.output();
            Console.Write(" = ");

            return ps;
        }
    }
}
