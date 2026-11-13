using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW7
{
    internal class _3
    {
        //Написать программу, которая спрашивает у пользователя имя файла.
        //Если такого файла не существует, то программа выдает пользователю сообщение и заканчивает работу,
        //иначе в выходной файл записывается содержимое исходного файла, но заглавными буквами.
        static void Main3(string[] args)
        {
            Console.Write("Введите имя исходного файла: ");
            string inputFileName = Console.ReadLine();

            if (!File.Exists(inputFileName))
            {
                Console.WriteLine("Ошибка: указанный файл не существует.");
                return;
            }

            string outputFileName = "new_" + Path.GetFileName(inputFileName);

            string content = File.ReadAllText(inputFileName);
            string upperContent = content.ToUpper();

            File.WriteAllText(outputFileName, upperContent);

            Console.WriteLine($"Готово. Результат записан в файл: {outputFileName}");
        }
    }
}
