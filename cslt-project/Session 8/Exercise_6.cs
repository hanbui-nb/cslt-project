using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cslt_project.Session_8
{
    internal class Exercise_6
    {
        //▸Create a random integer values array, then create functions that:
        static void Phan1()
        {
            Random random = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 21);
            }
            Console.WriteLine($"Mảng các giá trị số nguyên ngẫu nhiên: { string.Join(", ", arr)}");
            Console.WriteLine($"1. Giá trị trung bình: {tb(arr):F2}");
            int check = random.Next(1, 21);
            Console.WriteLine($"2. Kiểm tra số {check} có trong mảng không? {kt(arr, check)}");
            int value = random.Next(1, 21);
            Console.WriteLine($"3. Chỉ số đầu tiên của số {value}: {chiso(arr, value)}");
            Console.WriteLine($"4. Mảng sau khi xóa bớt phần tử {check}: { string.Join(", ", xoa(arr, check))}");
            minmax(arr, out int min, out int max);
            Console.WriteLine($"5. Giá trị Min: {min}, Max: {max}");
            Console.WriteLine($"6. Mảng sau khi đảo ngược: { string.Join(", ", daonguoc(arr))}");
            List<int> trung = trunglap(arr);
            Console.WriteLine($"7. Các giá trị bị trùng lặp: {(trung.Count > 0 ? string.Join(", ", trung) : "Không có")}");
            Console.WriteLine($"8. Mảng sau khi lọc bỏ trùng lặp: {string.Join(", ", xoatrunglap(arr))}");
        }
        //1.to calculate the average value of array elements.
        static double tb(int[] arr)
        {
            if (arr.Length == 0) return 0;
            double sum = 0;
            foreach (int value in arr) sum += value;
            return sum / arr.Length;
        }
        //2.to test if an array contains a specific value.
        static bool kt(int[] arr, int check)
        {
            foreach (int value in arr)
                if (value == check) return true;
            return false;
        }
        //3.to find the index of an array element.
        static int chiso(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value) return i;
            return -1;
        }
        //4.to remove a specific element from an array.
        static int[] xoa(int[] arr, int check)
        {
            List<int> result = new List<int>();
            foreach (int value in arr)
                if (value != check) result.Add(value);
            return result.ToArray();
        }
        //5.to find the maximum and minimum value of an array.
        static void minmax(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int value in arr)
            {
                if (value < min) min = value;
                if (value > max) max = value;
            }
        }
        //6.to reverse an array of integer values.
        static int[] daonguoc(int[] arr)
        {
            int[] daonguoc = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                daonguoc[i] = arr[arr.Length - 1 - i];
            return daonguoc;
        }
        //7.to find duplicate values in an array of values.
        static List<int> trunglap(int[] arr)
        {
            List<int> trung = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !trung.Contains(arr[i]))
                    {
                        trung.Add(arr[i]);
                    }
                }
            }
            return trung;
        }
        //8.to remove duplicate elements from an array.
        static int[] xoatrunglap(int[] arr)
        {
            List<int> daxoa = new List<int>();
            foreach (int value in arr)
                if (!daxoa.Contains(value)) daxoa.Add(value);
            return daxoa.ToArray();
        }
        //▸Create a C# program that
        static void Phan2()
        {
            //-requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
            Console.WriteLine("Nhập 10 số nguyên:");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", BubbleSort(num)));
            //-Request a sentence from the user, then ask to enter a word. Search if the word appears in the phrase using the linear search algorithm.
            Console.Write("Nhập một câu: ");
            string sentence = Console.ReadLine();
            Console.Write("Nhập từ cần tìm: ");
            string search = Console.ReadLine();
            string[] words = sentence.Split(new[] { ' ', '.', ',', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (LinearSearchWord(words, search) != -1)
                Console.WriteLine($"Tìm thấy từ \"{search}\" tại vị trí từ thứ {LinearSearchWord(words, search) + 1} trong câu!");
            else
                Console.WriteLine($"Không tìm thấy từ \"{search}\" trong câu.");
        }
        //Bubble sort algorithm
        static int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        //Linear search algorithm
        static int LinearSearchWord(string[] words, string search)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        //▸Create a program with following functions
        static void Phan3()
        {
            //N, M was prompted from user
            Console.Write("Nhập số hàng N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = CreateRandomMatrix(N, M);
            Console.WriteLine("\nMa trận vừa tạo");
            PrintMatrix(matrix);
            //i/j was prompted from user
            Console.Write($"\nNhập chỉ số hàng i cần in (0 đến {N - 1}): ");
            int rowIndex = int.Parse(Console.ReadLine());
            PrintRow(matrix, rowIndex);
            Console.Write($"Nhập chỉ số cột j cần in (0 đến {M - 1}): ");
            int colIndex = int.Parse(Console.ReadLine());
            PrintColumn(matrix, colIndex);
            Console.WriteLine($"\nGiá trị lớn nhất của ma trận: {FindMatrixMax(matrix)}");
            Console.WriteLine($"Giá trị nhỏ nhất trên hàng {rowIndex}: {FindMinOfRow(matrix, rowIndex)}");
            Console.WriteLine($"Giá trị nhỏ nhất trên cột {colIndex}: {FindMinOfCol(matrix, colIndex)}");
            int[,] transposed = TransposeMatrix(matrix);
            Console.WriteLine("\n--- Ma trận chuyển vị (M x N) ---");
            PrintMatrix(transposed);
            if (N == M)
            {
                Console.WriteLine("\n--- Các đường chéo (Ma trận vuông) ---");
                PrintDiagonals(matrix);
            }
            else
            {
                Console.WriteLine("\n*(Ma trận không vuông nên không xuất đường chéo)*");
            }
        }
        //-Create an integer matrix N x M(N, M was prompted from user) randomly.
        static int[,] CreateRandomMatrix(int rows, int cols)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.Next(10, 100); 
            return matrix;
        }
        //-Print the matrix.
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
        //-Print the ith row/column. (i was prompted from user)
        static void PrintRow(int[,] matrix, int r)
        {
            if (r < 0 || r >= matrix.GetLength(0)) { Console.WriteLine("Chỉ số hàng không hợp lệ!"); return; }
            Console.Write($"Hàng {r}: ");
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[r, j]} ");
            Console.WriteLine();
        }
        static void PrintColumn(int[,] matrix, int c)
        {
            if (c < 0 || c >= matrix.GetLength(1)) { Console.WriteLine("Chỉ số cột không hợp lệ!"); return; }
            Console.Write($"Cột {c}: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
                Console.Write($"{matrix[i, c]} ");
            Console.WriteLine();
        }
        //-Find the max value of the matrix.
        static int FindMatrixMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int val in matrix)
                if (val > max) max = val;
            return max;
        }
        //-Find the min value of ith row / col of the matrix.
        static int FindMinOfRow(int[,] matrix, int r)
        {
            int min = matrix[r, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
                if (matrix[r, j] < min) min = matrix[r, j];
            return min;
        }
        static int FindMinOfCol(int[,] matrix, int c)
        {
            int min = matrix[0, c];
            for (int i = 1; i < matrix.GetLength(0); i++)
                if (matrix[i, c] < min) min = matrix[i, c];
            return min;
        }
        //-Transpose the matrix.
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[j, i] = matrix[i, j];

            return result;
        }
        //-Print the main / secondary diagonal values of the matrix.(square maxtrix).
        static void PrintDiagonals(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{matrix[i, i]} ");
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{matrix[i, n - 1 - i]} ");
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Phan1();
            Phan2();
            Phan3();
        }
    }
}
