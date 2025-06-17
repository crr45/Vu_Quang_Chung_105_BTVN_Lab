using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai1
{
    class QLCB
    {
        private List<CanBo> danhSach = new List<CanBo>();

        public void NhapMoi()
        {
            Console.Write("Nhập loại cán bộ (1-Công nhân, 2-Kỹ sư, 3-Nhân viên): ");
            string chon = Console.ReadLine();
            CanBo cb = null;

            switch (chon)
            {
                case "1": cb = new CongNhan(); break;
                case "2": cb = new KySu(); break;
                case "3": cb = new NhanVien(); break;
                default:
                    Console.WriteLine("Chọn không hợp lệ!");
                    return;
            }

            cb.Nhap();
            danhSach.Add(cb);
        }

        public void TimKiemTheoTen()
        {
            Console.Write("Nhập tên cần tìm: ");
            string ten = Console.ReadLine().ToLower();

            bool timThay = false;
            foreach (var cb in danhSach)
            {
                if (cb.HoTen.ToLower().Contains(ten))
                {
                    cb.HienThi();
                    timThay = true;
                }
            }

            if (!timThay)
                Console.WriteLine("Không tìm thấy cán bộ nào.");
        }

        public void HienThiDanhSach()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }

            foreach (var cb in danhSach)
            {
                cb.HienThi();
                Console.WriteLine("------------------------");
            }
        }
    }

}
