using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_One_To_Seven()
        {
            //Arrange
            int n=2;
            int expected = 2;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorTest_NegativeInput()
        {
            //Arrange
            int n = -6;
            int expected = -9999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorTest_Greater_Than_Seven()
        {
            //Arrange
            int n = 9;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromTest_Correct_Input()
        {
            //Arrange
            int n = 97779;
            string expected = "Palindrom";

            //Act
            string actual = Algebra.Palindrom(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromTest_Wrong_Input()
        {
            //Arrange
            int n = 9719;
            string expected = "Not a Palindrom";

            //Act
            string actual = Algebra.Palindrom(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}