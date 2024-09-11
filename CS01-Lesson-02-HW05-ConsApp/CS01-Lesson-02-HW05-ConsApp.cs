//5. а) Написать программу, которая запрашивает массу и рост человека,
//вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
//набрать вес или всё в норме.
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для
//нормализации веса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_HW05_ConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, weight;
            double index;
            Console.WriteLine("Введите ваш рост в сантиметрах:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в килограммах:");
            weight = int.Parse(Console.ReadLine());

            index = weight / Math.Pow(((double)height / 100), 2);
            Console.WriteLine("Ваш индекс тела: {0}", index);

            if (index <= 16)
            {
                Console.WriteLine("У Вас - Выраженный дефицит массы тела");
                Console.WriteLine("Вам необходимо набрать {0} кг.",
                    (16 - index) * Math.Pow(((double)height / 100), 2));
            }

            if (index > 16 && index <= 18.5)
            {
                Console.WriteLine("У Вас - Недостаточная (дефицит) масса тела");
                Console.WriteLine("Вам необходимо набрать {0} кг.",
                    (16 - index) * Math.Pow(((double)height / 100), 2));
            }

            if (index > 18.5 && index <= 25)
                Console.WriteLine("Ваш вес в норме");

            if (index > 25 && index <= 30)
            {
                Console.WriteLine("У Вас - Избыточная масса тела");
                Console.WriteLine("Вам необходимо сбросить {0} кг.",
                    (index - 25) * Math.Pow(((double)height / 100), 2));
            }

            if (index > 30 && index <= 35)
            {
                Console.WriteLine("У Вас - Ожирение 1 степени");
                Console.WriteLine("Вам необходимо сбросить {0} кг.",
                    (index - 25) * Math.Pow(((double)height / 100), 2));
            }

            if (index > 35 && index <= 40)
            {
                Console.WriteLine("У Вас - Ожирение 2 степени");
                Console.WriteLine("Вам необходимо сбросить {0} кг.",
                    (index - 25) * Math.Pow(((double)height / 100), 2));
            }

            if (index > 40)
            {
                Console.WriteLine("У Вас - Ожирение 3 степени");
                Console.WriteLine("Вам необходимо сбросить {0} кг.",
                    (index - 25) * Math.Pow(((double)height / 100), 2));
            }

            Console.ReadLine();
        }
    }
}
