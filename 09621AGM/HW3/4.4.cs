using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _44
    {
        enum DaysOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }

        static void Main4(string[] args)
        {
            //Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, 
            //...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
            //Использовать enum. 

            Console.Write("Введите номер дня недели от 1 до 7: ");

            try
            {
                DaysOfWeek day = (DaysOfWeek)int.Parse(Console.ReadLine());

                Console.WriteLine($"День недели: {day}");
            }
            catch (Exception)
            {
                Console.WriteLine("Dведите целое число от 1 до 7.");
            }
        }
    }
}
