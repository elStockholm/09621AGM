using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW2
{
    internal class _3
    {
        static void Main3(string[] args)
        {
            //Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на 
            //строчные.
            Console.WriteLine("Введите строку:");
            string sentance = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (char c in sentance)
            {
                if (char.IsUpper(c))
                {
                    result.Append(char.ToLower(c));
                }
                else if (char.IsLower(c))
                {
                    result.Append(char.ToUpper(c));
                }
                else
                {
                    result.Append(c);
                }
            }

            Console.WriteLine($"Результат: {result.ToString()}");

        }
    }
}
