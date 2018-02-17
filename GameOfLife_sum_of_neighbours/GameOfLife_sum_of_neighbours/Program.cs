using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_sum_of_neighbours
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + "row: ");
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your array:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] resultMatrix = GeterResultArray.GetLifeMatrix(matrix);

            Console.WriteLine("Result array:");

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
