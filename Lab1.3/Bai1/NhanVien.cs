using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai1
{
    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Công việc: "); CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }

}
