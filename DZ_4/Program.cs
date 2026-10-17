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
            int[] array = new int[20];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 51);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Введите первое число из массива: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число из массива: ");
            int num2 = int.Parse(Console.ReadLine());

            int index1 = -1;
            int index2 = -1;

            for (int i = 0; i < 20; i++)
            {
                if (array[i] == num1)
                {
                    index1 = i;
                }

                if (array[i] == num2)
                {
                    index2 = i;
                }
            }

            if (index1 != -1 && index2 != -1)
            {
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;

                Console.WriteLine("\nМассив после обмена:");
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("\nОдно или оба числа не найдены в массиве!");
            }
        }
    }
}