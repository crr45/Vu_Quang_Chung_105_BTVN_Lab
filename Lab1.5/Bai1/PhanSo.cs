using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5.Bai1
{
    class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau == 0 ? 1 : mau; // Tránh chia cho 0
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            Tu = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            Mau = int.Parse(Console.ReadLine());
            if (Mau == 0)
            {
                Console.WriteLine("Mẫu phải khác 0, gán mẫu = 1");
                Mau = 1;
            }
        }

        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tuMoi = a.Tu * b.Mau + b.Tu * a.Mau;
            int mauMoi = a.Mau * b.Mau;
            return RutGon(new PhanSo(tuMoi, mauMoi));
        }

        public static PhanSo RutGon(PhanSo p)
        {
            int ucln = UCLN(Math.Abs(p.Tu), Math.Abs(p.Mau));
            return new PhanSo(p.Tu / ucln, p.Mau / ucln);
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }
    }
}
