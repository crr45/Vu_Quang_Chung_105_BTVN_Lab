using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3.Bai1
{
    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ngành đào tạo: "); NganhDaoTao = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
        }
    }
}
