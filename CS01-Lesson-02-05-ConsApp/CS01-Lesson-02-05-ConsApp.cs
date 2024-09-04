//Задача 5. Учимся подсчитывать эффективность программы
//   Для этого давайте научимся подсчитывать время выполнения программы.
// Решим задачу нахождения простых чисел в диапазоне от 1 до 1000000.
// Напишем метод проверки, является ли число простым, и используем его
// для подсчёта количества чисел. В начале цикла сохраним текущее время,
// по выходу из цикла вычтем текущее время из сохранённого и выведем
// результат на экран.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_05_ConsApp
{
    class Program
    {
        static bool IsSImple(int n)
        {
            //for (int i = 2; i <= n / 2; i++)
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int k = 0;
            for (int i = 2 ; i < 1000000; i++)
                if (IsSImple(i))
                {
                    k++;
                    Console.WriteLine("{0} {1}", k, i);
                }

            Console.WriteLine(k);
            Console.WriteLine(DateTime.Now - start);
            Console.ReadLine();
        }
    }
}
