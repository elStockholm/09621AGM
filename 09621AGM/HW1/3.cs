using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _3
    {
        static void Main3(string[] args)
        {
            //Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(rand.Next(1, 1000));
            }
        }
    }
}
