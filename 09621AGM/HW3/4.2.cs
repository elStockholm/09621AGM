using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _42
    {
        static void Main4(string[] args)
        {
            //Игральным картам условно присвоены следующие порядковые номера в зависимости от 
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally.

            Console.Write("Введите номер карты от 6 до 14: ");

            try
            {
                int k = int.Parse(Console.ReadLine());

                string[] cards = { "шестерка", "семерка", "восьмерка", "девятка", "десятка", "валет", "дама", "король", "туз" };

                Console.WriteLine($"Достоинство карты: {cards[k-6]}");
            }
            catch (Exception)
            {
                Console.WriteLine("Введите целое число от 6 до 14.");
            }
            finally
            {
                Console.WriteLine("");
            }
        }
    }
}