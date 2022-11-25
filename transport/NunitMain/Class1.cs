using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Zeroes;
using Main;

namespace NunitMain
{
    [TestFixture]
    public class Class1
    {
        

        [Test]
        public void ZeroPositiveTest2()
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

            int result = Program2.GetCost(0, resultTest, priceTest);
            bool resultProv = Program2.prov(resultTest, result);

            Assert.AreEqual(false, resultProv);
        }

    }
}
