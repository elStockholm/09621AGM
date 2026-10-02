using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _12
    {
        static void Main12(string[] args)
        {
            // Известны координаты на плоскости двух точек. Составить программу 
            //вычисления расстояния между ними. 

            Console.WriteLine("Введите координаты первой точки по очереди");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки по очереди");
            int x2 = int.Parse(Console.ReadLine());
            int y2= int.Parse(Console.ReadLine());

            int a = x1 - x2;
            int b = y1 - y2;
            double rasst = Math.Sqrt(a * a + b * b);

            Console.WriteLine(rasst);
        }
    }
}
