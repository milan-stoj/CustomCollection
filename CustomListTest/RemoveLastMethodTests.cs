using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveLastMethodTests
    {
        [TestMethod]
        public void RemoveLastMethod_RemoveItem_CountDecrements()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 3;
            int actual;

            //Act
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(5); // Count = 4
            list.RemoveLast();
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveLastMethod_RemoveItem_LastItemChanges()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 3;
            int actual;

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4); // Last Item (Count - 1)
            list.RemoveLast();
            actual = list[list.Count-1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
