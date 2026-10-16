using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _1
    {
        //Написать метод, возвращающий наибольшее из двух чисел. Входные параметры метода – два целых числа. Протестировать метод.

        static int MaxNum(int a, int b)
        {
            return Math.Max(a, b);
        }
        static void Main1(string[] args)
        {
            int test1 = MaxNum(1, 2);
            int test2 = MaxNum(14, 67);
            int test3 = MaxNum(33, 42);

            Console.WriteLine($"Максимум из 1 и 2: {test1}");
            Console.WriteLine($"Максимум из 14 и 67: {test2}");
            Console.WriteLine($"Максимум из 33 и 42: {test3}");

            return;
        }
    }
}
