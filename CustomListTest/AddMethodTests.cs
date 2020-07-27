using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddOneInt_CountIsOne()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 1;
            int actual;

            //Act
            list.Add(5);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddMethod_AddFiveItems_ItemsAtIndexMatchOrderAdded()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
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
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

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
        public void AddMethod_AddOneIntToEmpty_AddedItemInZeroIndex()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 5;
            int actual;

            //Act
            list.Add(5);
            actual = list[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_Add4Items_CapacityDoubles()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 8;
            int actual;

            //Act
            for (int i = 0; i < 4; i++)
            { 
                list.Add(i); 
            }
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_Add8Items_CapacityDoubles()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 16;
            int actual;

            //Act
            for (int i = 0; i < 8; i++) { list.Add(i); }
            actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_Add8Items_CountRefelctsAdded()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            int expected = 8;
            int actual;

            //Act
            for (int i = 0; i < 8; i++) { list.Add(i); }
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Different data types ... 
        // 
    }
}
