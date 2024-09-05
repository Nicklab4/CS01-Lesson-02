// 1. Написать метод, возвращающий минимальное из трёх чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_HW01_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;
            Console.WriteLine("ВВедите два целых числа.");
            Console.Write("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число: ");
            c = Convert.ToInt32(Console.ReadLine());

            min = a;
            if (b < a && b <= c) min = b;
            if (c < b && c < a) min = c;

            Console.WriteLine("Наименьшее число {0}", min);
            Console.ReadLine();
        }
    }
}
