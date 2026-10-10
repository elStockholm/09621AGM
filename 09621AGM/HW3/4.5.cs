using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _45
    {
        static void Main4(string[] args)
        {
            //Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента 
            //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            //результату.Вывести на экран сколько кукол в “сумке”.

            string[] items = { "Hello Kitty", "Car", "Barbie doll", "Ball", "Hello Kitty", "Barbie doll", "Teddy bear" };

            int count = 0;

            foreach (string item in items)
            {
                if (item == "Hello Kitty" || item == "Barbie doll")
                {
                    count++;
                }
            }

            Console.WriteLine($"Кукол в сумке: {count}");
        }
    }
}
