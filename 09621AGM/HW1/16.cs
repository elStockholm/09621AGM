using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _16
    {
        static void Main16(string[] args)
        {
            //Дано трехзначное число. В нем зачеркнули последнюю справа цифру и 
            //приписали ее в начале. Найти полученное число
            int num = int.Parse(Console.ReadLine());
            int res = (num % 10) * 100 + (num / 10);
            Console.WriteLine(res);
        }
    }
}
