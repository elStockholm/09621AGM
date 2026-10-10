using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW3
{
    internal class _43
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на входе строку и производит выходные 
            //данные в соответствии со следующей таблицей:

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string result;

            if (input != null)
            {
                string normalizedInput = input.ToLower();

                switch (normalizedInput)
                {
                    case "jabroni":
                        result = "Patron Tequila";
                        break;
                    case "school counselor":
                        result = "Anything with Alcohol";
                        break;
                    case "programmer":
                        result = "Hipster Craft Beer";
                        break;
                    case "bike gang member":
                        result = "Moonshine";
                        break;
                    case "politician":
                        result = "Your tax dollars";
                        break;
                    case "rapper":
                        result = "Cristal";
                        break;
                    default:
                        result = "Beer";
                        break;
                }
            }
            else
            {
                result = "Beer";
            }

            Console.WriteLine(result);
        }
    }
}