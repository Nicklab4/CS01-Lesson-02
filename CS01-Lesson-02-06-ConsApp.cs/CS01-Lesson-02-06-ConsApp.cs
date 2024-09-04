//Задача 6. Дано натуральное число n. Вычислить n!
//Без использования рекурсии:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_06_ConsApp.cs
{
    class Program
    {
        //Без использования рекурсии:
        static uint Factorial(uint n)
        {
            uint res = 1;
            for (uint i = 0; i <= n; i++)
            {
                if (i == 0) res = 1;
                else res *= i;
            }
            return res;
        }

        // С использованием рекурсии (0!=1, n!=n*(n-1)!):
        static uint FactorialRec(uint n)
        {
            if (n == 0) return 1;
            else return FactorialRec(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            DateTime start = DateTime.Now;
            Console.WriteLine(Factorial(n));
            Console.WriteLine(DateTime.Now - start);

            start = DateTime.Now;
            Console.WriteLine(FactorialRec(n));
            Console.WriteLine(DateTime.Now - start);
            Console.ReadLine();
        }
    }
}
