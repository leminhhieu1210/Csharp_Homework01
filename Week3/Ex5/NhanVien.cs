using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5
{
    class NhanVien
    {
        private string HoTen, DiaChi;
        private int NamSinh;
        private float Luong, HeSo, PhuCap, TongTien;

        public NhanVien()
        {
            HoTen = DiaChi = null;
            NamSinh = 0;
            Luong = HeSo = PhuCap = TongTien = 0;
        }

        public void input()
        {
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Luong co ban: ");
            Luong = float.Parse(Console.ReadLine());

            Console.Write("He so: ");
            HeSo = float.Parse(Console.ReadLine());

            Console.Write("Phu cap: ");
            PhuCap = float.Parse(Console.ReadLine());
        }

        public void output()
        {
            TongTien = Luong * HeSo + PhuCap;

            Console.WriteLine("\n\nDANH SACH NHAN VIEN");
            Console.WriteLine("HO TEN: " + HoTen);
            Console.WriteLine("NAM SINH: " + NamSinh);
            Console.WriteLine("DIA CHI: " + DiaChi);
            Console.WriteLine("TINH LUONG: " + TongTien);
        }
    }
}
