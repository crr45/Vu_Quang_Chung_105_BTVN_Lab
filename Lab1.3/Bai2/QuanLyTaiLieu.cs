using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai2
{
    class QuanLyTaiLieu
    {
        private List<TaiLieu> danhSach = new List<TaiLieu>();

        public void NhapMoi()
        {
            Console.Write("Nhập loại tài liệu (1 - Sách, 2 - Tạp chí, 3 - Báo): ");
            string chon = Console.ReadLine();
            TaiLieu tl = null;

            switch (chon)
            {
                case "1": tl = new Sach(); break;
                case "2": tl = new TapChi(); break;
                case "3": tl = new Bao(); break;
                default:
                    Console.WriteLine("Loại tài liệu không hợp lệ!");
                    return;
            }

            tl.Nhap();
            danhSach.Add(tl);
        }

        public void HienThiTatCa()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách tài liệu trống.");
                return;
            }

            foreach (var tl in danhSach)
            {
                Console.WriteLine("\n--- Thông tin tài liệu ---");
                tl.HienThi();
            }
        }

        public void TimKiemTheoLoai()
        {
            Console.Write("Nhập loại cần tìm (Sach / TapChi / Bao): ");
            string loai = Console.ReadLine();

            bool timThay = false;
            foreach (var tl in danhSach)
            {
                if (tl.Loai().Equals(loai, StringComparison.OrdinalIgnoreCase))
                {
                    tl.HienThi();
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy tài liệu phù hợp.");
        }
    }

}
