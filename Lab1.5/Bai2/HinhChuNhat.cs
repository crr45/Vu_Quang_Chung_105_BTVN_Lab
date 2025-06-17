using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5.Bai2
{
    class HinhChuNhat : Hinh
    {
        public double Dai, Rong;

        public HinhChuNhat(double dai, double rong)
        {
            Dai = dai; Rong = rong;
        }

        public override double TinhChuVi() => 2 * (Dai + Rong);
        public override double TinhDienTich() => Dai * Rong;
    }

}
