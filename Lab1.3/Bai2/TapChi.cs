using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai2
{
    class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số phát hành: "); SoPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Tháng phát hành: "); ThangPhatHanh = int.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số PH: {SoPhatHanh}, Tháng PH: {ThangPhatHanh}");
        }

        public override string Loai() => "TapChi";
    }

}
