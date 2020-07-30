using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class SortMethodTests
    {
        [TestMethod]
        public void SortMethod_SortOneToFiveListInts_ItemsInCorrectOrder()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            list.Add(1);
            list.Add(5);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int expected1 = 1;
            int expected2 = 2;
            int expected3 = 3;
            int expected4 = 4;
            int expected5 = 5;
            int actual1;
            int actual2;
            int actual3;
            int actual4;
            int actual5;

            //Act
            list.Sort();
            actual1 = list[0];
            actual2 = list[1];
            actual3 = list[2];
            actual4 = list[3];
            actual5 = list[4];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);

        }

        [TestMethod]
        public void SortMethod_SortOneToFiveListDbls_ItemsInCorrectOrder()
        {
            //Arrange
            LiteList<double> list = new LiteList<double>();
            list.Add(1);
            list.Add(5);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            double expected1 = 1;
            double expected2 = 2;
            double expected3 = 3;
            double expected4 = 4;
            double expected5 = 5;
            double actual1;
            double actual2;
            double actual3;
            double actual4;
            double actual5;

            //Act
            list.Sort();
            actual1 = list[0];
            actual2 = list[1];
            actual3 = list[2];
            actual4 = list[3];
            actual5 = list[4];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);

        }
    }
}
