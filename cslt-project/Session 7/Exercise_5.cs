using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
        static bool KiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        static double CelsiusToFahrenheit(double c)
        {
            return c * 1.8 + 32;
        }
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int TongCacChuSo(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void SapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"Output: {string.Join(" ", arr)}"); 
        }
        static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c))
                    result += c;
            }
            return result;
        }
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static string DecimalToBinary(int n)
        {
            string r = "";
            string result = "";
            if (n == 0) return "0";
            while (n > 0)
            {
                r += n % 2;
                n = n / 2;
            }
            for (int i = r.Length - 1; i >= 0; i--)
            {
                result += r[i];
            }
            return result;
        }
        static bool KiemTraNamNhuan(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) return true;
            else return false;
        }
        static int DemSoTu(string sentence)
        {
            sentence = sentence.Trim();
            if (string.IsNullOrEmpty(sentence)) return 0;
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ' && sentence[i + 1] != ' ')
                {
                    count++;
                }
            }
            return count + 1;
        }
        public static void Main7(string[] args)
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
            Console.WriteLine("Input: [4, 5, 6, 7]");
            Console.WriteLine($"Output: {TinhTrungBinh(numbers)}");
            
            //Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
            Console.Write("Input: "); s = Console.ReadLine();
            Console.WriteLine($"Output: {KiemTraDoiXung(s)}");

            //Bài 12: Chuyển đổi nhiệt độ
            Console.Write("Input: "); double C = Convert.ToDouble(Console.ReadLine());
            C = (double)c;
            Console.WriteLine($"Output: {CelsiusToFahrenheit(c)}");

            //Bài 13: Tìm giá trị nhỏ nhất trong mảng
            Console.Write("Input: "); input = Console.ReadLine();
            input = input.Replace("[", "").Replace("]", "").Replace(",", " ");
            string[] temparr = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[temparr.Length];
            for (int i = 0; i < temparr.Length; i++)
            {
                arr[i] = int.Parse(temparr[i]);
            }
            Console.WriteLine($"Output: {TimMin(arr)}");

            //Bài 14: Tính tổng các chữ số của một số nguyên
            Console.Write("Input: "); n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: {TongCacChuSo(n)}");

            //Bài 15: Sắp xếp mảng tăng dần
            Console.Write("Input: "); input = Console.ReadLine();
            input = input.Replace("[", "").Replace("]", "").Replace(",", " ");
            temparr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            arr = new int[temparr.Length];
            for (int i = 0; i < temparr.Length; i++)
            {
                arr[i] = int.Parse(temparr[i]);
            }
            SapXepMang(arr);

            //Bài 16: Xóa ký tự trùng lặp
            Console.Write("Input: "); s = Console.ReadLine();
            Console.WriteLine($"Output: {XoaTrungLap(s)}");

            //Bài 17: Tìm ước chung lớn nhất (UCLN)
            Console.Write("Input: a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write(", b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: {UCLN(a, b)}");

            //Bài 18: Chuyển đổi hệ thập phân sang nhị phân
            Console.Write("Input: "); n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: {DecimalToBinary(n)}");

            //Bài 19: Kiểm tra năm nhuận
            Console.Write("Input: "); int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output: {KiemTraNamNhuan(year)}");

            //Bài 20: Đếm số từ trong câu
            Console.Write("Input: "); string sentence = Console.ReadLine();
            Console.WriteLine($"Output: {DemSoTu(sentence)}");
        }
    }
}
