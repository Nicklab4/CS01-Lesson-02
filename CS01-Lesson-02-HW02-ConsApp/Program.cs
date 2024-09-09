//2. Написать метод подсчета количества цифр числа.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_HW02_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            decimal x = decimal.Parse(Console.ReadLine());
            int count = 0;

            while (x > 0)
            {
                count++;
                x = x / 10;
            }

            Console.WriteLine("Ваше число содержит {0} символов", count);
            Console.ReadLine();
        }
    }
}
