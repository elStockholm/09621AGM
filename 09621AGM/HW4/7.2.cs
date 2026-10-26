using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _72
    {
        //Написать метод, где в качества аргумента будет передан массив (ключевое слово params).
        //Вывести сумму элементов массива (вернуть).
        //Вывести (ref) произведение массива. Вывести (out) среднее арифметическое в массиве.
        static int Method(ref long product, out double average, params int[] numbers)
        {
            int sum = 0;
            product = 1;

            foreach (int i in numbers)
            {
                sum += i;
                product *= i;
            }
            average = (double)sum / numbers.Length;
            return sum;
        }
        static void Main7(string[] args)
        {
            long product = 1;
            int sum = Method(ref product, out double average, 1, 3, 5, 10);
            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(average);
        }
    }
}
