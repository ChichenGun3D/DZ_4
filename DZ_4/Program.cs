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
            {
                int[] myArray = { 2, 4, 6, 8, 10 };

                int product = 1;
                double average;

                int sum = ProcessArray(out average, ref product, myArray);

                Console.WriteLine($"Сумма: {sum}");
                Console.WriteLine($"Произведение (ref): {product}");
                Console.WriteLine($"Среднее арифметическое (out): {average}");
            }

           int ProcessArray(out double avg, ref int prod, params int[] numbers)
            {
                int sum = 0;
                prod = 1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                    prod *= numbers[i];
                }

                if (numbers.Length > 0)
                {
                    avg = (double)sum / numbers.Length;
                }
                else
                {
                    avg = 0;
                }

                return sum;
            }
        }
    }
}