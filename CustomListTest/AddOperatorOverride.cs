using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class AddOperatorOverride
    {
        [TestMethod]
        public void AddOperator_AddTwoLists_NewListMatchesAddedValues()
        {
            //Arrange
            LiteList<int> listOne = new LiteList<int>();
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);

            LiteList<int> listTwo = new LiteList<int>();
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);

            int expectedIndexZero = 3;
            int expectedIndexOne = 7;
            int expectedIndexTwo = 11;
            int actualIndexZero;
            int actualIndexOne;
            int actualIndexTwo;

            //Act
            LiteList<int> newList = listOne + listTwo;
            actualIndexZero = newList[0];
            actualIndexOne = newList[1];
            actualIndexTwo = newList[2];

            //Assert
            Assert.AreEqual(expectedIndexZero, actualIndexZero);
            Assert.AreEqual(expectedIndexOne, actualIndexOne);
            Assert.AreEqual(expectedIndexTwo, actualIndexTwo);
        }
    }
}
