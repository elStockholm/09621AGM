using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _3
    {
        //Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре.
        //Если метод отработал успешно, то вернуть значение true; если в процессе вычисления возникло переполнение, то вернуть значение false.
        //Для отслеживания переполнения значения использовать блок checked.

        public static bool Factorial(int n, out long result)
        {
            result = 1;

            if (n < 0) return false;
            if (n == 0 || n == 1) return true;

            try
            {
                checked
                {
                    long tempResult = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        tempResult *= i;
                    }
                    result = tempResult;
                    return true;
                }
            }
            catch (OverflowException)
            {
                result = 0;
                return false;
            }
        }

        static void Main3(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (Factorial(num, out long result))
            {
                Console.WriteLine($"Факториал числа {num} равен {result}");
            }
            else
            {
                Console.WriteLine($"Ошибка: произошло переполнение при вычислении факториала числа {num}");
            }
        }
    }
}
