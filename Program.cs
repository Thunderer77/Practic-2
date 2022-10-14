using System;
using System.Numerics;
using System.Security.Cryptography;

namespace _3_в_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу!\n У нас есть на выбор три программы\n 1:Игра : Угадай число\n 2:Таблица умножения\n 3: Вывод делителей числа\n 4: Выход из программы ");
            while (true)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                switch (v)
                {
                    case 1: Game(); break;
                       
                    case 2: t_u(); break;
                    case 3: del(); break;
                    case 4: Console.WriteLine("Game over!"); return;
                    default:
                        Console.WriteLine("Неверно.\nПорпобуйте занова\n"); break;

                }

                Console.WriteLine("Выберете ещё одно дейсвтие: \n 1:Игра : Угадай число\n 2:Таблица умножения\n 3: Вывод делителей числа\n 4: Выход из программы ");

            }


        }

        static string Game()
        {

            {
                Console.WriteLine("Попробуйте угадать число от 1 до 100");
                Random chislo = new Random();
                int rd_ch = chislo.Next(0, 100);
                int mine = Convert.ToInt32(Console.ReadLine());
                while (mine != rd_ch)
                {
                    Console.WriteLine("О нет! Вы не угадали...");
                    if (mine < rd_ch)
                    {
                        Console.WriteLine("Загадонное число больше");
                    }
                    else
                    {
                        Console.WriteLine("Загадонное число меньше");
                    }
                    mine = Convert.ToInt32(Console.ReadLine());
                }
            } string answer = ("Поздравляю! Вы угадали");
            return answer;
        }
        static void t_u()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}\t", i);
                    }
                    else
                    {
                        Console.Write("{0}\t", i * j);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        static void del()
        {
            Console.WriteLine("Введите число: ");
            int delim = Convert.ToInt32(Console.ReadLine());
            int chast;
            for (int i = 1; i != delim + 1; i++)
            {
                if (delim % i == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine(del);
        }
    } 
        
        
}