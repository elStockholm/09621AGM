
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _1
    {
        static void Main1(string[] args)
        {
            //Написать программу, которая читает с экрана число от 1 до 365(номер дня
            //в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
            //февраля(високосный год не учитывать).

            string[] months = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());

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
