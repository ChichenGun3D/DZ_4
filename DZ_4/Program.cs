using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                {
                    string[] digits = {
            "###\n# #\n# #\n# #\n###", // 0
            "  #\n  #\n  #\n  #\n  #", // 1
            "###\n  #\n###\n#  \n###", // 2
            "###\n  #\n###\n  #\n###", // 3
            "# #\n# #\n###\n  #\n  #", // 4
            "###\n#  \n###\n  #\n###", // 5
            "###\n#  \n###\n# #\n###", // 6
            "###\n  #\n  #\n  #\n  #", // 7
            "###\n# #\n###\n# #\n###", // 8
            "###\n# #\n###\n  #\n###"  // 9
        };

                    while (true)
                    {
                        Console.Write("Введите цифру (или 'exit' для выхода): ");
                        string input = Console.ReadLine();

                        if (input.ToLower() == "exit")
                        {
                            break;
                        }

                        try
                        {
                            int number = int.Parse(input);

                            if (number >= 0 && number <= 9)
                            {
                                Console.WriteLine(digits[number]);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Ошибка! Число должно быть от 0 до 9.");

                                Thread.Sleep(3000);

                                Console.ResetColor();
                                Console.Clear();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Исключение! Вы ввели не число.");
                        }
                    }
                }
            }
        }
    }
}