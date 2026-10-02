using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _17
    {
        static void Main17(string[] args)
        {
            //Дано натуральное число n (n > 999). Найти: 
            //а) число сотен в нем;
            //б) число тысяч в нем. 

            int num =int.Parse(Console.ReadLine());

            int sot = (num / 100) % 10;
            int tish = num / 1000;

            Console.WriteLine($"Количество сотен: {sot} \nКоличество тысяч: {tish}");
        }
    }
}
