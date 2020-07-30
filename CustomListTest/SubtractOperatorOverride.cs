using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class SubtractOperatorOverride
    {
        [TestMethod]
        public void SubtractOperator_SubtractTwoLists_ZeroOrNegativeValuesOmitted()
        {
            //Arrange
            LiteList<int> listOne = new LiteList<int>();
            listOne.Add(1);
            listOne.Add(5);
            listOne.Add(7);

            LiteList<int> listTwo = new LiteList<int>();
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);

            int expectedIndexZero = 1;
            int expectedIndexOne = 1;
            int expectedIndexTwo = default;
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
        
        [TestMethod]
        public void SubtractOperator_SubtractTwoLists_NewListMatchesExpected()
        {
            //Arrange
            LiteList<int> listOne = new LiteList<int>();
            listOne.Add(6);
            listOne.Add(3);
            listOne.Add(2);

            LiteList<int> listTwo = new LiteList<int>();
            listTwo.Add(2);
            listTwo.Add(1);
            listTwo.Add(1);

            int expectedIndexZero = 4;
            int expectedIndexOne = 2;
            int expectedIndexTwo = 1;
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
