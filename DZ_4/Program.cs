using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Введите два целых числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("Наибольшее число: " + a);
            } 
            else if (b > a)
            {
                Console.WriteLine("Наибольшее число: " + b);
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

        }
    }
}
