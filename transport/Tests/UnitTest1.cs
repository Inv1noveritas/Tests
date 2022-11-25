using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Zeroes;
using Main;

namespace Tests
{
    

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void best_zeroes_positiveTest()
        {
            List<int> zeroesTest = new List<int>();
            List<int> zeroesOld = new List<int>();

            int n = 3;
            int[,] priceTest = new int[n, n];

            priceTest[0, 0] = int.MaxValue;
            priceTest[1, 1] = int.MaxValue;
            priceTest[2, 2] = int.MaxValue;

            priceTest[0, 1] = 1;
            priceTest[0, 2] = 2;

            priceTest[1, 0] = 1;
            priceTest[1, 2] = 3;

            priceTest[2, 0] = 2;
            priceTest[2, 1] = 3;

            int i = 5;
            int j = Metod.sum_place(priceTest, 0, 1);

            Assert.AreEqual(i, j);
        }

        [TestMethod]
        public void best_zeroes_negativeTest()
        {
            List<int> zeroesTest = new List<int>();
            List<int> zeroesOld = new List<int>();

            int n = 3;
            int[,] priceTest = new int[n, n];

            priceTest[0, 0] = int.MaxValue;
            priceTest[1, 1] = int.MaxValue;
            priceTest[2, 2] = int.MaxValue;

            priceTest[0, 1] = 1;
            priceTest[0, 2] = 2;

            priceTest[1, 0] = 1;
            priceTest[1, 2] = 3;

            priceTest[2, 0] = 2;
            priceTest[2, 1] = 3;

            int i = 1;
            int j = Metod.sum_place(priceTest, 0, 1);

            Assert.AreNotEqual(i, j);
        }

        [TestMethod]
        public void GetCost_positiveTest()
        {

            Dictionary<int, int> resultTest = new Dictionary<int, int>()
            {
                [0] = 1,
                [1] = 2,
                [2] = 0
            };

            int n = 3;
            int[,] priceTest = new int[n, n];

            priceTest[0, 0] = int.MaxValue;
            priceTest[1, 1] = int.MaxValue;
            priceTest[2, 2] = int.MaxValue;

            priceTest[0, 1] = 1;
            priceTest[0, 2] = 2;

            priceTest[1, 0] = 1;
            priceTest[1, 2] = 3;

            priceTest[2, 0] = 2;
            priceTest[2, 1] = 3;

            int test = 6;
            int result = Program2.GetCost(0, resultTest, priceTest);
            //resultTest[0] = 1;
            int t = result;

            bool f = (test == result);

            Assert.IsTrue(f);
        }

        [TestMethod]
        public void GetCost_negativeTest()
        {

            Dictionary<int, int> resultTest = new Dictionary<int, int>()
            {
                [0] = 1,
                [1] = 2,
                [2] = 0
            };

            int n = 3;
            int[,] priceTest = new int[n, n];

            priceTest[0, 0] = int.MaxValue;
            priceTest[1, 1] = int.MaxValue;
            priceTest[2, 2] = int.MaxValue;

            priceTest[0, 1] = 1;
            priceTest[0, 2] = 2;

            priceTest[1, 0] = 1;
            priceTest[1, 2] = 3;

            priceTest[2, 0] = 2;
            priceTest[2, 1] = 3;

            int test = 61;
            int result = Program2.GetCost(0, resultTest, priceTest);
            //resultTest[0] = 1;
            int t = result;
            Assert.AreNotEqual(test, result);
        }
    }
}
