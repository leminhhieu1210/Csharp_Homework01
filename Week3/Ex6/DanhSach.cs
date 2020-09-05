using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    class DanhSach
    {
        private int n;
        private SinhVien[] DS;

        public void nhap()
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());

            DS = new SinhVien[n];
            for (int i = 0; i < n; ++i)
            {
                DS[i] = new SinhVien();
                DS[i].input();
            }
        }

        public void xuat()
        {
            Console.WriteLine("\t\t\tDANH SACH SINH VIEN");
            for (int i = 0; i < n; ++i)
            {
                DS[i].output();
            }
        }

        public void tb8()
        {
            int check = 0;

            Console.WriteLine("\nDANH SACH SINH VIEN CO DIEM TRUNG BINH > 8.0");
            for (int i = 0; i < n; ++i)
            {
                if (DS[i].getterMediumScores() > 8)
                {
                    DS[i].output();
                    check = 1;
                }
            }
            if (check == 0) Console.WriteLine("Khong co sinh vien!");
        }

        public void sapxep()
        {
            //DS.Sort(Compare());
            Console.WriteLine("\nDANH SACH SINH VIEN SAP XEP THEO MASV");
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (String.Compare(DS[i].getterId(), DS[j].getterId()) == 1)
                    {
                        SinhVien t = DS[i];
                        DS[i] = DS[j];
                        DS[j] = t;
                    }
                }
            }
        }
    }
}
