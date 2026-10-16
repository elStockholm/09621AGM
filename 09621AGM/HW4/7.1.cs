using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _71
    {
        //Вывести на экран массив из 20 случайных чисел.
        //Ввести два числа из этого массива, которые нужно поменять местами.
        //Вывести на экран получившийся массив.

        static void Main7(string[] args)
        {
            int[] numbers = new int[20];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nВведите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());

            int i1 = Array.IndexOf(numbers, a);
            int i2 = Array.IndexOf(numbers, b);

            int temp = numbers[i1];
            numbers[i1] = numbers[i2];
            numbers[i2] = temp;

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
