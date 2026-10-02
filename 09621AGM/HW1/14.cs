using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _14
    {
        static void Main14(string[] args)
        {
            // С начала суток прошло n секунд. Определить: 
            //а) сколько полных часов прошло с начала суток;
            //б) сколько полных минут прошло с начала очередного часа;
            //в) сколько полных секунд прошло с начала очередной минуты.

            int n = int.Parse(Console.ReadLine());

            int a = n / 3600;
            Console.WriteLine($"С начала суток прошло {a} часов");

            int b = ((n - (a * 3600)) / 60);
            Console.WriteLine($"С начала очередного часа прошло {b} минут");

            int c = (n - (a * 3600) - (b * 60));
            Console.WriteLine($"С начала очередной минуты прошло {c} секунд");
        }
    }
}
