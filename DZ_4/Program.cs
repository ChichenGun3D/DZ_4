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
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            int NOD2 = NOD(a, b);
            int NOD3 = NOD(a, b, c);
            Console.WriteLine($"НОД двух чисел ({a}, {b}) = {NOD2}");
            Console.WriteLine($"НОД трех чисел ({a}, {b}, {c}) = {NOD3}");
        }

        static int NOD(int a, int b)
        {
            while (b != 0)
            {
             int temp = b;
             b = a % b;
             a = temp;
            }
            return a;
        }

        static int NOD(int a, int b, int c)
        {
            int nodAB = NOD(a, b);
            return NOD(nodAB, c);
        }
    }
}