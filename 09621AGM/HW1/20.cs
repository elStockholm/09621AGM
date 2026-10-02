using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _20
    {
        static void Main20(string[] args)
        {
            // Вычислить контрольную цифру штрихкода(EAN13).  
            //a. 12 цифр определяются случайным образом. 
            //b. 12 цифр вводит пользователь
            int[] d = { 4, 0, 0, 6, 3, 8, 1, 1, 2, 9, 3, 5 };
            int sum = 0;
            for (int i = 0; i < d.Length; i++)
            {
                sum += d[i] * (i % 2 == 0 ? 1 : 3);
            }
            int chek = (10 - (sum % 10)) % 10;
            Console.WriteLine($"Контрольная цифра: {chek}");
        }
    }
}
