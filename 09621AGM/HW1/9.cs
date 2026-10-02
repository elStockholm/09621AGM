using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _9
    {
        static void Main9(string[] args)
        {
            //Составить программу вывода на экран числа, вводимого с клавиатуры. 
            //Вводимому числу должно предшествовать сообщение «Вы ввели число».
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {a}");
        }
    }
}
