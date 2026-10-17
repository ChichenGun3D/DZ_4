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
            Console.Write("Введите число для вычисления факториала: ");
            int number = int.Parse(Console.ReadLine());

            int result = Factorial(number);
            Console.WriteLine($"Факториал числа {number} равен: {result}");
        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
