using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _09621AGM.HW4
{
    internal class _73
    {
        //Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры в виде символа #.
        //Если число больше 9 или меньше 0, то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке.
        //Если пользователь ввёл не цифру, то программа должна выпасть в исключение.
        //Программа завершает работу, если пользователь введёт слово: exit или закрыть (оба варианта должны сработать) - консоль закроется.

        static void Main7(string[] args)
        {
            string[] arts = {
            // 0
            " ### \n#   #\n#   #\n#   #\n ### ",
            // 1
            "  #  \n ##  \n  #  \n  #  \n ### ",
            // 2
            " ### \n    #\n ### \n#    \n ### ",
            // 3
            " ### \n    #\n ### \n    #\n ### ",
            // 4
            "#   #\n#   #\n ####\n    #\n    # ",
            // 5
            " ####\n#    \n ### \n    #\n #### ",
            // 6
            " ### \n#    \n ####\n#   #\n ### ",
            // 7
            " ####\n    #\n   # \n  #  \n #   ",
            // 8
            " ### \n#   #\n ### \n#   #\n ### ",
            // 9
            " ### \n#   #\n ####\n    #\n ### "
        };
            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    string input = Console.ReadLine();

                    if (input.Equals("exit") || input.Equals("закрыть"))
                    {
                        break;
                    }

                    int number = int.Parse(input);

                    if (number >= 0 && number <= 9)
                    {
                        Console.WriteLine(arts[number]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Ошибка!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("Цифра вводить делай а не буква");
                }
            }
        }
    }
}