
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Logic.Tests
{
    [TestFixture]
    public class AlgoServiceTests
    {
        [Test]
        public void DoubleSum_When_pass_collection_Then_get_sum()
        {
            //Arrage
            AlgoService doubleSumTest = new AlgoService();
            List<int> test = new List<int>() { 1, 2, 3, 4, 5 };
            int res = test.Sum<int>(i => i) * 2;
            //Act
            int checkRes = doubleSumTest.DoubleSum(test);
            //Aseert
            Assert.That(res, Is.EqualTo(checkRes));
        }
        [Test]
        public void MinValue_When_pass_colletcion_Then_get_min_value()
        {
            //Arrage
            AlgoService minValueTest = new AlgoService();
            List<int> test = new List<int>() { 1, 2, 3, 4, 5 };
            int mValue = 1;
            //Act
            int minValueResult = minValueTest.MinValue(test);
            //Assert
            Assert.That(mValue, Is.EqualTo(minValueResult));
        }

    }
}