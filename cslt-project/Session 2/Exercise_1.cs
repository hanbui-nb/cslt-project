using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cslt_project.Session_2
{
    internal class Exercise_1
    {
        public static void Main(string[] args)
        {
            //1.to Add / Sum Two Numbers.
            Console.Write("1. Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum: {num1 + num2}");

            //2.to Swap Values of Two Variables.
            Console.Write("2. Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap: a = {a}, b = {b}");

            //3.to Multiply two Floating Point Numbers
            Console.Write("3. Enter the first number: ");
            float f1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the second number: ");
            float f2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Multiply: {f1 * f2}");

            //4.to convert feet to meter
            const float rate = 0.3048f;
            Console.Write("4. Enter length (feet): ");
            float feet = Convert.ToSingle(Console.ReadLine());
            float meter = feet * rate;
            Console.WriteLine($"{feet} feet = {meter} meter");

            //5.to convert Celsius to Fahrenheit and vice versa
            Console.Write("5. Enter temperature (Celsius): ");
            float celsius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"{celsius} Celsius = {celsius * 1.8+32} Fahrenheit");
            //vice versa
            Console.Write("Enter temperature (Fahrenheit): ");
            float fahrenheit = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"{fahrenheit} Fahrenheit = {(fahrenheit-32)/1.8} Celsius");

            //6.to find the Size of data types
            Console.WriteLine($"6. Size of data types");
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of bool: {sizeof(int)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");

            //7.to Print ASCII Value(tip: read character, print number of this char)
            Console.Write("7. Enter a character: ");
            int c = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c}: {c}");
            Console.ReadLine();

            //8.to Calculate Area of Circle
            const float PI = 3.14f;
            Console.Write("8. Enter circle radius: ");
            float r = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"The area of circle: {r*r*PI}");

            //9.to Calculate Area of Square
            Console.Write("9. Enter square side: ");
            float s = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"The area of square: {s * s}");
            //10.to convert days to years, weeks and days
            Console.Write("10. Enter total days: ");
            int total = Convert.ToInt32(Console.ReadLine());
            int years = total / 365;
            int months = (total % 365) / 12;
            int days = (total % 365) % 12;
            Console.WriteLine($"Equal: {years} years, {months} months, {days} days");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
