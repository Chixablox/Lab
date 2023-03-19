using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication10
{
    class Program
    {
        static void Zapolnenie(ref ArrayList arr)
        {
            Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                var m = Console.ReadLine();
                arr.Add(m);
            }
        }
        static void Zap2(ref ArrayList arr2)
        {
            Console.WriteLine("Введите кол-во элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                var m = Console.ReadLine();
                arr2.Add(m);
            }
        }
        static void Vivod(ref ArrayList arr)
        {
            for (var i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
        static void Prosmotr(ref ArrayList arr2)
        {
            {
                for (var i = 0; i < arr2.Count; i++)
                {
                    Console.Write(arr2[i] + " ");
                }
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
        static void Funk(ref ArrayList arr, ref ArrayList arr2)
        {
            for (; ; )
            {
                Console.WriteLine("1-Сортировка\n2-Бинарный поиск\n3-Удаление\n4-Разворот\n5-Поиск длины\n6-Вставить элементы вспомогательной коллекции\n7-Заменить элементы элементами вспомогательной коллекции\n8-Найти индекс вхождения элемента\n9-Вывод\n0-Вывод вспомогательной коллекции\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Sort(ref arr);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Binary(ref arr);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Remove(ref arr);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Rev(ref arr);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Len(ref arr);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Insert(ref arr, ref arr2);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Set(ref arr, ref arr2);
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Index(ref arr);
                        break;
                    case ConsoleKey.D9:
                        Console.Clear();
                        Vivod(ref arr);
                        break;
                    case ConsoleKey.D0:
                        Console.Clear();
                        Prosmotr(ref arr2);
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;
                }
                Console.Clear();
            }
        }
        static void Index(ref ArrayList arr)
        {
            Console.WriteLine("Введите элемент индекс которого хотите найти");
            var g = Console.ReadLine();
            Console.WriteLine("1-Индекс первого вхождения элемента\n2-Индекс последнего вхождения элемента\n");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    var index = arr.IndexOf(g);
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
                    var indexl = arr.LastIndexOf(g);
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
        static void Set(ref ArrayList arr, ref ArrayList arr2)
        {
            Console.WriteLine("Введите индекс, с которого заменять элементы");
            int index = Convert.ToInt32(Console.ReadLine());
            arr.SetRange(index, arr2);
        }
        static void Insert(ref ArrayList arr, ref ArrayList arr2)
        {
            Console.WriteLine("Введите индекс, с которого вставлять вспомогательную коллекцию");
            int index = Convert.ToInt32(Console.ReadLine());
            arr.InsertRange(index, arr2);
        }
        static void Sort(ref ArrayList arr)
        {
            arr.Sort();
        }
        static void Binary(ref ArrayList arr)
        {
            Console.WriteLine("Введите элемент");
            var g = Console.ReadLine();
            int index = arr.BinarySearch(g);
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
        static void Remove(ref ArrayList arr)
        {
            Console.WriteLine("Введите индекс, с которого надо удалять");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количесвто элементов на удвление");
            int count = Convert.ToInt32(Console.ReadLine());
            arr.RemoveRange(index, count);

        }
        static void Rev(ref ArrayList arr)
        {
            arr.Reverse();
        }
        static void Len(ref ArrayList arr)
        {
            int len = arr.Count;
            Console.WriteLine("Длина: " + len);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList();
            for (; ; )
            {
                Console.WriteLine("1-Ввод\n2-Вывод\n3-Заполнить всмогательную коллекцию\n4-Вывод вспомогательной колекции\n5-Переход к методам\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zapolnenie(ref arr);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Vivod(ref arr);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Prosmotr(ref arr2);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Zap2(ref arr2);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Funk(ref arr, ref arr2);
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
