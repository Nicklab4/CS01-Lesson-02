//Задача 7. Последовательность Фибоначчи
//   Последовательность Фибоначчи определяется так: a 0 =0, a 1 =1,
// a k =a k-1 +a k-2 при k>=2.
// Дано n, вычислить a n .


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_07_ConsApp
{
    class Program
    {
        // Вариант 1. Использования цикла for:
        static uint Fib(uint n)
        {
            uint a0 = 0;
            uint a1 = 1;
            uint a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }

        // Вариант 2. Использование рекурсии:
        static uint FibRec(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibRec(n - 1) + FibRec(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            uint n = Convert.ToUInt32(Console.ReadLine());

            DateTime start = DateTime.Now;
            Console.WriteLine(Fib(n));
            Console.WriteLine(DateTime.Now - start);

            start = DateTime.Now;
            Console.WriteLine(FibRec(n));
            Console.WriteLine(DateTime.Now - start);

            Console.ReadLine();
        }
    }
}
