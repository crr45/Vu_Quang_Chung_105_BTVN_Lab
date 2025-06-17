using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._5.Bai2
{
    class HinhVuong : Hinh
    {
        public double Canh { get; set; }

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public override double TinhChuVi() => 4 * Canh;
        public override double TinhDienTich() => Canh * Canh;
    }

}
