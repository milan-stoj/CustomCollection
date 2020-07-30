using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToString_ConvertListOfIntsToString_ItemsAreOfTypeString()
        {
            //Arrange
            LiteList<int> list = new LiteList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(6);
            bool expected = true;
            bool actual;

            //Act
            var x = list.ToString();
            actual = x is string;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertListOfDoublesToString_ItemsAreOfTypeString()
        {
            //Arrange
            LiteList<double> list = new LiteList<double>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(6);
            bool expected = true;
            bool actual;

            //Act
            var x = list.ToString();
            actual = x is string;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
