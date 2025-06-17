using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai1
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Họ tên: "); HoTen = Console.ReadLine();
            Console.Write("Năm sinh: "); NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Giới tính: "); GioiTinh = Console.ReadLine();
            Console.Write("Địa chỉ: "); DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }
}
