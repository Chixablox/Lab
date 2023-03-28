using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Primer()
        {
            Console.WriteLine("Введите строку");
            string s = Convert.ToString(Console.ReadLine());
            Stack<char> stroka = new Stack<char>();
            int k = 0, otvet = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if ((s[i] == '[') || (s[i] == '{') || (s[i] == '('))
                {
                    stroka.Push(s[i]);
                    k++;
                }
                if (stroka.Count > 0)
                {
                    if ((s[i] == ']') && (stroka.Pop() == '['))
                    {
                        otvet++;
                    }
                    else if ((s[i] == '}') && (stroka.Pop() == '{'))
                    {
                        otvet++;
                    }
                    else if ((s[i] == ')') && (stroka.Pop() == '('))
                    {
                        otvet++;
                    }
                }
            }
            if ((otvet == k) && (otvet > 0))
            {
                Console.WriteLine("Скобки стоят правильно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены неверно");
            }
            Console.ReadLine();
        }
        public static void Zapolnenie(ref Stack<int> pr)
        {
            int k = 0;
            int n = 0;
            while (k < 1)
            {
                Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    n = n;
                    k++;
                }
                else
                {
                    Console.WriteLine("Неверный ввод данных!");
                }
            }
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                int m = 0;
                if (Int32.TryParse(Console.ReadLine(), out m))
                {
                    m = m;
                }
                else
                {
                    Console.WriteLine("Неверный ввод данных!");
                    i--;
                    continue;
                }
                pr.Push(m);
            }
            Vivod(ref pr);
        }
        public static void Vivod(ref Stack<int> pr)
        {
            Console.WriteLine("\nСодержимое стэка: ");
            foreach ( var i in pr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        public static void Peeks (ref Stack<int> pr)
        {
            Console.WriteLine("Метод Peek смотрит первый элемет стэка, не извлекая его:");
            Console.WriteLine(pr.Peek());
            Vivod(ref pr);
        }
        public static void Pops(ref Stack<int> pr)
        {
            Console.WriteLine("Метод Pop смотрит первый элемет стэка, извлекая его:");
            Console.WriteLine(pr.Pop());
            Vivod(ref pr);
        }
        public static void Pushs(ref Stack<int> pr)
        {
            int n = 0;
            Console.WriteLine("Метод Push добавляет новый элемент в стэк:");
            while (n < 1)
            {
                Console.WriteLine("Введите элемент");
                int m = 0;
                if (Int32.TryParse(Console.ReadLine(), out m))
                {
                    pr.Push(m);
                    n++;
                }
                else
                {
                    Console.WriteLine("Неверный ввод данных!");
                }
            }
            Vivod(ref pr);
        }
        public static void Counts(ref Stack<int> pr)
        {
            Console.WriteLine("Метод Count определяет кол-во элементов стэка");
            Console.WriteLine("В стэке: " + pr.Count + " элементов");
            Vivod(ref pr);
        }
        public static void Contains(ref Stack<int> pr)
        {
            int n = 0;
            int m = 0;
            bool b = false;
            Console.WriteLine("Метод Contain проверяет наличие элемента в стэке: ");
            while (n < 1)
            {
                Console.WriteLine("Введите элемент");
                if (Int32.TryParse(Console.ReadLine(), out m))
                {
                    b = pr.Contains(m);
                    n++;
                }
                else
                {
                    Console.WriteLine("Неверный ввод данных!");
                }
            }
            if (b == true)
            {
                Console.WriteLine("Элемент " + m + " есть в стэке");
            }
            else
            {
                Console.WriteLine("Элемент " + m +  " отсутствует в стэке");
            }
            Vivod(ref pr);
        }
        static void Main(string[] args)
        {
            Stack<int> pr = new Stack<int>();
            for (; ; )
            {
                Console.WriteLine("Тип элемнтов стэка - int");
                Console.WriteLine("1-Ввод стэка\n2-Вывод стэка\n3-Метод Pеек\n4-Метод Pop\n5-Метод Push\n6-Метод Count\n7-Метод Contains\n8-Пример задачи со стэком(скобки)\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zapolnenie(ref pr);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Vivod(ref pr);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Peeks(ref pr);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Pops(ref pr);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Pushs(ref pr);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Counts(ref pr);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Contains(ref pr);
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Primer();
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
