using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        public static void Zap(ref HashSet<string> set)
        {
            Console.WriteLine("Заполнение множества");
            Console.WriteLine("Введите число элементов, которые хотите добавить");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                set.Add(Console.ReadLine());
            }
        }
        public static void Vivod(ref HashSet<string> set)
        {
            foreach (var s in set)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadLine();
        }
        public static void Rem(ref HashSet<string> set)
        {
            Console.WriteLine("Метод Remove");
            Console.WriteLine("\nМножество до использования метода:");
            Vivod(ref set);
            Console.WriteLine("Введите элемент, который хотите удалить");
            string s = Console.ReadLine();
            set.Remove(s);
            Console.WriteLine("\nМножества после использования метода:");
            Vivod(ref set);
        }
        public static void Ob(ref HashSet<string> set1, ref HashSet<string> set2)
        {
            Console.WriteLine("Объединение(метод UnionWith)");
            HashSet<string> set = new HashSet<string>();
            Console.WriteLine("Перовое множество: ");
            Vivod(ref set1);
            Console.WriteLine("Второе множество: ");
            Vivod(ref set2);
            set.UnionWith(set1);
            set.UnionWith(set2);
            Console.WriteLine("\nОбъединение множеств: ");
            Vivod(ref set);
        }
        public static void Per(ref HashSet<string> set1, ref HashSet<string> set2)
        {
            Console.WriteLine("Пересечение(метод Intersect)");
            HashSet<string> set = new HashSet<string>();
            Console.WriteLine("Перовое множество: ");
            Vivod(ref set1);
            Console.WriteLine("Второе множество: ");
            Vivod(ref set2);
            set.UnionWith(set1);
            set.IntersectWith(set2);
            Console.WriteLine("\nПересечение множеств: ");
            Vivod(ref set);
        }
        public static void Raz(ref HashSet<string> set1, ref HashSet<string> set2)
        {
            Console.WriteLine("Разность(метод ExceptWith)");
            Console.WriteLine("Перовое множество: ");
            Vivod(ref set1);
            Console.WriteLine("Второе множество: ");
            Vivod(ref set2);
            HashSet<string> set = new HashSet<string>();
            set.UnionWith(set1);
            set.ExceptWith(set2);
            Console.WriteLine("\nРазность множеств: ");
            Vivod(ref set);
        }
        public static void SRaz(ref HashSet<string> set1, ref HashSet<string> set2)
        {
            Console.WriteLine("Cимметрическая разность(метод UnionWith)");
            HashSet<string> set = new HashSet<string>();
            Console.WriteLine("Перовое множество: ");
            Vivod(ref set1);
            Console.WriteLine("Второе множество: ");
            Vivod(ref set2);
            set.UnionWith(set1);
            set.SymmetricExceptWith(set2);
            Console.WriteLine("\nCимметрическая разность множеств: ");
            Vivod(ref set);
        }
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1-Заполнение множества\n2-Вывод множества\n3-Заполнение вспомогательного\n4-Вывод вспомогательного множества\n5-Удаление элементов\n6-Удаление элементов вспомогательного множества\n7-Объединение\n8-Пересечение\n9-Разность\n0-Симметрическая разность\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Zap(ref set1);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Содержимое множества: ");
                        Vivod(ref set1);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Zap(ref set2);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Содержимое вспомогательного множества: ");
                        Vivod(ref set2);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Rem(ref set1);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Rem(ref set2);
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Ob(ref set1, ref set2);
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Per(ref set1, ref set2);
                        break;
                    case ConsoleKey.D9:
                        Console.Clear();
                        Raz(ref set1, ref set2);
                        break;
                    case ConsoleKey.D0:
                        Console.Clear();
                        SRaz(ref set1, ref set2);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
