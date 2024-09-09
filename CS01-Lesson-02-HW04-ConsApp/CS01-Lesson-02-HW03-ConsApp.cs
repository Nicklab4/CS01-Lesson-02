// 4. Реализовать метод проверки логина и пароля. На вход метода подается
// логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
// если не прошел (Логин: root, Password: GeekBrains). Используя метод
// проверки логина и пароля, написать программу: пользователь вводит логин
// и пароль, программа пропускает его дальше или не пропускает.
// С помощью цикла do while ограничить ввод пароля тремя попытками.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS01_Lesson_02_HW04_ConsApp
{
    class Program
    {
        static bool CheckPass(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            string login, password;
            int count = 3;
            bool sucsess = false;

            do
            {
                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                count--;

                if (CheckPass(login, password))
                {
                    Console.WriteLine("Вы верно ввели пароль!");
                    sucsess = true;
                    break;
                }
                else
                    Console.WriteLine("Пароль не верный!");

            } while (count >0);

            if(!sucsess)
                Console.WriteLine("Вы истратили 3 попытки. В доступе отказано.");
            Console.ReadLine();
        }
    }
}
