using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _2
    {
        //Написать метод, который меняет местами значения двух передаваемых параметров. Параметры передавать по ссылке. Протестировать метод.
        static void SwapNum(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main2(string[] args)
        {
            int test1 = 1;
            int test2 = 2;
            int test3 = 52;
            int test4 = 67;

            SwapNum(ref test1, ref test2);
            SwapNum(ref test3, ref test4);

            Console.WriteLine($"{test1} {test2}");
            Console.WriteLine($"{test3} {test4}");

            return;
        }
    }
}
