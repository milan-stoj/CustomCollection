using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ZipMethodTests
    {
        [TestMethod]
        public void ZipMethod_ZipTwoLists_IndexesMatchExpected()
        {
            //Arrange
            LiteList<int> oddList = new LiteList<int>();
            int oddListIndexZero = 1;
            int oddListIndexOne = 3;
            int oddListIndexTwo = 5;
            oddList.Add(oddListIndexZero); oddList.Add(oddListIndexOne); oddList.Add(oddListIndexTwo);

            LiteList<int> evenList = new LiteList<int>();
            int evenListIndexZero = 2;
            int evenListIndexOne = 4;
            int evenListIndexTwo = 6;
            evenList.Add(evenListIndexZero); evenList.Add(evenListIndexOne); evenList.Add(evenListIndexTwo);

            int expectedIndexZero = oddListIndexZero;   
            int expectedIndexOne = evenListIndexZero;
            int expectedIndexTwo = oddListIndexOne;     
            int expectedIndexThree = evenListIndexOne;
            int expectedIndexFour = oddListIndexTwo;    
            int expectedIndexFive = evenListIndexTwo;
            int actualIndexZero;
            int actualIndexOne;
            int actualIndexTwo;
            int actualIndexThree;
            int actualIndexFour;
            int actualIndexFive;
            
            //Act
            LiteList<int> zipper = oddList.Zip(evenList);
            actualIndexZero = zipper[0];
            actualIndexOne = zipper[1];
            actualIndexTwo = zipper[2];
            actualIndexThree = zipper[3];
            actualIndexFour = zipper[4];
            actualIndexFive = zipper[5];

            //Assert
            Assert.AreEqual(expectedIndexZero, actualIndexZero);
            Assert.AreEqual(expectedIndexOne, actualIndexOne);
            Assert.AreEqual(expectedIndexTwo, actualIndexTwo);
            Assert.AreEqual(expectedIndexThree, actualIndexThree);
            Assert.AreEqual(expectedIndexFour, actualIndexFour);
            Assert.AreEqual(expectedIndexFive, actualIndexFive);
        }
    }
}
