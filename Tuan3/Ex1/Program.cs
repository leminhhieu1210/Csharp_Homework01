using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();

            a.input();
            b.input();

            a.addPs(b).output();
            Console.WriteLine();

            a.subPs(b).output();
            Console.WriteLine();

            a.mulPs(b).output();
            Console.WriteLine();

            if (b.getterTuso() != 0) 
                a.divPs(b).output();
            else
                Console.WriteLine("Khong tinh duoc phep chia!");
        }
    }
}
