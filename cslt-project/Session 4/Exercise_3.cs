using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace cslt_project.Session_4
{
    internal class Exercise_3
    {
        //1. Viết chương trình giải và biện luận phương trình bậc 2.
        static void Bai_1()
        {
            Console.WriteLine("Phương trình bậc 2 có dạng: ax^2 + bx + c = 0");
            Console.Write("Nhập hệ số a: "); bool checka = double.TryParse(Console.ReadLine(), out double a);
            while (!checka)
            {
                Console.Write("Định dạng không hợp lệ, chỉ nhập số. Nhập lại hệ số a: "); checka = double.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("Nhập hệ số b: "); bool checkb = double.TryParse(Console.ReadLine(), out double b);
            while (!checkb)
            {
                Console.Write("Định dạng không hợp lệ, chỉ nhập số. Nhập lại hệ số b: "); checkb = double.TryParse(Console.ReadLine(), out b);
            }
            Console.Write("Nhập hệ số c: "); bool checkc = double.TryParse(Console.ReadLine(), out double c);
            while (!checkc)
            {
                Console.Write("Định dạng không hợp lệ, chỉ nhập số. Nhập lại hệ số c: "); checkc = double.TryParse(Console.ReadLine(), out c);
            }
            double delta = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            if (a == 0)
            {
                if (b == 0) {
                    if (c == 0) {
                        Console.WriteLine($"Phương trình vô số nghiệm");
                    }
                    else {
                        Console.WriteLine($"Phương trình vô nghiệm");
                    }
                }
                else {
                    Console.WriteLine($"Phương trình có nghiệm: x = {-c / b}");
                }
            }
            else
            {
                if (delta == 0) {
                    Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {-b / (2 * a)}");
                }
                else if (delta > 0) {
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}; x2 = {x2}");
                }
                else {
                    Console.WriteLine($"Phương trình vô nghiệm");
                }
            }
        }
        //2. Viết chương trình giải quyết các vấn đề sau:
        //1. Write a C# Sharp program to check whether a given number is even or odd.
        static void Bai_21()
        {
            Console.Write("Input the value: "); bool checkint= int.TryParse(Console.ReadLine(), out int value);
            while (!checkint)
            {
                Console.WriteLine("Invalid input! Please enter an integer only."); 
                Console.Write("Please try again: "); checkint = int.TryParse(Console.ReadLine(), out value);
            }
            if (value % 2 == 0)
            {
                Console.WriteLine("The given value is even.");
            }
            else
            {
                Console.WriteLine("The given value is odd.");
            }
        }
        //2. Write a C# Sharp program to find the largest of three numbers.
        static void Bai_22()
        {
            Console.Write("Input the first number: "); bool check1 = double.TryParse(Console.ReadLine(), out double num1);
            while (!check1)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter the first number: "); check1 = double.TryParse(Console.ReadLine(), out num1);
            }
            Console.Write("Input the second number: "); bool check2 = double.TryParse(Console.ReadLine(), out double num2);
            while (!check2)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter the second number: "); check2 = double.TryParse(Console.ReadLine(), out num2);
            }
            Console.Write("Input the third number: "); bool check3 = double.TryParse(Console.ReadLine(), out double num3);
            while (!check3)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter the third number: "); check3 = double.TryParse(Console.ReadLine(), out num3);
            }
            double max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            Console.WriteLine($" The largest of three numbers is: {max}");
        }
        //3. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        static void Bai_23()
        {
            Console.Write("Input side a: "); bool checka = double.TryParse(Console.ReadLine(), out double a);
            while (!checka)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter side a: "); checka = double.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("Input side b: "); bool checkb = double.TryParse(Console.ReadLine(), out double b);
            while (!checkb)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter side b: "); checkb = double.TryParse(Console.ReadLine(), out b);
            }
            Console.Write("Input side c: "); bool checkc = double.TryParse(Console.ReadLine(), out double c);
            while (!checkc)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter side c: "); checkc = double.TryParse(Console.ReadLine(), out c);
            }
            if (a == b || b == c || c == a)
            {
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("This triangle is Equilateral.");
                }
                else
                {
                    Console.WriteLine("This triangle is Isosceles.");
                }
            }
            else
            {
                Console.WriteLine("This triangle is Scalene.");
            }
        }
        //4. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        static void Bai_24()
        {
            Console.Write("Input the value for X coordinate: "); bool checkx = double.TryParse(Console.ReadLine(), out double x);
            while (!checkx)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter the value for X coordinate: "); checkx = double.TryParse(Console.ReadLine(), out x);
            }
            Console.Write("Input the value for Y coordinate: "); bool checky = double.TryParse(Console.ReadLine(), out double y);
            while (!checky)
            {
                Console.WriteLine("Invalid input! Please enter a number only.");
                Console.Write("Please re-enter the value for Y coordinate: "); checky = double.TryParse(Console.ReadLine(), out y);
            }
            if (x != 0 && y != 0)
            {
                if (x * y > 0)
                {
                    if (x > 0 )
                    {
                        Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
                    }
                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
                    }
                    else
                    {
                        Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
                    }
                }
            }
            else
            {
                if (x == 0 && y == 0)
                {
                    Console.WriteLine($"The coordinate point ({x},{y}) coincides with the origin.");
                }
                else if (x == 0) {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies on the y-axis.");
                }
                else {
                    Console.WriteLine($"The coordinate point ({x},{y}) lies on the x-axis.");
                }
            }
        }
        public static void Main4(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_21();
            Bai_22();
            Bai_23();
            Bai_24();
        }
    }
}
