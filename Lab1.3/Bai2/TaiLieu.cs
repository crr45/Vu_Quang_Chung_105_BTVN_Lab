using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai2
{
    class TaiLieu
    {
        public string MaTL { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Mã tài liệu: "); MaTL = Console.ReadLine();
            Console.Write("Nhà xuất bản: "); NhaXuatBan = Console.ReadLine();
            Console.Write("Số bản phát hành: "); SoBanPhatHanh = int.Parse(Console.ReadLine());
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Mã TL: {MaTL}, NXB: {NhaXuatBan}, Số bản: {SoBanPhatHanh}");
        }

        public virtual string Loai() => "TaiLieu";
    }

}
