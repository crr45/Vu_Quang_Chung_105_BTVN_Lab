using System;

class Program
{
    // Bai 1:
    /*
    static int TongChan(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            if (num % 2 == 0) sum += num;
        return sum;
    }

    static void Main()
    {
        int[] mang = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Tổng số chẵn: " + TongChan(mang));
    }
    */

    // Bai 2:
    /*
    static bool LaNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Main()
    {
        int[] mang = { 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < mang.Length; i++)
        {
            if (LaNguyenTo(mang[i]))
                Console.WriteLine($"Phần tử nguyên tố tại chỉ số {i}: {mang[i]}");
        }
    }
    */

    //Bai 3:
    /*
      static void DemAmDuong(int[] arr, out int demAm, out int demDuong)
    {
        demAm = 0; demDuong = 0;
        foreach (int x in arr)
        {
            if (x < 0) demAm++;
            else if (x > 0) demDuong++;
        }
    }

    static void Main()
    {
        int[] mang = { -3, 0, 4, -1, 5, 7, -2 };
        DemAmDuong(mang, out int am, out int duong);
        Console.WriteLine($"Số âm: {am}, Số dương: {duong}");
    }
     */

    //Bai 4:
    /*
     static int TimSoLonThuHai(int[] arr)
    {
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int x in arr)
        {
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2 && x != max1)
                max2 = x;
        }
        return max2;
    }

    static void Main()
    {
        int[] mang = { 5, 1, 7, 9, 4 };
        Console.WriteLine("Số lớn thứ 2: " + TimSoLonThuHai(mang));
    }
     */

    //Bai 5:
    /*
      static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine($"Trước hoán vị: a = {a}, b = {b}");
        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau hoán vị: a = {a}, b = {b}");
    }
     */

    //Bai 6:
    /*
     static void SapXepTang(float[] arr)
    {
        Array.Sort(arr);
    }

    static void Main()
    {
        float[] mang = { 3.2f, 1.1f, 4.5f, 2.3f };
        SapXepTang(mang);
        Console.WriteLine("Mảng sau khi sắp xếp:");
        foreach (float x in mang)
            Console.Write(x + " ");
    }
     */


}
