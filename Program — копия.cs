using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три целых числа (a;b;c)");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            //1)          2)    3)
            a = a + c;              //a+c        a+c     c
            c = c + b;              //b+a+c      a       a
            b = b + a;              //c+b        c+b     b

            b = b - c;

            a = a - b;
            c = c - a;

            Console.WriteLine("a= {0},b= {1}, c={2}", a, b, c);

            Console.ReadLine();
        }

    }
}
