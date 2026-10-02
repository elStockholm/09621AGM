using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _8
    {
        static void Main8(string[] args)
        {
            //Программа просит пользователя ввести 2 числовые переменные. А после она 
            //меняет их местами и выводит результат на экран.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine($"{a}, {b}");
        }
    }
}
