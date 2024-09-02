//Задача 2.
//Сумма двух последних цифр.
//Вывести в диапазоне от 10 до 100 все числа,
//сумма двух последних цифр которых равна 10:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_02_ConsApp
{
    class Program
    {
        static bool Check(int a)
        {
            if ((a % 10 + a / 10 % 10 == 10))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i++)
                if (Check(i)) Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
