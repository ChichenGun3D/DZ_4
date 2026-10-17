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
            Console.WriteLine("Введите первое число");
            int Numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int Numb2 = Convert.ToInt32(Console.ReadLine());
            int Numb22 = Numb1;
            int numb11 = Numb2;
            Console.WriteLine("Параметры до смены местами: {0} и {1}", numb11, Numb22);
            Console.WriteLine("Параметры после смены местами: {1} и {0}", numb11, Numb22);
        }
    }
}
