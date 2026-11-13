using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW7
{
    internal class _2
    {
        //Реализовать метод, который в качестве входного параметра принимает строку string,
        //возвращает строку типа string, буквы в которой идут в обратном порядке.Протестировать метод.
        static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] reversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - 1 - i];
            }

            return new string(reversed);
        }
        static void Main2(string[] args)
        {
            string test1 = "Мама мыла раму";
            string test2 = "Новый год скоро";
            string test3 = "Дед мороз существует!";
            string test4 = "Кто такой С#";

            Console.WriteLine(ReverseString(test1));
            Console.WriteLine(ReverseString(test2));
            Console.WriteLine(ReverseString(test3));
            Console.WriteLine(ReverseString(test4));
        }
    }
}
