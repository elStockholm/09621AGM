using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW7
{
    internal class _4
    {
        //Реализовать метод, который проверяет реализует ли входной параметр метода интерфейс System.IFormattable. Использовать оператор is и as.
        //(Интерфейс IFormattable обеспечивает функциональные возможности форматирования значения объекта в строковое представление.)

        static bool IFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable formattable = obj as IFormattable;
                if (formattable != null)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main4(string[] args)
        {
            int number = 42;
            string text = "Привет";
            bool pravda = true;

            Console.WriteLine($"int: {IFormattable(number)}");
            Console.WriteLine($"string: {IFormattable(text)}");
            Console.WriteLine($"bool: {IFormattable(pravda)}");
        }
    }
}
