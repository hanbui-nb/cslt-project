using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_project.Session_7
{
    internal class Exercise_5
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static long TinhGiaiThua(int n)
        {
            long tich = 1;
            for (int i = 1; i <= n; i++)
            {
                tich *= i;
            }
            return tich;
        }
        static string DaoNguocChuoi(string input)
        {
            char[] char_array = input.ToCharArray();
            Array.Reverse(char_array);
            return new string(char_array);
        }
        static bool KiemTraNguyenTo(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) count++;
            }
            return count == 2;
        }
        static void InFibonacci(int n)
        {
            long f0 = 0;
            long f1 = 1;
            if (n <= 0) return;
            if (n == 1)
            {
                Console.WriteLine(f0); return;
            }
            Console.Write($"{f0} {f1}");
            for (int i = 3; i <= n; i++)
            {
                long fn = f0 + f1;
                Console.Write($" {fn}");
                f0 = f1;
                f1 = fn;
            }
            Console.WriteLine();
        }
        static int DemNguyenAm(string s)
        {
            int count = 0;
            string thuong = s.ToLower();
            foreach (char c in thuong)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++; 
                }
            }
            return count; 
        }
        static double TinhLuyThua(double x, int y)
        {
            double luythua = 1;
            for (int i = 1; i <= y; i++)
            {
                luythua *= x;
            }
            return luythua;
        }
        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return (double)sum / arr.Length;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Phần 1:
            //Bài 1: Tính tổng hai số nguyên
            Console.Write("Nhập số nguyên thứ nhất: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số nguyên thứ hai: "); int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tổng: {TinhTong(a, b)}");
            //Bài 2: Kiểm tra số chẵn lẻ
            Console.Write("Nhập một số nguyên: "); int n = Convert.ToInt32(Console.ReadLine());
            if (KiemTraChan(n))
            {
                Console.WriteLine($"{n} là số chẵn");
            } 
            else
            {
                Console.WriteLine($"{n} là số lẻ");
            }
            //Bài 3: Tìm số lớn nhất trong ba số
            Console.Write("Nhập số thứ nhất: "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số thứ hai: "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số thứ ba: "); int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Giá trị lớn nhất: {TimMax(a, b, c)}");
            //Bài 4: Tính giai thừa của một số
            Console.Write("Nhập một số nguyên dương n: "); n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Giai thừa của số nguyên dương n (n!): {TinhGiaiThua(n)}");
            //Bài 5: Đảo ngược chuỗi ký tự
            Console.Write("Nhập một chuỗi ký tự: "); string input = Console.ReadLine();
            Console.WriteLine($"Chuỗi bị đảo ngược: {DaoNguocChuoi(input)}");
            //Phần 2:
            //Bài 6: Kiểm tra số nguyên tố
            Console.Write("Input: "); n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: {KiemTraNguyenTo(n)}");
            //Bài 7: In dãy Fibonacci
            Console.Write("Input: "); n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Output: ");
            InFibonacci(n);
            //Bài 8: Đếm số lượng nguyên âm trong chuỗi
            Console.Write("Input: "); string s = Console.ReadLine();
            Console.WriteLine($"Output: {DemNguyenAm(s)}");
            //Bài 9: Tính lũy thừa
            Console.Write("Input: x = "); int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(", y = "); int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: {TinhLuyThua(x, y)}");
            //Bài 10: Tính điểm trung bình của mảng
            int[] numbers = { 4, 5, 6, 7 };
            Console.Write("Input: [4, 5, 6, 7]");
            Console.WriteLine($"Output: {TinhTrungBinh(numbers)}");
        }
    }
}
