using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW2
{
    internal class _4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Введите основную строку:");
            string str = Console.ReadLine();

            Console.WriteLine("Введите подстроку для поиска:");
            string subStr = Console.ReadLine();

            if (string.IsNullOrEmpty(subStr))
            {
                Console.WriteLine("Подстрока не может быть пустой");
                return;
            }

            int count = 0;
            int index = 0;

            while ((index = str.IndexOf(subStr, index)) != -1)
            {
                count++;
                index += subStr.Length;
            }

            Console.WriteLine($"Количество вхождений: {count}");
        }
    }
}
