using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_project.Session_5
{
    internal class Exercise_0
    {
        public static void Main5(string[] args)
        {
            Random rd = new Random();
            int num = rd.Next(1, 101);
            int guess;
            Console.WriteLine("Hay doan mot so tu 1 den 100");
            do
            {
                Console.Write("Nhap so ban doan: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > num)
                {
                    Console.WriteLine("So ban doan lon hon");
                }
                else if (guess < num)
                {
                    Console.WriteLine("So ban doan nho hon");
                }
                else
                {
                    Console.WriteLine("Ban da doan dung");
                }
            }
            while (guess != num);
        }
    }
}
