using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        public static void Zap(ref Queue<string> qe)
        {
            Console.WriteLine("Заполнение очереди");
            Console.WriteLine("Введите число элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                qe.Enqueue(Console.ReadLine());
            }
        }
        public static void Vivod(ref Queue<string> qe)
        {
            foreach (var q in qe)
            {
                Console.WriteLine(q + " ");
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadLine();
        }
        public static void Peek(ref Queue<string> qe)
        {
            Console.WriteLine("Метод Peek");
            Console.WriteLine("\nОчередь до использования метода:");
            Vivod(ref qe);
            Console.WriteLine("\nЭлемент, который извлёк метод Peek: \n" + qe.Peek());
            Console.WriteLine("\nОчередь после использования метода:");
            Vivod(ref qe);
        }
        public static void Deq(ref Queue<string> qe)
        {
            Console.WriteLine("Метод Dequeue");
            Console.WriteLine("\nОчередь до использования метода:");
            Vivod(ref qe);
            Console.WriteLine("\nЭлемент, который извлёк метод Dequeue: \n" + qe.Dequeue());
            Console.WriteLine("\nОчередь после использования метода:");
            Vivod(ref qe);
        }
        public static void Cont(ref Queue<string> qe)
        {
            Console.WriteLine("Метод Contains");
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            if (qe.Contains(s) == true)
            {
                Console.WriteLine("Строка " + s + " есть в очереди");
            }
            else
            {
                Console.WriteLine("Строка " + s + " отсутствует в очереди");
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadLine();
        }
        public static void Cl(ref Queue<string> qe)
        {
            Console.WriteLine("Метод Clear");
            Console.WriteLine("\nОчередь до использования метода:");
            Vivod(ref qe);
            qe.Clear();
            Console.WriteLine("\nОчередь после использования метода:");
            Console.WriteLine("");
            Vivod(ref qe);
        }
        static void Main(string[] args)
        {
            Queue<string> qe = new Queue<string>();
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1-Заполнение очереди\n2-Вывод очереди\n3-Peek\n4-Dequeue\n5-Contains\n6-Clear\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zap(ref qe);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Содержимое очереди: ");
                        Vivod(ref qe);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Peek(ref qe);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Deq(ref qe);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Cont(ref qe);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Cl(ref qe);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
