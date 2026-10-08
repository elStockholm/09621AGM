using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _41
    {
        static void Main4(string[] args)
        {
            //Дана последовательность из 10 чисел. Определить, является ли эта последовательность 
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break. 

            int[] numbers = { 2, 4, 6, 8, 9, 10, 12, 14, 16, 18 };
            bool a = true;
            int ind = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    a = false;
                    ind = i;
                    break;
                }
            }

            if (a)
            {
                Console.WriteLine("Uporyadaachena");
            }
            else
            {
                Console.WriteLine("Ne uporadachena");
            }
        }
    }
}
