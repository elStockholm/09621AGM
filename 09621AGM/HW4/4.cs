using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _4
    {
        //Написать рекурсивный метод вычисления факториала числа.

        public static long Factorial2(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return checked(n * Factorial2(n - 1));
        }

        static void Main4(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            long result = Factorial2(num);
            Console.WriteLine($"Факториал числа {num} равен {result}");
        }
    }
}
