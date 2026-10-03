using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW2
{
    internal class _2
    {
        static void Main2(string[] args)
        {
            //Напишите программу, в которой принимаются данные пользователя в виде имени, 
            //города, возраста и PIN - кода.Далее сохраните все значение в соответствующей
            //переменной, а затем распечатайте всю информацию в правильном формате.
            Console.WriteLine("Напишите ваще имя");
            string name = Console.ReadLine();
            Console.WriteLine("Напишите ваш город");
            string city = Console.ReadLine();
            Console.WriteLine("Напишите ваш возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите ваш PIN-код");
            int pin = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"{name} \n{city}\n{age}\n{pin}");
        }
    }
}
