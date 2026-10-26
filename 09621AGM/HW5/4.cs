using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _4
    {
        //Упражнение 6.1 выполнить с помощью коллекции List<T>.
        static void Count(List<char> chars)
        {
            int glasnie = 0;
            int soglasnie = 0;

            string glasnielList = "уеыаоэяию";
            string soglasnieList = "йцкнгшщзхъфвпрлджчсмтьб";

            foreach (char c in chars)
            {
                char lowerChar = char.ToLower(c);

                if (char.IsLetter(lowerChar))
                {
                    if (glasnielList.Contains(lowerChar))
                    {
                        glasnie++;
                    }
                    if (soglasnieList.Contains(lowerChar))
                    {
                        soglasnie++;
                    }
                }
            }

            Console.WriteLine($"Количество гласных: {glasnie}");
            Console.WriteLine($"Количество согласных: {soglasnie}");
        }

        static void Main4(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Ошибка: укажите путь к файлу как аргумент.");
                Console.WriteLine("Пример: myapp.exe data.txt");
                return;
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
                return;
            }

            try
            {
                string content = File.ReadAllText(filePath);
                List<char> charList = new List<char>(content);
                Count(charList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        } 
    }
}