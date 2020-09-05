using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            MaTran a = new MaTran();
            MaTran b = new MaTran();
            MaTran c = new MaTran();

            a.input();
            a.output();

            b.input();
            b.output();

            if (a.getter_m() == b.getter_m() && a.getter_n() == b.getter_n())
            {
                c = a.addMatrices(b);
                Console.WriteLine("\nTong cua 2 ma tran:");
                c.output();

                c = a.subMatrices(b);
                Console.WriteLine("\nHieu cua 2 ma tran:");
                c.output();
            }
            else
            {
                Console.WriteLine("\nKhong tinh duoc tong, hieu cua 2 ma tran.");
            }

            if (a.getter_n() == b.getter_m())
            {
                c = a.mulMatrices(b);
                Console.WriteLine("\nTich cua 2 ma tran:");
                c.output();
            }
            else
            {
                Console.WriteLine("\nKhong tinh duoc tich cua 2 ma tran.");
            }
        }
    }
}
