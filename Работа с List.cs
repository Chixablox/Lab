using System;
using System.Collections.Generic;

namespace Работа_с_List
{
class Program
{
        static void Zapolnenie(ref List<string> ls)
        {
            Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                var m = Console.ReadLine();
                ls.Add(m);
            }
        }
        static void Vivod(ref List<string> ls)
        {
            for (var i = 0; i < ls.Count; i++)
            {
                Console.Write(ls[i] + " ");
            }
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.....");
            Console.ReadLine();
        }
        static void Funk(ref List<string> ls, ref List<string> ls2)
        {
            for (; ; )
            {
                Console.WriteLine("1-Сортировка\n2-Бинарный поиск\n3-Удаление\n4-Разворот\n5-Поиск длины\n6-Найти индекс вхождения элемента\n7-Вставить элементы вспомогательной коллекции\n8-Скопировать элементы основной коллекции в одномерный массив\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Sort(ref ls);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Binary(ref ls);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Remove(ref ls);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Rev(ref ls);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Len(ref ls);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Index(ref ls);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Insert(ref ls, ref ls2);
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Copy(ref ls);
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;
                }
                Console.Clear();
            }
        }
        static void Copy(ref List<string> ls)
        {
            Console.WriteLine("Содержимое листа: ");
            Vivod(ref ls);
            Console.WriteLine("\nВведите индекс, с которого копировать");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чиcло элементов на копирование");
            int ch = Convert.ToInt32(Console.ReadLine());
            string[] cop = new string[ls.Count];
            ls.CopyTo(n, cop, 0, ch);
            Console.WriteLine("\nПолученный массив: ");
            for(var i=0; i<ch; i++)
            {
                Console.Write(cop[i] + " ");
            }
            Console.ReadLine();

        }
        static void Index(ref List<string> ls)
        {
            Console.WriteLine("Введите элемент индекс которого хотите найти");
            var g = Console.ReadLine();
            Console.WriteLine("1-Индекс первого вхождения элемента\n2-Индекс последнего вхождения элемента\n");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    var index = ls.IndexOf(g);
                    if (index >= 0)
                    {
                        Console.WriteLine("Индекс первого вхождения:" + index);
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента нет");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    var indexl = ls.LastIndexOf(g);
                    if (indexl >= 0)
                    {
                        Console.WriteLine("Индекс последнего вхождения:" + indexl);
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента нет");
                    }
                    break;
            }
            Console.ReadLine();
        }
        static void Insert(ref List<string> ls, ref List<string> ls2)
        {
            Console.WriteLine("Лист до: ");
            Vivod(ref ls);
            Console.WriteLine("\nВведите индекс, с которого вставлять вспомогательную коллекцию");
            int index = Convert.ToInt32(Console.ReadLine());
            ls.InsertRange(index, ls2);
            Console.WriteLine("\nЛист после: ");
            Vivod(ref ls);
        }
        static void Sort(ref List<string> ls)
        {
            Console.WriteLine("Лист до: ");
            Vivod(ref ls);
            ls.Sort();
            Console.WriteLine("\nЛист после: ");
            Vivod(ref ls);
        }
        static void Binary(ref List<string> ls)
        {
            Console.WriteLine("Введите элемент");
            var g = Console.ReadLine();
            int index = ls.BinarySearch(g);
            if (index >= 0)
            {
                Console.WriteLine("Его индекс: " + index);
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }
            Console.ReadLine();
        }
        static void Remove(ref List<string> ls)
        {
            Console.WriteLine("Лист до: ");
            Vivod(ref ls);
            Console.WriteLine("\nВведите индекс, с которого надо удалять");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количесвто элементов на удаление\n");
            int count = Convert.ToInt32(Console.ReadLine());
            ls.RemoveRange(index, count);
            Console.WriteLine("Лист после: ");
            Vivod(ref ls);

        }
        static void Rev(ref List<string> ls)
        {
            Console.WriteLine("Лист до: ");
            Vivod(ref ls);
            ls.Reverse();
            Console.WriteLine("\nЛист после: ");
            Vivod(ref ls);
        }
        static void Len(ref List<string> ls)
        {
            int len = ls.Count;
            Console.WriteLine("Длина: " + len);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<string> ls = new List<string>();
            List<string> ls2 = new List<string>();
            for (; ; )
            {
                Console.WriteLine("1-Ввод\n2-Вывод\n3-Заполнить всмогательную коллекцию\n4-Вывод вспомогательной колекции\n5-Переход к методам\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zapolnenie(ref ls);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Vivod(ref ls);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Zapolnenie(ref ls2);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Vivod(ref ls2);
                    break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Funk(ref ls, ref ls2);
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
