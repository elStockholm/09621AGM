using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _6
    {
        static void Main6(string[] args)
        {
            //Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Введите высоту h");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнее основание a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите нижнее основание b");
            double b = double.Parse(Console.ReadLine());

            //Найдем боковую сторону трапеции c по теореме пифагора
            double katet = (b - a) / 2;
            double c = Math.Sqrt(katet * katet + h * h);

            //Найдем периметр
            double p = a + b + 2*c;
            Console.WriteLine(p);
        }
    }
}
