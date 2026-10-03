using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW2
{
    internal class _6
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] names = { "Иван Иванов", "Петр Петров", "Алексей Сидоров", "Анна Смирнова", "Дмитрий Кузнецов" };
            double[] volumes = { 2.5, 12.0, 1.5, 5.0, 6.0 };
            double[] alcoholPercent = { 40.0, 5.0, 12.0, 0.0, 6.0 };

            double totalLiquid = 0;
            double totalAlcohol = 0;

            for (int i = 0; i < names.Length; i++)
            {
                totalLiquid += volumes[i];
                totalAlcohol += volumes[i] * (alcoholPercent[i] / 100.0);
            }

            Console.WriteLine("=== ОБЩИЕ ПОКАЗАТЕЛИ ===");
            Console.WriteLine($"Общий объем жидкости: {totalLiquid:F2} л");
            Console.WriteLine($"Общий чистый алкоголь: {totalAlcohol:F2} л\n");

            Console.WriteLine("=== СТАТИСТИКА ПО СТУДЕНТАМ ===");
            for (int i = 0; i < names.Length; i++)
            {
                double studentAlcohol = volumes[i] * (alcoholPercent[i] / 100.0);

                double percentLiquid = (volumes[i] / totalLiquid) * 100;
                double percentAlcohol = totalAlcohol > 0 ? (studentAlcohol / totalAlcohol) * 100 : 0;

                Console.WriteLine($"Студент: {names[i]}");
                Console.WriteLine($"  Выпил жидкости: {volumes[i]} л ({percentLiquid:F1}%)");
                Console.WriteLine($"  Выпил чистого алкоголя: {studentAlcohol:F2} л ({percentAlcohol:F1}%)");
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}