using System;
using System.Collections;

namespace Работа_с_HashTable
{
    class Program
    {
        static void Zapolnenie(ref Hashtable ht)
        {
            Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите ключ");
                var s1 = Console.ReadLine();
                Console.WriteLine("Введите элемент");
                var s2 = Console.ReadLine();
                ht.Add(s1,s2);
            }
        }
        static void Vivod (ref Hashtable ht)
        {
            ICollection c = ht.Keys;
            //Console.WriteLine("Формат вывода данных:\nключ: элемент");
            foreach (var h in c)
            {
                Console.WriteLine(h + ": " + ht[h]);
            }
            Console.WriteLine("Нажмите любую клавишу.....");
            Console.ReadLine();
        }
        public static void Rem(ref Hashtable ht)
        {
            Console.WriteLine("Метод Remove");
            Console.WriteLine("Таблица до: \n");
            Vivod(ref ht);
            Console.WriteLine("Введите ключ элемента, который хотите удалить: ");
            var s = Console.ReadLine();
            ht.Remove(s);
            Console.WriteLine("\nТаблица после: ");
            Vivod(ref ht);
        }
        public static void Cl(ref Hashtable ht)
        {
            Console.WriteLine("Метод Clear");
            Console.WriteLine("Таблица до\n");
            Vivod(ref ht);
            Console.WriteLine("Таблица после\n");
            Vivod(ref ht);
        }
        public static void Count(ref Hashtable ht)
        {
            Console.WriteLine("Метод Count");
            Console.WriteLine("В таблице: " + ht.Count + " строк");
            Console.ReadLine();
        }
        public static void Cont(ref Hashtable ht)
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
                    if (ht.ContainsKey(key) == true)
                    {
                        Console.WriteLine("Элемент с таким ключом в таблице есть:\n" + key + ": " + ht[key]);
                    }
                    else
                    {
                        Console.WriteLine("Элемента с таким ключом в таблице нет");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Метод ContainsValue");
                    Console.WriteLine("Введите элемент");
                    var value = Console.ReadLine();
                    if (ht.ContainsValue(value) == true)
                    {
                        Console.WriteLine("Такой элемент в таблице есть");
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента в таблице нет");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
        public static void Hash(ref Hashtable ht)
        {
            Console.WriteLine("Метод GetHashCode");
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            if (ht.ContainsKey(key) == true)
            {
                var hash = key.GetHashCode();
                Console.WriteLine("Хэш-код данного ключа: " + hash);
            }
            else
            {
                Console.WriteLine("Такого ключа в таблице нет");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            for (; ; )
            {
                Console.WriteLine("1-Ввод\n2-Вывод\n3-Remove\n4-Clear\n5-Count\n6-Contains\n7-GetHashCode\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zapolnenie(ref ht);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Содержимое таблицы: ");
                        Vivod(ref ht);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Rem(ref ht);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Cl(ref ht);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Count(ref ht);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Cont(ref ht);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Hash(ref ht);
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
