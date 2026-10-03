using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW2
{
    internal class _5
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Введите обычную цену бутылки (normPrice):");
            int normPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите скидку в Duty Free в процентах (salePrice):");
            int salePrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость отпуска (holidayPrice):");
            int holidayPrice = int.Parse(Console.ReadLine());

            int bottles = (holidayPrice * 100) / (normPrice * salePrice);

            Console.WriteLine($"Необходимо купить бутылок: {bottles}");
        }
    }
}
