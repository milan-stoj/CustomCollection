using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddOneInt_CountIs1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            list.Add(5);
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void AddMethod_AddOneInt_5IsInZeroIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
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
            CustomList<int> list = new CustomList<int>();
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
            CustomList<int> list = new CustomList<int>();
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
            CustomList<int> list = new CustomList<int>();
            int expected = 8;
            int actual;

            //Act
            for (int i = 0; i < 8; i++) { list.Add(i); }
            actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
