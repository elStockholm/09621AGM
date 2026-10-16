using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _5
    {
        //Написать метод, который вычисляет НОД двух натуральных чисел (алгоритм Евклида).
        //Написать метод с тем же именем, который вычисляет НОД трех натуральных чисел.

        public static int Gcd(int a, int b)
        {
            if (a < b)
            {
                (a, b) = (b, a);
            }

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int Gcd(int a, int b, int c)
        {
            int r = Gcd(a, b);
            if (r < c)
            {
                (r, c) = (c, r);
            }
            return Gcd(Gcd(a, b), c);
        }

        static void Main5(string[] args)
        {
            Console.WriteLine("Сколько чисел для вычисление НОД (2 или 3)");
            int num = int.Parse(Console.ReadLine());
            if (num == 2)
            {
                Console.WriteLine("Введите первое число");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int y = int.Parse(Console.ReadLine());

                int result = Gcd(x, y);
                Console.WriteLine($"НОД этих двух чисел равен {result}");
            }
            if (num == 3)
            {
                Console.WriteLine("Введите первое число");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int z = int.Parse(Console.ReadLine());

                int result = Gcd(x, y, z);
                Console.WriteLine($"НОД этих трех чисел равен {result}");
            }
        }
    }
}