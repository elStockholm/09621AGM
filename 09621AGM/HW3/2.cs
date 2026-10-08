
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _2
    {
        static void Main2(string[] args)
        {
            //Написать программу, которая читает с экрана число от 1 до 365(номер дня
            //в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            //февраля(високосный год не учитывать).
            //Добавить к задаче из предыдущего упражнения проверку числа введенного 
            //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
            //исключение, и выдавать на экран сообщение.

            string[] months = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num >= 1 && num <= 365)
                {
                    break;
                }
                Console.WriteLine("Error");
                break;
            }

            for (int i = 0; i < days.Length; i++)
            {
                if (num <= days[i])
                {
                    Console.WriteLine(num);
                    Console.WriteLine(months[i]);
                    return;
                }
                num = num - days[i];
            }
        }
    }
}
