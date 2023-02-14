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
        public string[] pr = new string[6];
        public int kolvos;

        public Tovar(string name, string date, int srok, string proiz, string[] pr, int kolvos)
        {
            this.name = name;
            this.date = date;
            this.srok = srok;
            this.proiz = proiz;
            this.pr = pr;
            this.kolvos = kolvos;
        }
        public Tovar() { }

        public void Print()
        {
            Console.Write("Название товара: " + name + "\nДата производства: " + date + "\nСрок годности: " + srok + "\nПроизводитель: " + proiz + "\nОбщее кол-во товара: " + kolvos + "\nДата первой продажи: " + pr[0] + "\nКол-во проданных: " + pr[1] + "\nДата второй продажи: " + pr[2] + "\nКол-во проданных: " + pr[3] + "\nДата третьей продажи:  " + pr[4] + "\nКол-во проданных: " + pr[5] + "\n");
        }

    }

    class Program
    {
        //Добавление товара
        public static void Zap(ref List<Tovar> tovar)
        {
            Console.Clear();
            int i = 0;
            string name;
            string date;
            int srok;
            string proiz;
            string[] pr = new string[6];
            int kolvos;
            Console.WriteLine("Введите название товара");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату производства товара (ДД.ММ.ГГГГ)");
            date = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите срок годности товара");
            srok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите производителя товара");
            proiz = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите общее кол-во товара");
            kolvos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите дату первой продажи (ДД.ММ.ГГГГ)");
            pr[0] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во проданных");
            pr[1] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату второй продажи (ДД.ММ.ГГГГ)");
            pr[2] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во проданных");
            pr[3] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату третьей продажи (ДД.ММ.ГГГГ)");
            pr[4] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите кол-во проданных");
            pr[5] = Convert.ToString(Console.ReadLine());
            tovar.Add(new Tovar(name, date, srok, proiz, pr, kolvos));
        }
        //Поиск полностью проданных
        public static void ProdanoPolnost(ref List<Tovar> tovar)
        {
            Console.Clear();
            var j = 0;
            Console.WriteLine("Полностью проданы следующие товары:\n ");
            for (var i = 0; i < tovar.Count; i++)
            {
                int k = Convert.ToInt32(tovar[i].pr[1]) + Convert.ToInt32(tovar[i].pr[3]) + Convert.ToInt32(tovar[i].pr[5]);
                if (k == tovar[i].kolvos)
                {
                    tovar[i].Print();
                    j = j + 1;
                }
            }
            if (j == 0) Console.WriteLine("Полностью проданного товара нет");
            Console.ReadLine();
        }
        //Поиск по производителю
        public static void PoProizvod(ref List<Tovar> tovar)
        {
            Console.Clear();
            Console.WriteLine("Введите производителя, товар которого хотите найти: ");
            int j = 0;
            string s = Convert.ToString(Console.ReadLine());
            for (var i = 0; i < tovar.Count; i++)
            {
                if (tovar[i].proiz == s)
                {
                    tovar[i].Print();
                    j = j + 1;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Товаров данного производителя нет");
            }
            Console.ReadLine();
        }
        //Поиск остатков товара
        public static void Ost(ref List<Tovar> tovar)
        {
            Console.Clear();
            int j = 0, k=0;
            for (var i=0; i<tovar.Count(); i++)
            {
                int kolvop = k = Convert.ToInt32(tovar[i].pr[1]) + Convert.ToInt32(tovar[i].pr[3]) + Convert.ToInt32(tovar[i].pr[5]);
                if (tovar[i].kolvos - kolvop > 0)
                {
                    j = j + 1;
                    tovar[i].Print();
                    k=tovar[i].kolvos-kolvop;
                    Console.WriteLine("Осталось " + k + " единиц данного товара\n");
                }
            }
            if (j == 0) Console.WriteLine("Все товары были проданы");
            Console.ReadLine();
        }
        //Выборока просроченных товаров
        public static void Prosrok(ref List<Tovar> tovar)
        {
            Console.Clear();
            Console.WriteLine("Data segodnya");
            int j=0;
            string s = Convert.ToString(Console.ReadLine());
            int day = Convert.ToInt32(s.Substring(0,2));
            int mounth = Convert.ToInt32(s.Substring(3,2));
            int year = Convert.ToInt32(s.Substring(6,4));
            for (var i = 0; i < tovar.Count; i++)
            {
                string s1 = tovar[i].date;
                int day1 = Convert.ToInt32(s1.Substring(0,2));
                int mounth1 = Convert.ToInt32(s1.Substring(3,2));
                int year1 = Convert.ToInt32(s1.Substring(6,4));
                int dens = day1+tovar[i].srok;
                for (; ;)
                {
                    if (((mounth1 == 1) || (mounth1 == 3) || (mounth1 == 5) || (mounth1 == 7) || (mounth1 == 8) || (mounth1 == 10) || (mounth1 == 12)) && (dens > 31))
                    {
                        dens = dens - 31;
                        mounth1 = mounth1 + 1;
                        if (((mounth1 == 8) && (dens <= 31)) || (((mounth1 == 4) || (mounth1 == 6) || (mounth1 == 9) || (mounth1 == 11)) && (dens <= 30)) || (((mounth1 == 02)) && (dens <= 28))) break;
                    }
                    if (((mounth1 == 4) || (mounth1 == 6) || (mounth1 == 9) || (mounth1 == 11)) && (dens > 30))
                    {
                        dens = dens - 30;
                        mounth1 = mounth1 + 1;
                        if (((mounth1 == 1) || (mounth1 == 3) || (mounth1 == 5) || (mounth1 == 7) || (mounth1 == 8) || (mounth1 == 10) || (mounth1 == 12)) && (dens <= 31)) break;
                    }
                    if (((mounth1 == 02)) && (dens > 28))
                    {
                        dens = dens - 28;
                        mounth1 = mounth1 + 1;
                        if (((mounth1 == 1) || (mounth1 == 3) || (mounth1 == 5) || (mounth1 == 7) || (mounth1 == 8) || (mounth1 == 10) || (mounth1 == 12)) && (dens <= 31)) break;
                    }
                    if (mounth1 == 13)
                    {
                        year1 = year1 + 1;
                        mounth1 = 1;
                    }
                }
                if (year1 >= year)
                {
                    if (mounth1 == mounth)
                    {
                        if (dens < day)
                        {
                            j = j + 1;
                            tovar[i].Print();
                            Console.WriteLine("Срок годности вышел: ");
                            Console.WriteLine(dens + "." + mounth1 + "." + year1);
                        }
                    }
                    if (mounth1 < mounth)
                    {
                        j = j + 1;
                        tovar[i].Print();
                        Console.WriteLine("Срок годности вышел: ");
                        Console.WriteLine(dens + "." + mounth1 + "." + year1);
                    }
                }
                else
                {
                    j = j + 1;
                    tovar[i].Print();
                    Console.WriteLine("Срок годности вышел:");
                    Console.WriteLine(dens + "." + mounth1 + "." + year1);
                }
            }
            if (j == 0) Console.WriteLine("Просроченных товаров нет!");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            List<Tovar> tovar = new List<Tovar>();
            for (; ; )
            {
                Console.Clear();
                Console.Write("1 - Добавление товара\n" + "2 - Выборка просроченного\n" + "3 - Выборка полность проданного товара\n" + "4 - Выборка товара по производителю\n" + "5 - Вывод товара с остатками\n" + "Esc - выход\n");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Zap(ref tovar);
                        break;
                    case ConsoleKey.D2:
                        if (tovar.Count > 0) Prosrok(ref tovar);
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Список товаров пуст, добавьте товар");
                            Console.ReadLine();
                        }
                        break;
                        break;
                    case ConsoleKey.D3:
                        if (tovar.Count > 0) ProdanoPolnost(ref tovar);
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Список товаров пуст, добавьте товар");
                            Console.ReadLine();
                        }
                        break;
                    case ConsoleKey.D4:
                        if (tovar.Count > 0) PoProizvod(ref tovar);
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Список товаров пуст, добавьте товар");
                            Console.ReadLine();
                        }
                        break;
                    case ConsoleKey.D5:
                        if (tovar.Count > 0) Ost(ref tovar);
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Список товаров пуст, добавьте товар");
                            Console.ReadLine();
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }

            }
        }
    }
}
