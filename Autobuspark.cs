using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    struct Orders
    {
        public string title;
        public string date;
    }
    struct Lb
    {
        public string number;
    }
    struct Repair
    {
        public string type;
        public string number;
        public string dateofrepair;
    }
    struct ARepair
    {
        public string mechanic;
        public string daterp;
    }
    public struct Exp
    {
        public string company;
        public DateTime workfrom;
        public DateTime dismissedfrom;
    }

    abstract class Personal
    {
        public string name;
        protected string birthday;
        public DateTime workfrom;
        public List<Exp> pastexp;

        public Personal(string name, string birthday, DateTime workfrom, List<Exp> pastexp)
        {
            this.name = name;
            this.birthday = birthday;
            this.workfrom = workfrom;
            this.pastexp = pastexp;
        }
        public abstract void Print();
    }
    class Manager : Personal
    {
        public List<Orders> orders;
        public Manager(string name, string birthday, DateTime workfrom, List<Exp> pastexp, List<Orders> orders)
            : base(name, birthday, workfrom, pastexp)
        {
            this.orders = orders;
        }
        public override void Print()
        {
            Console.Clear();
            Console.WriteLine("Имя: " + name + "\nДата рождения: " + birthday + "\nРаботает с: " + workfrom.ToShortDateString() + "\nПредыдущие меса работы: ");
            for (var i = 0; i < pastexp.Count; i++)
            {
                Console.WriteLine("\tКомпания: " + pastexp[i].company + "\n\tРаботал с: " + pastexp[i].workfrom.ToShortDateString() + "\n\tРаботал до: " + pastexp[i].dismissedfrom.ToShortDateString());
            }
            Console.WriteLine("Приказы: ");
            for (var i = 0; i < orders.Count; i++)
            {
                Console.WriteLine("\tНазвание приказа: " + orders[i].title + "\n\t\tДата введения приказа:" + orders[i].date);
            }
        }
    }
    class Driver : Personal
    {
        public List<Lb> lb;
        public Driver(string name, string birthday, DateTime workfrom, List<Exp> pastexp, List<Lb> lb)
            : base(name, birthday, workfrom, pastexp)
        {
            this.lb = lb;
        }
        public override void Print()
        {
            Console.Clear();
            Console.WriteLine("Имя: " + name + "\nДата рождения: " + birthday + "\nРаботает с: " + workfrom.ToShortDateString() + "\nПредыдущие меса работы: ");
            for (var i = 0; i < pastexp.Count; i++)
            {
                Console.WriteLine("\tКомпания: " + pastexp[i].company + "\n\tРаботал с: " + pastexp[i].workfrom.ToShortDateString() + "\n\tРаботал до: " + pastexp[i].dismissedfrom.ToShortDateString());
            }
            Console.WriteLine("Машины водителя: ");
            for (var i = 0; i < lb.Count; i++)
            {
                Console.WriteLine("\tНомер машины: " + lb[i].number);
            }
        }
    }
    class Mechanic : Personal
    {
        private List<Repair> rp;
        public Mechanic(string name, string birthday, DateTime workfrom, List<Exp> pastexp, List<Repair> rp)
            : base(name, birthday, workfrom, pastexp)
        {
            this.rp = rp;
        }
        public override void Print()
        {
            Console.Clear();
            Console.WriteLine("Имя: " + name + "\nДата рождения: " + birthday + "\nРаботает с: " + workfrom.ToShortDateString() + "\nПредыдущие меса работы: ");
            for (var i = 0; i < pastexp.Count; i++)
            {
                Console.WriteLine("\tКомпания: " + pastexp[i].company + "\n\tРаботал с: " + pastexp[i].workfrom.ToShortDateString() + "\n\tРаботал до: " + pastexp[i].dismissedfrom.ToShortDateString());
            }
            Console.WriteLine("Ремонтировал: ");
            for (var i = 0; i < rp.Count; i++)
            {
                Console.WriteLine("\tТип ремонта: " + rp[i].type + "\n\t Номер машины:" + rp[i].number + "\n\tДата ремонта: " + rp[i].dateofrepair);
            }
        }
    }
    class Transport
    {
        private string type;
        private string number;
        private List<string> inspection;
        private List<string> drivers;
        private List<ARepair> rp;
        public Transport(string type, string number, List<string> inspection, List<string> drivers, List<ARepair> rp)
        {
            this.type = type;
            this.number = number;
            this.inspection = inspection;
            this.drivers = drivers;
            this.rp = rp;
        }
        public void PrintT()
        {
            Console.WriteLine("Тип: " + type + "\n: " + number);
            for (var i = 0; i < inspection.Count; i++)
            {
                Console.WriteLine("Дата " + i + "-го техосмотра: " + inspection[i]);
            }
            Console.WriteLine("За автобусом закреплены:");
            for (var i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine("\t" + drivers[i]);
            }
            Console.WriteLine("Ремонт:");
            for (var i = 0; i < rp.Count; i++)
            {
                Console.WriteLine("\tРемонтировал: " + rp[i].mechanic + "\n\tДата ремонта: " + rp[i].daterp);
            }
        }
    }
    class Program
    {
        public static void NewDriver(ref List<Driver> drivers)
        {
            Console.Clear();
            Console.WriteLine("Введите имя водителя");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите дату рождения водителя");
            string birthday = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите число, с которого работает водитель в ваше компании");
            DateTime workfrom = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите число предыдущих мест работы данного водителя");
            int k = Convert.ToInt32(Console.ReadLine());
            List<Exp> exp = new List<Exp>();
            for (var i = 0; i < k; i++)
            {
                Exp vexp = new Exp();
                Console.WriteLine("Введите название компании");
                vexp.company = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату принятия на работу");
                vexp.workfrom = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите дату увольнения");
                vexp.dismissedfrom = Convert.ToDateTime(Console.ReadLine());
                exp.Add(vexp);

            }
            Console.WriteLine("Введите число автобусов, которые водил водитель");
            k = Convert.ToInt32(Console.ReadLine());
            List<Lb> lb = new List<Lb>();
            for (var i = 0; i < k; i++)
            {
                Lb vlb = new Lb();
                Console.WriteLine("Введите номер машины");
                vlb.number = Convert.ToString(Console.ReadLine());
                lb.Add(vlb);

            }
            drivers.Add(new Driver(name, birthday, workfrom, exp, lb));
            Console.Clear();
        }
        public static void NewManager(ref List<Manager> managers)
        {
            Console.Clear();
            Console.WriteLine("Введите имя");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите дату рождения");
            string birthday = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите число, с которого человек работает в ваше компании");
            DateTime workfrom = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите число предыдущих мест работы данного человека");
            int k = Convert.ToInt32(Console.ReadLine());
            List<Exp> exp = new List<Exp>();
            for (var i = 0; i < k; i++)
            {
                Exp vexp = new Exp();
                Console.WriteLine("Введите название компании");
                vexp.company = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату принятия");
                vexp.workfrom = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите дату увольнения");
                vexp.dismissedfrom = Convert.ToDateTime(Console.ReadLine());
                exp.Add(vexp);

            }
            Console.WriteLine("Введите число приказов, изаданных данным человеком");
            k = Convert.ToInt32(Console.ReadLine());
            List<Orders> or = new List<Orders>();
            for (var i = 0; i < k; i++)
            {
                Orders vor = new Orders();
                Console.WriteLine("Введите название приказа");
                vor.title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату принятия приказа");
                vor.date = Convert.ToString(Console.ReadLine());
                or.Add(vor);

            }
            managers.Add(new Manager(name, birthday, workfrom, exp, or));
            Console.Clear();
        }
        public static void NewMechanic(ref List<Mechanic> mechanics)
        {
            Console.Clear();
            Console.WriteLine("Введите имя");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите дату рождения");
            string birthday = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите число, с которого человек работает в ваше компании");
            DateTime workfrom = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите число предыдущих мест работы данного человека");
            int k = Convert.ToInt32(Console.ReadLine());
            List<Exp> exp = new List<Exp>();
            for (var i = 0; i < k; i++)
            {
                Exp vexp = new Exp();
                Console.WriteLine("Введите название компании");
                vexp.company = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите принятия увольнения");
                vexp.workfrom = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите дату увольнения");
                vexp.dismissedfrom = Convert.ToDateTime(Console.ReadLine());
                exp.Add(vexp);

            }
            Console.WriteLine("Введите число приказов, изаданных данным человеком");
            k = Convert.ToInt32(Console.ReadLine());
            List<Repair> rep = new List<Repair>();
            for (var i = 0; i < k; i++)
            {
                Repair vrep = new Repair();
                Console.WriteLine("Введите тип работ");
                vrep.type = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите номер машины");
                vrep.number = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату проведения работ");
                vrep.dateofrepair = Convert.ToString(Console.ReadLine());
                rep.Add(vrep);

            }
            mechanics.Add(new Mechanic(name, birthday, workfrom, exp, rep));
            Console.Clear();
        }
        public static void NewTransport(ref List<Transport> transports)
        {
            Console.Clear();
            Console.WriteLine("Введите тип машины");
            string type = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите номер");
            string number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите число техосмотров");
            int k = Convert.ToInt32(Console.ReadLine());
            List<string> inspection = new List<string>();
            for (var i = 0; i < k; i++)
            {
                Console.WriteLine("Ведите дату техосмотра");
                inspection.Add(Convert.ToString(Console.ReadLine()));
            }
            Console.WriteLine("Ведите число водителей данной машины");
            k = Convert.ToInt32(Console.ReadLine());
            List<string> drivers = new List<string>();
            for (var i = 0; i < k; i++)
            {
                Console.WriteLine("Ведите ФИО водителя");
                drivers.Add(Convert.ToString(Console.ReadLine()));
            }
            Console.WriteLine("Ведите число починок");
            k = Convert.ToInt32(Console.ReadLine());
            List<ARepair> rep = new List<ARepair>();
            for (var i = 0; i < k; i++)
            {
                ARepair vrep = new ARepair();
                Console.WriteLine("Введите имя автослесаря");
                vrep.mechanic = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите дату ремнота");
                vrep.daterp = Convert.ToString(Console.ReadLine());
                rep.Add(vrep);

            }
            transports.Add(new Transport(type, number, inspection, drivers, rep));
            Console.Clear();

        }
        public static void Vivod(ref List<Driver> drivers, ref List<Manager> managers, ref List<Mechanic> mechanics, ref List<Transport> transports)
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1-Информация о водителях\n2-Информация об управляющем персонале\n3-Информация об автослесарях\n4-Информация о транспорте\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        for (var i = 0; i < drivers.Count; i++)
                        {
                            drivers[i].Print();
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        for (var i = 0; i < managers.Count; i++)
                        {
                            managers[i].Print();
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        for (var i = 0; i < mechanics.Count; i++)
                        {
                            mechanics[i].Print();
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        for (var i = 0; i < transports.Count; i++)
                        {
                            transports[i].PrintT();
                            Console.WriteLine("\n");
                        }
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;
                }
            }
        }
        public static void Prikaz(ref List<Manager> managers)
        {
            for (var i = 0; i < managers.Count; i++)
            {
                if (managers[i].orders.Count > 0)
                {
                    Console.WriteLine(managers[i].name + ":");
                    for (var j = 0; j < managers[i].orders.Count; j++)
                    {
                        Console.WriteLine("\tПриказ: " + managers[i].orders[j].title + ", действующий с " + managers[i].orders[j].date);
                    }
                }
            }
        }
        public static void Trans(ref List<Driver> drivers)
        {
            Console.WriteLine("Введите имя нужного водителя");
            string name = Convert.ToString(Console.ReadLine());
            int k = 0;
            for (var i = 0; i < drivers.Count; i++)
            {
                if (name == drivers[i].name)
                {
                    k = k + 1;
                    Console.WriteLine(name + " водил: ");
                    for (var j = 0; j < drivers[i].lb.Count; j++)
                    {
                        Console.WriteLine("\tТранспорт номер: " + drivers[i].lb[j].number);
                    }

                }
            }
            if (k == 0) Console.WriteLine(name + " в списке нет");
        }
        public static void Staz(ref List<Driver> drivers, ref List<Manager> managers, ref List<Mechanic> mechanics)
        {
            Console.WriteLine("Введите ФИО работника, стаж которого хотите найти");
            string name = Convert.ToString(Console.ReadLine());
            int l = 0;
            DateTime dt = new DateTime();
            TimeSpan staz = new TimeSpan();
            for (var i=0; i<drivers.Count; i++)
            {
                if (drivers[i].name == name)
                {
                    l = l + 1;
                    Console.WriteLine("Введите сегодняшнюю дату");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    staz = date.Subtract(drivers[i].workfrom);
                    dt = dt + staz;
                    dt = dt.AddYears(-1);
                    Console.WriteLine("Стаж работы в Вашей фирме: " + dt.ToString("%y") + " лет " + dt.ToString("%M") + " месяца " + dt.ToString("%d") + " дней");
                    for(var j=0; j<drivers[i].pastexp.Count; j++)
                    {
                        staz = staz + drivers[i].pastexp[j].dismissedfrom.Subtract(drivers[i].pastexp[j].workfrom);
                    }
                    continue;
                }
            }
            if (l == 0)
            {
                for (var i = 0; i < managers.Count; i++)
                {
                    if (managers[i].name == name)
                    {
                        l = l + 1;
                        Console.WriteLine("Введите сегодняшнюю дату");
                        DateTime date = Convert.ToDateTime(Console.ReadLine());
                        staz = date.Subtract(managers[i].workfrom);
                        dt = dt + staz;
                        Console.WriteLine("Стаж работы в Вашей фирме: " + dt.ToString("%y") + " лет " + dt.ToString("%M") + " месяца " + dt.ToString("%d") + " дней");
                        for (var j = 0; j < managers[i].pastexp.Count; j++)
                        {
                            staz = staz + managers[i].pastexp[j].dismissedfrom.Subtract(managers[i].pastexp[j].workfrom);
                        }
                        continue;
                    }
                }
            }
            if (l == 0)
            {
                for (var i = 0; i < mechanics.Count; i++)
                {
                    if (mechanics[i].name == name)
                    {
                        l = l + 1;
                        Console.WriteLine("Введите сегодняшнюю дату");
                        DateTime date = Convert.ToDateTime(Console.ReadLine());
                        staz = date.Subtract(mechanics[i].workfrom);
                        dt = dt + staz;
                        Console.WriteLine("Стаж работы в Вашей фирме: " + dt.ToString("%y") + " лет " + dt.ToString("%M") + " месяца " + dt.ToString("%d") + " дней");
                        for (var j = 0; j < mechanics[i].pastexp.Count; j++)
                        {
                            staz = staz + mechanics[i].pastexp[j].dismissedfrom.Subtract(mechanics[i].pastexp[j].workfrom);
                        }
                        continue;
                    }
                }
            }
            DateTime dt1 = new DateTime();
            dt = dt + staz;
            Console.WriteLine("Общий стаж: " + dt.ToString("%y") + " лет " + dt.ToString("%M") + " месяца " + dt.ToString("%d") + " дней");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Driver> drivers = new List<Driver>();
            List<Manager> managers = new List<Manager>();
            List<Mechanic> mechanics = new List<Mechanic>();
            List<Transport> transports = new List<Transport>();
            for (; ; )
            {
                Console.WriteLine("1-Добавить водителя\n2-Добавить управляющий персонал\n3-Добавить автослесаря\n4-Добавить новый транспорт\n5-Перейти к функциям вывода\n6-Вывод приказов\n7-Вывод транспорта, закреплённого за водителем\n8-Вывод стажа\nEsc-Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        NewDriver(ref drivers);
                        break;
                    case ConsoleKey.D2:
                        NewManager(ref managers);
                        break;
                    case ConsoleKey.D3:
                        NewMechanic(ref mechanics);
                        break;
                    case ConsoleKey.D4:
                        NewTransport(ref transports);
                        break;
                    case ConsoleKey.D5:
                        Vivod(ref drivers, ref managers, ref mechanics, ref transports);
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Prikaz(ref managers);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Trans(ref drivers);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D8:
                        Console.Clear();
                        Staz(ref drivers, ref managers, ref mechanics);
                        Console.ReadLine();
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
