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
        public static void Proverka(ref double a)
        {
            int n=1;
            while (n >0 )
            {
                if (Double.TryParse(Console.ReadLine(), out a))
                {
                    n--;  
                }
                else
                {
                    Console.WriteLine("Неверный ввод данных, попробуйте ещё раз");
                }
            }
        }
        static void Main(string[] args)
        {
            double a=0, b=0, c = 0;
            Lyambda lya = new Lyambda();
            Console.WriteLine("Введите первое число");
            Proverka(ref a);
            Console.WriteLine("Введите второе число");
            Proverka(ref b);
            Console.WriteLine("Введите третье число");
            Proverka(ref c);
            List<Op> operation = new List<Op>() { lya.sum, lya.mult, lya.min, lya.max, lya.sr };
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1-Сумма\n2-Произведение\n3-Минимальный\n4-Максимальный\n5-Среднее арифмитическое\n6-Просмотр введённых чисел\nEsc-Выход");
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
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine("Числа: " + a + " " + b+ " " + c);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
