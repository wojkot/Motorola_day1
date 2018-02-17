using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_sum_of_neighbours
{
    public class GeterResultArray
    {
        public static int[,] GetLifeMatrix(int[,] baseMatrix)
        {
            int xSize = baseMatrix.GetLength(0);
            int ySize = baseMatrix.GetLength(1);

            return GetArrayOfNeighbours(xSize, ySize, baseMatrix);
        }


        public static int [,] GetArrayOfNeighbours(int xSize, int ySize, int [,] baseMatrix)
        {
            int[,] resultMatrix = new int[xSize, ySize];

            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {

                    int count = 0;

                    if ((i + 1) < xSize && baseMatrix[i + 1, j] == 1)
                    {
                        count++;
                    }

                    if ((i - 1) >= 0 && baseMatrix[i - 1, j] == 1)
                    {
                        count++;
                    }

                    if ((j + 1) < ySize && baseMatrix[i, j + 1] == 1)
                    {
                        count++;
                    }

                    if ((j - 1) >= 0 && baseMatrix[i, j - 1] == 1)
                    {
                        count++;
                    }

                    if ((i + 1) < xSize && (j + 1) < ySize && baseMatrix[i + 1, j + 1] == 1)
                    {
                        count++;
                    }

                    if ((i + 1) < xSize && (j - 1) >= 0 && baseMatrix[i + 1, j - 1] == 1)
                    {
                        count++;
                    }

                    if ((i - 1) >= 0 && (j + 1) < ySize && baseMatrix[i - 1, j + 1] == 1)
                    {
                        count++;
                    }

                    if ((j - 1) >= 0 && (i - 1) >= 0 && baseMatrix[i - 1, j - 1] == 1)
                    {
                        count++;
                    }

                    resultMatrix = CheckIfLife(resultMatrix, i, j, count);
                }
            }

            return resultMatrix;
        }
        public static int[,] CheckIfLife(int[,] resultMatrix, int i, int j, int count)
        {
            if (count > 3 || count <= 1)
            {
                resultMatrix[i, j] = 0;
            }
            else
            {
                resultMatrix[i, j] = 1;
            }

            return resultMatrix;
        }

    }
}
