using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _5
    {
        //Упражнение 6.2 выполнить с помощью коллекций LinkedList<LinkedList<T>>.
        static LinkedList<LinkedList<int>> MultiplyMatrices(LinkedList<LinkedList<int>> matrix1, LinkedList<LinkedList<int>> matrix2)
        {
            int rows1 = matrix1.Count;
            int cols1 = matrix1.First?.Value.Count ?? 0;
            int rows2 = matrix2.Count;
            int cols2 = matrix2.First?.Value.Count ?? 0;
            
            if (cols1 != rows2)
            {
                throw new ArgumentException("Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
            }

            LinkedList<LinkedList<int>> result = new LinkedList<LinkedList<int>>();

            for (int i = 0; i < rows1; i++)
            {
                LinkedList<int> resultRow = new LinkedList<int>();

                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        int val1 = matrix1.ElementAt(i).ElementAt(k);
                        int val2 = matrix2.ElementAt(k).ElementAt(j);
                        sum += val1 * val2;
                    }
                    resultRow.AddLast(sum);
                }
                result.AddLast(resultRow);
            }

            return result;
        }
        
        static void PrintMatrix(LinkedList<LinkedList<int>> matrix)
        {
            if (matrix == null) return;
            
            foreach (var row in matrix)
            {
                foreach (var val in row)
                {
                    Console.Write($"{val,4} ");
                }
                Console.WriteLine();
            }
        }

        static void Main5(string[] args)
        {
            LinkedList<LinkedList<int>> matrix1 = new LinkedList<LinkedList<int>>();
            matrix1.AddLast(new LinkedList<int>(new[] { 1, 2, 3 }));
            matrix1.AddLast(new LinkedList<int>(new[] { 4, 5, 6 }));
            
            LinkedList<LinkedList<int>> matrix2 = new LinkedList<LinkedList<int>>();
            matrix2.AddLast(new LinkedList<int>(new[] { 7, 8 }));
            matrix2.AddLast(new LinkedList<int>(new[] { 9, 1 }));
            matrix2.AddLast(new LinkedList<int>(new[] { 2, 3 }));

            try
            {
                LinkedList<LinkedList<int>> resultMatrix = MultiplyMatrices(matrix1, matrix2);
                Console.WriteLine("Результат умножения матриц:");
                PrintMatrix(resultMatrix);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}