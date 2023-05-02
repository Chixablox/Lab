using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    delegate void Pomivka(Garage garage);  
    class Auto
    {
        string model;
        string number;
        public Auto(string model, string number)
        {
            this.model = model;
            this.number = number;
        }
        public string Print()
        {
            return "марки " + model + " с номером " + number;
        }
    }
    class Garage
    {
        public List<Auto> gar;
        public Garage(List<Auto> gar)
        {
            this.gar = gar;
        }
        public void Add(Auto auto)
        {
            try
            {
                gar.Add(auto);
            }
            catch
            {
                Console.WriteLine("Вы добаляете пустоту");
            }
        }
        public int Count()
        {
            return gar.Count();
        }
    }

    class Moika
    {
        public void Pomivka(Garage garage)
        {
            for (int i = 0; i < garage.Count() ; i++)
            {
                Console.WriteLine("Машина " + garage.gar[i].Print() + " была помыта");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> gar = new List<Auto>();
            Garage garage = new Garage(gar);
            Moika moika = new Moika();
            Console.WriteLine("Сколько машин вы хотите добавить в гараж: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите марку машины ");
                string model = Console.ReadLine();
                Console.WriteLine("Введите номер машины ");
                string number = Console.ReadLine();
                gar.Add(new Auto(model, number));
                Console.WriteLine();
            }
            Pomivka pom = moika.Pomivka;
            pom(garage);
            Console.ReadLine();
        }
    }
}
