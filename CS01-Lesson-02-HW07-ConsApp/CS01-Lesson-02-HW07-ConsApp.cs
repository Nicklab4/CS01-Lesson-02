//7. n) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_HW07_Consnpp
{
    class Progrnm
    {
        // Рекурсивный метод, который выводящий на экран числа от n до m(n<b).
        static int loopRec(int n , int m)
        {
            // Реверсия чисел если n больше m
            if (n > m)
            {
                n = n + m;
                m = n - m;
                n = n - m;
            }

            if (n == m)
            {
                Console.WriteLine(n);
                return n;
            }
            Console.WriteLine(n);
            return loopRec(++n, m);
        }

        // Рекурсивный метод, который считает сумму чисел от n до m.
        static int sumRec(int n, int m)
        {
            // Реверсия чисел если n больше m
            if (n > m)
            {
                n = n + m;
                m = n - m;
                n = n - m;
            }

            if (n == m) return n;
            return (n + sumRec(++n, m));
        }

        static void Main(string[] args)
        {
            int a=10, b=-3;

            loopRec(a, b);
            Console.WriteLine("Сумма всех чисел: {0}", sumRec(a, b));

            Console.ReadLine();
        }
    }
}
