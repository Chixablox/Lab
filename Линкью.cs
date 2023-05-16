using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void ListPrint(List<int> test)
        {
            for (var i = 0; i < test.Count; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine("");
        }


        static void Linq(List<int> test)
        {
            Console.WriteLine("Cодержимое листа: ");
            ListPrint(test);

            var pol = from num in test
                      where num > 0
                      select num;

            Console.WriteLine("Число положительных: " + pol.Count());

            var chet = from num in test
                       where num % 2 == 0
                       select num;

            Console.WriteLine("Число чётных: " + chet.Count());

            int max = test.Max();
            int min = test.Min();

            Console.WriteLine("Минимум: " + min + "\nМаксимум: " + max);
        }


        static void Main(string[] args)
        {
            List<int> test = new List<int>();
            Console.WriteLine("Сколько элементов вы хотите добавить?");
            int n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент");
                test.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Clear();
            Linq(test);

            for (var i = 0; i < test.Count; i++)
            {
                if (test[i] < 0)
                {
                    test.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine();
            Linq(test);

            Console.ReadLine();
 
        }
    }
}
