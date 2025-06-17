// using Lab1._5.Bai1;
using Lab1._5.Bai2;
using System;
using System.Collections.Generic;

class Program
{
    /*
    static void Main(string[] args)
    {
        List<PhanSo> danhSach = new List<PhanSo>();

        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nPhân số thứ {i + 1}:");
            PhanSo ps = new PhanSo();
            ps.Nhap();
            danhSach.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSach)
        {
            tong = PhanSo.Cong(tong, ps);
        }

        Console.WriteLine($"\nTổng các phân số = {tong}");
    }
    */

    static void Main()
    {
        List<Hinh> danhSach = new List<Hinh>();

        // Dữ liệu mẫu – có thể thay bằng nhập tay nếu cần
        danhSach.Add(new HinhTron(5));
        danhSach.Add(new HinhVuong(4));
        danhSach.Add(new HinhChuNhat(3, 6));
        danhSach.Add(new HinhTamGiac(3, 4, 5));

        double tongChuVi = 0, tongDienTich = 0;

        Console.WriteLine("=== THÔNG TIN CÁC HÌNH ===");
        foreach (var hinh in danhSach)
        {
            double cv = hinh.TinhChuVi();
            double dt = hinh.TinhDienTich();
            tongChuVi += cv;
            tongDienTich += dt;

            Console.WriteLine($"Chu vi: {cv:F2}, Diện tích: {dt:F2}");
        }

        Console.WriteLine($"\n===> Tổng chu vi: {tongChuVi:F2}");
        Console.WriteLine($"\n===> Tổng diện tích: {tongDienTich:F2}");
    }
}
