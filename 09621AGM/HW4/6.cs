using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _6
    {
        //Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
        //13... Для таких чисел верно соотношение Fk = Fk - 1 + Fk - 2.
        public static int Fibonachi(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main6(string[] args)
        {
            Console.WriteLine("Введите целое значение n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число n = {n} в ряде Фибоначи равно {Fibonachi(n)}");
        }
    }
}
