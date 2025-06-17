using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai2
{
    class Sach : TaiLieu
    {
        public string TacGia { get; set; }
        public int SoTrang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tên tác giả: "); TacGia = Console.ReadLine();
            Console.Write("Số trang: "); SoTrang = int.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Tác giả: {TacGia}, Số trang: {SoTrang}");
        }

        public override string Loai() => "Sach";
    }

}
