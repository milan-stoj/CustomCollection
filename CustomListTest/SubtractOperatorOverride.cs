using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class SubtractOperatorOverride
    {
        [TestMethod]
        public void SubtractOperator_SubtractTwoLists_NewListMatchesSubtractedValues()
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

            int expectedIndexZero = -1;
            int expectedIndexOne = -1;
            int expectedIndexTwo = -1;
            int actualIndexZero;
            int actualIndexOne;
            int actualIndexTwo;

            //Act
            LiteList<int> newList = listOne - listTwo;
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
