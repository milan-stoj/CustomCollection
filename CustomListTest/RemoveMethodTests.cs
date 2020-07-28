using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveTargetItem_ItemMissingFromList()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            bool expected = false;  // Expect list to not-contain int 1.
            bool actual = default;
            int target = 2;

            //Act
            list.Remove(target);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    actual = true;
                    break;
                }
            }
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveMethod_RemoveTargetItem_OneInstanceMissingFromList()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            int expected = 2;  // Expect list to contain two instances of one.
            int actual = default;

            //Act
            list.Remove(1);
            for (int i = 0; i <= list.Count; i++)
            {
                if (list[i] == 1)
                {
                    actual++;
                }
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void RemoveMethod_RemoveTargetItem_ItemsCondenseReplaceIndexes()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int target = 2;     // Target object to remove.
            int expected1 = 1; 
            int expected2 = 3;  
            int expected3 = 4;  
            int expected4 = 0;
            int actual1;
            int actual2;
            int actual3;
            int actual4;
            
            
            //Act
            list.Remove(target);
            actual1 = list[0];
            actual2 = list[1];
            actual3 = list[2];
            actual4 = list[3];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

    }
}
