using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveTargetItem_ItemMissingFromIndex()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int expected = 0;
            int actual;

            //Act
            list.Remove(1);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);



        }
    }
}
