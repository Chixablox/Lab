using System;
using System.Collections.Generic;

namespace Delegate
{
    delegate double Op (double a, double b, double c);
    class Lyambda
    {
        public Op sum = (a, b, c) => a + b + c;
        public Op mult = (a, b, c) => a * b * c;
        public Op min = (a, b, c) => Math.Min(a, Math.Min(b, c));
        public Op max = (a, b, c) => Math.Max(a, Math.Max(b, c));
        public Op sr = (a, b, c) => (a+b+c)/3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lyambda lya = new Lyambda();
            Console.WriteLine("Введите первое число");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double c = Convert.ToInt32(Console.ReadLine());
            List<Op> operation = new List<Op>() { lya.sum, lya.mult, lya.min, lya.max, lya.sr };
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1-Сумма\n2-Произведение\n3-Минимальный\n4-Максимальный\n5-Среднее арифмитическое\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Сумма: " + operation[0](a, b, c));
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Произведение: " + operation[1](a, b, c));
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Минимальный: " + operation[2](a, b, c));
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Максимальный: " + operation[3](a, b, c));
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("Среднее арифмитическое: " + operation[4](a, b, c));
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
