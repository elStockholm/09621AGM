using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _6
    {
        //Написать программу для упражнения 6.3, использовав класс Dictionary<TKey, TValue>.
        //В качестве ключей выбрать строки – названия месяцев, а в качестве значений – массив значений температур по дням.
        static void Main6(string[] args)
        {
            string[] monthNames = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
            
            Dictionary<string, int[]> temperatureDict = new Dictionary<string, int[]>();
            Random rand = new Random();
            
            foreach (var month in monthNames)
            {
                int[] temps = new int[30];
                for (int j = 0; j < 30; j++)
                {
                    temps[j] = rand.Next(-40, 40);
                }
                temperatureDict[month] = temps;
            }
            
            Dictionary<string, double> avgTempsDict = new Dictionary<string, double>();

            Console.WriteLine("Средняя температура по месяцам:");
            foreach (var pair in temperatureDict)
            {
                double sum = 0;
                foreach (var temp in pair.Value)
                {
                    sum += temp;
                }
                double avg = sum / pair.Value.Length;
                avgTempsDict[pair.Key] = avg;

                Console.WriteLine($"{pair.Key}: {avg:F1}°C");
            }
            var sortedTemps = avgTempsDict.OrderBy(pair => pair.Value);

            Console.WriteLine("\nОтсортированный список по возрастанию средней температуры:");
            foreach (var pair in sortedTemps)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value:F1}°C");
            }
        }
    }
}
