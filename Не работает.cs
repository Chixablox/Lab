using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Convert.ToString(Console.ReadLine());
            Stack<char> strokan = new Stack<char>();
            Stack<char> strokak = new Stack<char>();
            int m = 0;
            int otvet = 0;
            for (var i = s.Length - 1; i>=0; i--)
            {
                if ((s[i] == '{')  || (s[i] == '[') || (s[i] == '('))
                {
                    strokan.Push(s[i]);
                }
                   
            }
            int k = 0;
            Console.WriteLine();
            while (strokan.Count > 0)
            {
                char cn = strokan.Peek();
                Console.WriteLine(cn);
                if (cn == '[')
                {
                    int i = s.LastIndexOf(']');
                    int j = s.IndexOf('[');
                    if (j < i)
                    {
                        otvet += 1;
                        s = s.Remove(j, 1);
                        if (i > 0)
                            s = s.Remove(i - 1, 1);
                        else if (i == 0)
                            s = s.Remove(i, 1);
                        cn = strokan.Pop();
                    }
                    else
                    {
                        if (i > 0)
                            s = s.Remove(i - 1, 1);
                        else if (i == 0)
                            s = s.Remove(i, 1);
                    }
                }
                if (cn == '{')
                {
                    int i = s.LastIndexOf('}');
                    int j = s.IndexOf('{');
                    if (j < i)
                    {
                        otvet += 1;
                        s = s.Remove(j, 1);
                        if (i > 0)
                            s = s.Remove(i - 1, 1);
                        else if (i == 0)
                            s = s.Remove(i, 1);
                        cn = strokan.Pop();
                    }
                    else
                    {
                        if (i > 0)
                            s = s.Remove(i - 1, 1);
                        else if (i == 0)
                            s = s.Remove(i, 1);
                    }
                }
                if (cn == '(')
                {
                    int i = s.LastIndexOf(')');
                    int j = s.IndexOf('(');
                    if (j < i)
                    {
                        otvet += 1;
                        s = s.Remove(j, 1);
                        if (i > 0)
                            s = s.Remove(i - 1, 1);
                        else if (i == 0)
                            s = s.Remove(i, 1);
                        cn = strokan.Pop();
                    }
                    else
                    {
                        if (i > 0)
                            s = s.Remove(i - 1, 1);
                        else if (i == 0)
                            s = s.Remove(i, 1);
                    }
                }

            }
            Console.WriteLine(otvet);
            Console.WriteLine(s);
            Console.ReadLine();
            
        }
    }
}
