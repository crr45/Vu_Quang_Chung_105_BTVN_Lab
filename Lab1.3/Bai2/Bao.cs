using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai2
{
    class Bao : TaiLieu
    {
        public string NgayPhatHanh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ngày phát hành (dd/MM/yyyy): ");
            NgayPhatHanh = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Ngày PH: {NgayPhatHanh}");
        }

        public override string Loai() => "Bao";
    }

}
