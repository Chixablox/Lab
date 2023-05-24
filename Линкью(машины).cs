using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Auto
    {
        public int id;
        public string mark;
        string colour;
        string date;

        public Auto(int id, string mark, string colour, string date)
        {
            this.id = id;
            this.mark = mark;
            this.colour = colour;
            this.date = date;
        }
        public void PrintAuto()
        {
            Console.WriteLine("Id: " + id + "\nМарка: " + mark + "\nЦвет: " + colour + "\nДата выпуска: " + date + "\n");
        }
    }

    class Person
    {
        public int id;
        public string fam;
        public string name;
        public string ot;
        string age;
        public int car_id;

        public Person(int id, string fam, string name, string ot, string age, int car_id)
        {
            this.id = id;
            this.fam = fam;
            this.name = name;
            this.ot = ot;
            this.age = age;
            this.car_id = car_id;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Id: " + id + "\nФИО: " + fam + " " + name + " " + ot + "\nВозраст: " + age + "\nId машины: " + car_id + "\n");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько машин вы хотите добавить?");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Auto> auto = new List<Auto>() { new Auto(1, "Форд", "Серый", "1992"), new Auto(2, "Форд", "Белый", "1994"), new Auto(3, "Порш", "Серый", "2001"), 
                new Auto(4, "Лада", "Синий", "1997")};
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите айди");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите марку");
                string mark = Console.ReadLine();
                Console.WriteLine("Введите цвет");
                string colour = Console.ReadLine();
                Console.WriteLine("Введите год выпуска");
                string date = Console.ReadLine();
                auto.Add(new Auto(id, mark, colour, date));
                Console.WriteLine("");
            }

            Console.WriteLine("Сколько влыдельцев вы хотите добавить?");
            n = Convert.ToInt32(Console.ReadLine());
            List<Person> person = new List<Person>() { new Person(1, "Иванов", "Александр", "Олегович", "24", 1), new Person(2, "Попов", "Роман", "Александрович", "27", 1), 
                new Person(3, "Зябрев", "Кирилл", "Сергеевич", "19", 3), new Person(4, "Попов", "Никита", "Иванович", "19", 4), new Person(4, "Христолюбов", "Илья", "Дмитриевич", "19", 4)};
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите айди");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите фамилию");
                string fam = Console.ReadLine();
                Console.WriteLine("Введите имя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                string ot = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                string age = Console.ReadLine();
                Console.WriteLine("Введите айди машины");
                int car_id = Convert.ToInt32(Console.ReadLine());
                person.Add(new Person(id, fam, name, ot, age, car_id));
                Console.WriteLine("");
            }

            person[0].PrintPerson();

            var a = from per in person
                    group per by per.car_id;
            foreach (var i in a)
            {
                Console.WriteLine("Владельцы машины с id " + i.Key + " :");
                foreach (var per in i)
                {
                    per.PrintPerson();
                }
            }

            Console.WriteLine("Машины какой марки вы хотите найти?");
            string s = Console.ReadLine();
            var carMark = from car in auto
                    where car.mark == s
                    select car;
            foreach (var i in carMark)
            {
                i.PrintAuto();
            }

            Console.WriteLine("Введите фамилию, по которой хотите найти человека");
            s = Console.ReadLine();
            var perFam = from per in person
                           where per.fam == s
                           select per;
            foreach (var i in perFam)
            {
                i.PrintPerson();
            }

            Console.ReadLine();


        }
    }
}
