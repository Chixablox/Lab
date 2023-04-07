using System;
using System.Collections.Generic;

namespace Работа_с_SortedList
{
    class Program
    {
        static void Zapolnenie(ref SortedList<string, string> sl)
        {
            Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите ключ");
                var s1 = Console.ReadLine();
                Console.WriteLine("Введите элемент(если вы введёте повторный ключ, то в лист ничего не запишется)");
                var s2 = Console.ReadLine();
                sl.TryAdd(s1, s2);
            }
        }
        static void Vivod(ref SortedList<string, string> sl)
        {
            foreach (var d in sl)
            {
                Console.WriteLine(d.Key + ": " + d.Value);
            }
            Console.WriteLine("Нажмите любую клавишу.....");
            Console.ReadLine();
        }
        public static void Rem(ref SortedList<string, string> sl)
        {
            Console.WriteLine("Метод Remove и RemoveAt");
            Console.WriteLine("Лист до: \n");
            Vivod(ref sl);
            Console.WriteLine("1-Remove(по ключу)\n2-RemoveAt(по индексу)");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\bВведите ключ элемента, который хотите удалить: ");
                    var s = Console.ReadLine();
                    sl.Remove(s);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\bВведите индекс элемента, который хотите удалить: ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    sl.RemoveAt(k);
                    break;
            }       
            Console.WriteLine("\nЛист после: ");
            Vivod(ref sl);
        }
        public static void Cl(ref SortedList<string, string> sl)
        {
            Console.WriteLine("Метод Clear");
            Console.WriteLine("Лист до\n");
            Vivod(ref sl);
            sl.Clear();
            Console.WriteLine("Лист после\n");
            Vivod(ref sl);
        }
        public static void Count(ref SortedList<string, string> sl)
        {
            Console.WriteLine("Метод Count");
            Console.WriteLine("В листе: " + sl.Count + " элементов");
            Console.ReadLine();
        }
        public static void Cont(ref SortedList<string, string> sl)
        {
            Console.WriteLine("Метод Contains");
            Console.WriteLine("1-ContainsKey\n2-ContainsValue");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Метод ContainsKey");
                    Console.WriteLine("Введите ключ");
                    var key = Console.ReadLine();
                    if (sl.ContainsKey(key) == true)
                    {
                        Console.WriteLine("Элемент с таким ключом в листе есть:\n" + key + ": " + sl[key]);
                    }
                    else
                    {
                        Console.WriteLine("Элемента с таким ключом в листе нет");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Метод ContainsValue");
                    Console.WriteLine("Введите элемент");
                    var value = Console.ReadLine();
                    if (sl.ContainsValue(value) == true)
                    {
                        Console.WriteLine("Такой элемент в листе есть");
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента в листе нет");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
        public static void Get(ref SortedList<string, string> sl)
        {
            Console.WriteLine("Метод TryGetValue");
            Console.WriteLine("Введите ключ");
            string k = Console.ReadLine();
            string v = null;
            if (sl.TryGetValue(k, out v) == true)
            {
                Console.WriteLine("Ключу " + k + " соответствует значение " + v);
            }
            else
            {
                Console.WriteLine("Такого ключа в листе нет");
            }
            Console.ReadLine();
        }
        static void Index(ref SortedList<string, string> sl)
        {
            Console.WriteLine("1-IndexOfKey\n2-IndexOfValue\n");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Введите ключ индекс которого хотите найти");
                    var g = Console.ReadLine();
                    var index = sl.IndexOfKey(g);
                    if (index >= 0)
                    {
                        Console.WriteLine("Индекс вхождения:" + index);
                    }
                    else
                    {
                        Console.WriteLine("Такого ключа нет");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Введите элемент индекс которого хотите найти");
                    var v = Console.ReadLine();
                    var indexl = sl.IndexOfValue(v);
                    if (indexl >= 0)
                    {
                        Console.WriteLine("Индекс вхождения:" + indexl);
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента нет");
                    }
                    break;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            for (; ; )
            {
                Console.WriteLine("1-Ввод\n2-Вывод\n3-Remove\n4-Clear\n5-Count\n6-Contains\n7-IndexOf\n8-TryGetValue\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zapolnenie(ref sl);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Содержимое листа: ");
                        Vivod(ref sl);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Rem(ref sl);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Cl(ref sl);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Count(ref sl);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Cont(ref sl);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Index(ref sl);
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Get(ref sl);
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
