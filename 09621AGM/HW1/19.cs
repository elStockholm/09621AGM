using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _19
    {
        static void Main19(string[] args)
        {
            //Воспроизвести разговор Гарри и дневника Тома Реддла.Пользователь
            //здоровается с консолью.Консоль спрашивает, как зовут пользователя.
            //Пользователь называет имя.Консоль пишет: привет, < имя пользователя >.После
            //этого пользователь спрашивает, знает ли консоль что-то о тайной комнате.
            //Консоль отвечает «Да». После этого пользователь спрашивает, может ли
            //рассказать.Консоль отвечает «Нет». Спустя 5 секунд консоль дополняет «но
            //могу показать». Консоль меняет цвет на любой случайный цвет.

            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine() ;
            Console.WriteLine("Нет");

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Могу показать");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }
    }
}
