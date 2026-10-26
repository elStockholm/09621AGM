using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _3
    {
        //Написать программу, вычисляющую среднюю температуру за год. Создать двумерный рандомный массив temperature[12,30], в котором будет храниться температура
        //для каждого дня месяца(предполагается, что в каждом месяце 30 дней). Сгенерировать значения температур случайным образом.Для каждого месяца распечатать среднюю температуру.
        //Для этого написать метод, который по массиву temperature[12, 30] для каждого месяца вычисляет среднюю температуру в нем, и в качестве результата возвращает массив средних температур.
        //Полученный массив средних температур отсортировать по возрастанию.

        static double[] GetAver(int[,] temperature)
        {
            int rows = temperature.GetLength(0);
            int cols = temperature.GetLength(1);
            double[] aver = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += temperature[i, j];
                }
                aver[i] = sum / cols;
            }
            return aver;
        }

        static void Main3(string[] args)
        {
            int[,] temperature = new int[12, 30];
            Random rand = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperature[i, j] = rand.Next(-40, 40);
                }
            }

            double[] avgTemps = GetAver(temperature);

            Console.WriteLine("Средняя температура по месяцам:");
            for (int i = 0; i < avgTemps.Length; i++)
            {
                Console.WriteLine($"Месяц {i + 1}: {avgTemps[i]}");
            }

            Array.Sort(avgTemps);

            Console.WriteLine("\nОтсортированный массив средних температур по возрастанию:");
            foreach (var temp in avgTemps)
            {
                Console.Write($"\n{temp:F1} ");
            }
        }
    }
}