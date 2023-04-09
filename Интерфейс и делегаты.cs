using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{

    interface IMath
    {
        double Plus(double a, double b);
        double Minus(double a, double b);
        double Um(double a, double b);
        double Del(double a, double b);
    }
    class Math : IMath
    {
        public double Plus(double a, double b)
        {
            double res = a + b;
            return res;
        }
        public double Minus(double a, double b)
        {
            double res = a - b;
            return res;
        }
        public double Um(double a, double b)
        {
            double res = a * b;
            return res;
        }
        public double Del(double a, double b)
        {
            double res = a / b;
            return res;
        }
    }
    public delegate double Op(double a, double b);
    class Program
    {
        public static void Main(string[] args)
        {
            Math math = new Math();
            List < Op > del = new List<Op>() { math.Plus, math.Minus, math.Um, math.Del };
            double res = 0;
            double a = 0;
            double b = 0;
            for (; ; )
            {
                Console.WriteLine("1-Сложение\n2-Вычитание\n3-Умножение\n4-Деление\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Сложение");
                        Console.WriteLine("Введите первое слагаемое");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе слагаемое");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = del[0](a, b);
                        Console.WriteLine("Сумма: " + res);
                        Console.WriteLine("\nНажмите любую клавишу....");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Вычитание");
                        Console.WriteLine("Введите уменьшаеомое");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите вычитаемое");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = del[1](a, b);
                        Console.WriteLine("Разность: " + res);
                        Console.WriteLine("\nНажмите любую клавишу....");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Умножение");
                        Console.WriteLine("Введите первый множитель");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второй множитель");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = del[2](a, b);
                        Console.WriteLine("Произведение: " + res);
                        Console.WriteLine("\nНажмите любую клавишу....");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Деление");
                        Console.WriteLine("Введите делимое");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите делитель");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = del[3](a, b);
                        Console.WriteLine("Частное: " + res);
                        Console.WriteLine("\nНажмите любую клавишу....");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
