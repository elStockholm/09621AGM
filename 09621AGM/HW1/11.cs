using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _11
    {
        static void Main11(string[] args)
        {
            //Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее 
            //геометрическое.
            Console.WriteLine("Введите первое число");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int second = int.Parse(Console.ReadLine());

            int arif = (first + second) / 2;
            double geom = Math.Sqrt((first * second));

            Console.WriteLine($"Среднееарифметическое этих чисел равно: {arif}");
            Console.WriteLine($"Среднее геометрическое этих чисел равно: {geom}");
        }
    }
}
