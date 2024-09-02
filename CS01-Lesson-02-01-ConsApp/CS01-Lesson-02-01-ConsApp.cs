//Задача 1.
//Алгоритм нахождения НОД и организация метода
//Реализовать метод нахождения NOD, используя алгоритм Евклида:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02
{
    class Program
    {
        static int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            return a;
        }

        static void Main(string[] args)
        {
            int a = 524;
            int b = 224;

            Console.WriteLine(NOD(a, b));

            Console.ReadLine();
        }
    }
}
