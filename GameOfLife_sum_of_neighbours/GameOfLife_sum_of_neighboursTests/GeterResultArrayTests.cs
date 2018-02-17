using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife_sum_of_neighbours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife_sum_of_neighbours.Tests
{
    [TestClass()]
    public class GeterResultArrayTests
    {
        [TestMethod()]
        public void SumOfNeighboursTest()
        {
            int[,] inputMatrix = { {0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 1 }, { 0, 1, 1, 1 } };

            int[,] expectedMatrix = { { 0, 0, 0, 0 }, { 0, 0, 1, 1 }, { 0, 1, 0, 1}, { 0, 1, 0, 1 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.GetLifeMatrix(inputMatrix));
        }

        [TestMethod]
        public void GetArrayOfNeighboursTest()
        {
            int[,] inputMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 1, 1 }, { 0, 1, 1, 1 } };

            int[,] expectedMatrix = { { 0, 0, 0, 0 }, { 0, 0, 1, 1 }, { 0, 1, 0, 1 }, { 0, 1, 0, 1 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.GetArrayOfNeighbours(4,4,inputMatrix));
        }

        [TestMethod]
        public void CheckIfLifeTest_4Nieghbours()
        {
            int[,] inputMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int[,] expectedMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.CheckIfLife(inputMatrix,0, 0, 4));
        }

        [TestMethod]
        public void CheckIfLifeTest_2Nieghbours()
        {
            int[,] inputMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int[,] expectedMatrix = { { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.CheckIfLife(inputMatrix, 0, 0, 2));
        }

        [TestMethod]
        public void CheckIfLifeTest_3Nieghbours()
        {
            int[,] inputMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int[,] expectedMatrix = { { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.CheckIfLife(inputMatrix, 0, 0, 3));
        }

        [TestMethod]
        public void CheckIfLifeTest_0Nieghbours()
        {
            int[,] inputMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int[,] expectedMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.CheckIfLife(inputMatrix, 0, 0, 0));
        }

        [TestMethod]
        public void CheckIfLifeTest_1Nieghbours()
        {
            int[,] inputMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            int[,] expectedMatrix = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

            CollectionAssert.AreEqual(expectedMatrix, GeterResultArray.CheckIfLife(inputMatrix, 0, 0, 1));
        }

    }
}