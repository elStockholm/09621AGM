using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _71
    {
        //Создать List на 64 элемента, скачать из интернета 32 пары картинок (любых). В List должно содержаться по 2 одинаковых картинки.
        //Необходимо перемешать List с картинками. Вывести в консоль перемешанные номера (изначальный List и полученный List). Перемешать любым способом.
        public static void Main7(string[] args)
        {
            var image = new List<int>(64);
            for (int i = 1; i <= 32; i++)
            {
                image.Add(i);
                image.Add(i);
            }

            Console.WriteLine("Всего элементов: " + image.Count);

            Console.WriteLine("До перетасовки:");
            PrintList(image);

            Shuffle(image);

            Console.WriteLine("После перетасовки:");
            PrintList(image);
        }


        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }


        public static void Shuffle(List<int> im)
        {
            Random rnd = new Random();
            for (int i = 0; i < im.Count; i++)
            {
                int j = rnd.Next(i + 1);
                int temp = im[i];
                im[i] = im[j];
                im[j] = temp;
            }
        }
    }
}