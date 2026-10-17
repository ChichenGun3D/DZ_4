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
            Console.Write("Введите номер числа Фибоначчи (n): ");
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);

            Console.WriteLine($"{n}-е число Фибоначчи = {result}");
        }

        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}