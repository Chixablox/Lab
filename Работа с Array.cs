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
        public static void Zap(ref Array arr)
        {
            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("Заполнение массива");
            for (var i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Введите строку");
                string n = Convert.ToString(Console.ReadLine());
                arr.SetValue(n, i);
            }
        }
        public static void Vivod(ref Array arr)
        {
            System.Collections.IEnumerator myEnumerator = arr.GetEnumerator();
            for (var i=0; i<arr.Length; i++)
            {
                myEnumerator.MoveNext();
                Console.Write(myEnumerator.Current + " ");
            }
            Console.WriteLine("\nНажмите Entre.....");
            Console.ReadLine();
        }
        public static void Sort(ref Array arr)
        {
            Console.WriteLine("Сортировка");
            Console.WriteLine("Массив до сортировки:");
            Vivod(ref arr);
            Array.Sort(arr);
            Console.WriteLine("\nМассив после сортировки:");
            Vivod(ref arr);
        }
        public static void Bin(ref Array arr)
        {
            Console.WriteLine("Бинарный поиск");
            Console.WriteLine("Введите элемент, индекс которого хотите найти");
            string s = Console.ReadLine();
            int b = Array.BinarySearch(arr,s);
            if (b >= 0)
            {
                Console.WriteLine("Индекс элемента " + s + " равен " + b);
            }
            else
            {
                Console.WriteLine("Такого элемента в массиве нет");
            }
            Console.ReadLine();
        }
        public static void Val(ref Array arr)
        {
            Console.WriteLine("Поиск значения");
            Console.WriteLine("Введите индекс");
            int n = Convert.ToInt32(Console.ReadLine());
            if ((n > 5) || (n < 0))
            {
                Console.WriteLine("Неверный индекс");
            }
            else
            {
                object s = arr.GetValue(n);
                Console.WriteLine("Найден элемент: " + s);
            }
            Console.ReadLine();
        }
        public static void Rank (ref Array arr)
        {
            Console.WriteLine("Количество измерений массива: " + arr.Rank);
            Console.ReadLine();
        }
        public static void Find(ref Array arr)
        {
            Console.WriteLine("Введите элемент индекс которого хотите найти");
            var g = Console.ReadLine();
            Console.WriteLine("1-Индекс первого вхождения элемента\n2-Индекс последнего вхождения элемента\n");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    var index = Array.IndexOf(arr,g);
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
                    var indexl = Array.LastIndexOf(arr, g);
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
        public static void Rev(ref Array arr)
        {
            Console.WriteLine("Разворот массива");
            Console.WriteLine("Массив до: ");
            Vivod(ref arr);
            Array.Reverse(arr);
            Console.WriteLine("Массив после: ");
            Vivod(ref arr);
        }
        static void Main(string[] args)
        {
            Array arr = Array.CreateInstance(typeof(String), 5);
            Array arr2 = Array.CreateInstance(typeof(String), 5);
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1-Ввод\n2-Вывод\n3-Sort\n4-Reverse\n5-BinarySearch\n6-GetValue\n7-IndexOf\n8-Rank\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zap(ref arr);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Vivod(ref arr);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Sort(ref arr);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Rev(ref arr);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Bin(ref arr);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Val(ref arr);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Find(ref arr);
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Rank(ref arr);
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
