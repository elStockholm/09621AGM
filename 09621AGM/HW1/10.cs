using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _10
    {
        static void Main10(string[] args)
        {
            //Найти корни квадратного уравнения(коэффициента задаются пользователем с 
            //клавиатуры)
            Console.WriteLine("Введите коэфициент a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфициент b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэфициент c");
            int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Не квадратное уравнение");
                return;
            }
            double d = (b * b) - (4 * a * c);
            double discr = Math.Sqrt(d);
            if (discr > 0)
            {
                double x1 = ((-b + discr) / (2 * a));
                double x2 = ((-b - discr) / (2 * a));
                Console.WriteLine($"{x1}, {x2}");
                return;
            }
            if (discr == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine(x);
                return;
            }
            else
            {
                Console.WriteLine("Нет вещественных корней");
                return;
            }
        }
    }
}
