using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai1
{
    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Bậc (ví dụ: 3/7): "); Bac = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bậc công nhân: {Bac}");
        }
    }
}
