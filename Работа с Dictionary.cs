using System;
using System.Collections.Generic;

namespace Работа_с_Dictionary
{
    class Program
    {
        static void Zapolnenie(ref Dictionary<string, string> dt)
        {
            Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите ключ");
                var s1 = Console.ReadLine();
                Console.WriteLine("Введите элемент(если вы введёте повторный ключ, то в таблицу ничего не запишется)");
                var s2 = Console.ReadLine();
                dt.TryAdd(s1, s2);
            }
        }
        static void Vivod(ref Dictionary<string, string> dt)
        {
            foreach (var d in dt)
            {
                Console.WriteLine(d.Key + ": " + d.Value);
            }
            Console.WriteLine("Нажмите любую клавишу.....");
            Console.ReadLine();
        }
        public static void Rem(ref Dictionary<string, string> dt)
        {
            Console.WriteLine("Метод Remove");
            Console.WriteLine("Словарь до: \n");
            Vivod(ref dt);
            Console.WriteLine("Введите ключ элемента, который хотите удалить: ");
            var s = Console.ReadLine();
            dt.Remove(s);
            Console.WriteLine("\nСловарь после: ");
            Vivod(ref dt);
        }
        public static void Cl(ref Dictionary<string, string> dt)
        {
            Console.WriteLine("Метод Clear");
            Console.WriteLine("Словарь до\n");
            Vivod(ref dt);
            dt.Clear();
            Console.WriteLine("Словарь после\n");
            Vivod(ref dt);
        }
        public static void Count(ref Dictionary<string, string> dt)
        {
            Console.WriteLine("Метод Count");
            Console.WriteLine("В словаре: " + dt.Count + " строк");
            Console.ReadLine();
        }
        public static void Cont(ref Dictionary<string, string> dt)
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
                    if (dt.ContainsKey(key) == true)
                    {
                        Console.WriteLine("Элемент с таким ключом в словаре есть:\n" + key + ": " + dt[key]);
                    }
                    else
                    {
                        Console.WriteLine("Элемента с таким ключом в словаре нет");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Метод ContainsValue");
                    Console.WriteLine("Введите элемент");
                    var value = Console.ReadLine();
                    if (dt.ContainsValue(value) == true)
                    {
                        Console.WriteLine("Такой элемент в словаре есть");
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента в словаре нет");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
        public static void Get(ref Dictionary<string, string> dt)
        {
            Console.WriteLine("Метод TryGetValue");
            Console.WriteLine("Введите ключ");
            string k = Console.ReadLine();
            string v = null;
            if(dt.TryGetValue(k, out v) == true)
            {
                Console.WriteLine("Ключу " + k + " соответствует значение " + v);
            }
            else
            {
                Console.WriteLine("Такого ключа в словаре нет");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Dictionary<string,string> dt = new Dictionary<string,string>();
            for (; ; )
            {
                Console.WriteLine("1-Ввод\n2-Вывод\n3-Remove\n4-Clear\n5-Count\n6-Contains\n7-TryGetValue\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zapolnenie(ref dt);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Содержимое словаря: ");
                        Vivod(ref dt);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Rem(ref dt);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Cl(ref dt);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Count(ref dt);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Cont(ref dt);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Get(ref dt);
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
