using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _7
    {
        static void Main7(string[] args)
        {
            //Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май" 
            //(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так
            //(исп.спец.символы):  
            //Мир Труд Май
            //Затем так: 
            //Мир
            //  Труд
            //      Май
            string first = "Мир ";
            string second = "Труд ";
            string third = "Май ";
            Console.Write(first);
            Console.Write(second);
            Console.Write(third);
            Console.Write("\n" + first + "\n\t" + second + "\n\t\t" + third);
        }
    }
}
