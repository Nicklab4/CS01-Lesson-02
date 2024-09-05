//Задача 8. «Ханойская башня»
//Реализовать на C# рекурсивный алгоритм игры «Ханойская башня»:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_08_ConsApp
{
    class Program
    {
        static void Move(int number, int from, int to, int free)
        {
            if (number > 0)
            {
                Move(number - 1, from, free, to);
                Console.WriteLine("{0} => {1}", from, to);
                Move(number - 1, free, to, from);
            }
        }

        static void Main(string[] args)
        {
            Move(4, 1, 2, 3);
            Console.ReadLine();
        }
    }
}
