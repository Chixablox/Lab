using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Tovar
    {
        public string name;
        public string date;
        public int srok;
        public string proiz;
        public string dates;
        public int kolvop;
        public int kolvos;

        public Tovar(string name, string date, int srok, string proiz, string dates, int kolvop, int kolvos)
        {
            this.name = name;
            this.date = date;
            this.srok = srok;
            this.proiz = proiz;
            this.dates = dates;
            this.kolvop = kolvop;
            this.kolvos = kolvos;
        }
        public Tovar() { }

        public void Print()
        {
            Console.WriteLine(name + " " + date + " " + srok + " " + proiz + " " + dates + " " + kolvop + " " + kolvos);
        }

    }

    class Program
    {
        public static void Zap(ref List<Tovar> tovar)
        {
            Console.Clear();
            int i = 0;
            string name;
            string date;
            int srok;
            string proiz;
            string dates;
            int kolvop;
            int kolvos;
            Console.WriteLine("Введите название");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату");
            date = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите срок");
            srok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите производителя");
            proiz = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату продажи");
            dates = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во проданных");
            kolvop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите общее кол-во");
            kolvos = Convert.ToInt32(Console.ReadLine());
            tovar.Add(new Tovar(name, date, srok, proiz, dates, kolvop, kolvos));
        }
        public static void ProdanoPolnost(ref List<Tovar> tovar)
        {
            Console.Clear();
            var j = 0;
            Console.WriteLine("Полностью проданы следующие товары:/n ");
            for(var i=0; i<tovar.Count; i++)
            {
                if (tovar[i].kolvop == tovar[i].kolvos) 
                {
                    tovar[i].Print();
                    j = j + 1;
                }
            }
            if (j == 0) Console.WriteLine("/nПолностью проданного товара нет");
            Console.ReadLine();
        }
        public static void PoProizvod(ref List<Tovar> tovar)
        {
            Console.Clear();
            Console.WriteLine("Введите производителя, товар которого хотите найти: ");
            int j = 0;
            string s = Convert.ToString(Console.ReadLine());
            for(var i=0; i<tovar.Count; i++)
            {
                if (tovar[i].proiz == s)
                {
                    tovar[i].Print();
                    j = j + 1;
                }
            }
            if (j == 0) Console.WriteLine("/nТовара данного производителя нет");
            Console.ReadLine();
        }
        public static void Ost(ref List<Tovar> tovar)
        {
            Console.Clear();
        }
        static void Main(string[] args)
        {

            List<Tovar> tovar = new List<Tovar>();
            for (; ;)
            {
                Console.Clear();
                Console.Write("1 - Добавление товара\n" + "2 - Выборка просроченного\n" + "3 - Выборка полность проданного товара\n" + "4 - Выборка товара по производителю\n" + "5 - Вывод товара с остатками\n" + "Esc - выход\n");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Zap(ref tovar);
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        ProdanoPolnost(ref tovar);
                        break;
                    case ConsoleKey.D4:
                        PoProizvod(ref tovar);
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
