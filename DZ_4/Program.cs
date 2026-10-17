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

            int result;
            bool isSuccess = TryFactorial(number, out result);

            if (isSuccess)
            {
                Console.WriteLine($"Факториал числа {number} равен: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка! Число слишком большое, произошло переполнение.");
            }
        }        
        static bool TryFactorial(int n, out int result)
        {
            result = 1;
            if (n > 12)
            {
                result = 0;
                return false;
            }

            for (int i = 1; i <= n; i++)
            {
                checked
                {
                    result *= i;
                }
            }

            return true; 
        }
    }
}
