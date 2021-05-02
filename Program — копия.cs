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
            //a->b b->c c->a

            Console.WriteLine("Введите три целых числа (a;b;c)");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int temp = b;
            b = a;
            a = c;
            c = temp;

            Console.WriteLine("a= {0},b= {1}, c={2}", a, b, c);

            Console.ReadLine();
        }

    }
}
