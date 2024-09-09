//3. С клавиатуры вводятся числа, пока не будет введен 0.
//Подсчитать сумму всех нечетных положительных чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_HW03_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            decimal summ = 0;

            while (true)
            {
                Console.WriteLine("Введите число ");
                x = int.Parse(Console.ReadLine());

                if (x==0) break;

                if (x > 0 && (x % 2 == 1)) 
                    summ += x;
            }

            Console.WriteLine("Сумма всех нечётных положительных чисел равна: {0}", summ);
            Console.ReadLine();
        }
    }
}
