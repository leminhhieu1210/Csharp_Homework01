using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());

            NhanVien []nv = new NhanVien[n];
            for (int i = 0; i < n; ++i)
            {
                nv[i] = new NhanVien();
                nv[i].input();
            }

            for (int i = 0; i < n; ++i)
            {
                nv[i].output();
            }
        }
    }
}
