using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5.Bai2
{
    class HinhTamGiac : Hinh
    {
        public double A, B, C;

        public HinhTamGiac(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }

        public override double TinhChuVi() => A + B + C;

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Công thức Heron
        }
    }

}
