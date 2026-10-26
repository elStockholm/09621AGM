using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _2
    {
        //Написать программу, реализующую умножению двух матриц, заданных в виде двумерного массива.
        //В программе предусмотреть два метода: метод печати матрицы, метод умножения матриц (на вход две матрицы, возвращаемое значение – матрица).

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);
            
            if (cols1 != rows2)
            {
                Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй матрицы.");
                return null;
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        static void Main2(string[] args)
        {
            int[,] matrix1 = 
                {   { 1, 2, 3 },
                    { 4, 5, 6 }    };

            int[,] matrix2 =
                {   { 7, 8 },
                    { 9, 1 },
                    { 2, 3 }    };
            
            int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
            
            if (resultMatrix != null)
            {
                PrintMatrix(resultMatrix);
            }
        }
    }
}