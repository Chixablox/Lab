using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Massive<T>
{
    public int n;
    public T[] array;
    public Massive(int n)
    {
        this.array = new T[n];
        this.n = 0;
    }

    public bool Add(T element)
    {
        if (n == array.Length) return false;
        array[n] = element;
        n++;
        return true;
    }

    public bool Del(int index)
    {
        if ((index < array.Length) && (index >= 0))
        {

            for (var i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            n--;
            return true;
        }
        else
        {
            return false;
        }
    }
    public int Find(T element)
    {
        for (int i = 0; i < n; i++)
        {
            string s1 = Convert.ToString(array[i]);
            string s2 = Convert.ToString(element);
            if (s1 == s2)
                return i;
        }
        return -1;                                  
    }

    public void Vivod()
    {
        for (var i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

 
}

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тип string");
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            Massive<string> array1 = new Massive<string>(n);
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент на добавление");
                string s = Console.ReadLine();
                array1.Add(s);
            }
            array1.Vivod();
            Console.WriteLine();
            Console.WriteLine("Введите элемент, индекс которого хотите найти");
            string element = Console.ReadLine();
            var index = array1.Find(element);
            Console.WriteLine("Индекс найденного элемента: " + index);
            Console.WriteLine("Введите индекс элемента, который вы хотите удалить");
            index = Convert.ToInt32(Console.ReadLine());
            array1.Del(index);
            array1.Vivod();
            Console.ReadLine();

        }
    }
}
