using System;

class Program
{
    static void Main()
    {
        //Bai 1.
        //        Console.Write("Nhập tên: ");
        //        string ten = Console.ReadLine();

        //        Console.Write("Nhập tuổi: ");
        //        int tuoi = int.Parse(Console.ReadLine());

        //        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");



        // Bai 2. Tính diện tích hình chữ nhật

        /*
       
                Console.Write("Nhập chiều dài: ");
                double dai = double.Parse(Console.ReadLine());

                Console.Write("Nhập chiều rộng: ");
                double rong = double.Parse(Console.ReadLine());

                double dientich = dai * rong;
                Console.WriteLine("Diện tích hình chữ nhật là: " + dientich);
          
        */

        //Bai 3. Đổi độ C sang độ F
        /*
        
                Console.Write("Nhập nhiệt độ C: ");
                double c = double.Parse(Console.ReadLine());

                double f = (c * 9 / 5) + 32;
                Console.WriteLine("Nhiệt độ F là: " + f);
          
        */

        //Bai 4. Kiểm tra số chẵn
        /*
        
                Console.Write("Nhập số nguyên: ");
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                    Console.WriteLine(n + " là số chẵn");
                else
                    Console.WriteLine(n + " là số lẻ");
        */

        // Bài 5: Tính tổng và tích của hai số
        /*
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Tổng: " + (a + b));
        Console.WriteLine("Tích: " + (a * b));
        */

        //Bài 6: Kiểm tra dương, âm hay 0
        /*
            Console.Write("Nhập một số: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Số dương");
        else if (n < 0)
            Console.WriteLine("Số âm");
        else
            Console.WriteLine("Số không");
         */

        //Bài 7: Kiểm tra năm nhuận
        /*
          Console.Write("Nhập năm: ");
        int nam = int.Parse(Console.ReadLine());

        bool laNamNhuan = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);

        if (laNamNhuan)
            Console.WriteLine(nam + " là năm nhuận");
        else
            Console.WriteLine(nam + " không phải là năm nhuận");
         */

        //Bài 8: In bảng cửu chương 1–10
        /*
         for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"Bảng cửu chương {i}:");
            for (int j = 1; j <= 10; j++) {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
         */

        //Bài 9: Tính giai thừa n!
        
         Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        long giaithua = 1;
        for (int i = 1; i <= n; i++) {
            giaithua *= i;
        }

        Console.WriteLine($"{n}! = {giaithua}");
         

        //Bài 10: Kiểm tra số nguyên tố
        /*
         Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        bool laSoNguyenTo = true;

        if (n < 2)
            laSoNguyenTo = false;
        else {
            for (int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) {
                    laSoNguyenTo = false;
                    break;
                }
            }
        }

        if (laSoNguyenTo)
            Console.WriteLine(n + " là số nguyên tố");
        else
            Console.WriteLine(n + " không phải là số nguyên tố");
         */
    }
}




