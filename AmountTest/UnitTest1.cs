using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract1test;
using System;
using pract1test;

namespace PasswordTests
{
    [TestClass]

    public class TestStart
    {
        private int good = 0;

        [TestMethod]
        public void TestMethod0()
        {
            // Arrange
            string password = "A1tr4!df11";

            // Act
            Password pass = new Password(password);

            // Assert
            good++;
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string password = "A1tr4!df11";
            int expected = 10;

            // Act
            Password pass = new Password(password);
            int actualLength = pass.GetLength();
            bool isValid = pass.Length(expected);

            // Assert
            Assert.AreEqual(expected, actualLength);

            if (actualLength == expected)
            {
                good++;
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string password = "A1tr4!df11";

            // Act
            Password pass = new Password(password);
            bool hasSpecialCharacter = pass.Special();

            // Assert
            Assert.IsTrue(hasSpecialCharacter);

            if (hasSpecialCharacter == true)
            {
                good++;
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string password = "A1tr4!df11";

            // Act
            Password pass = new Password(password);
            bool hasNumbers = pass.Numbers();

            // Assert
            Assert.IsTrue(hasNumbers);

            if (hasNumbers = true)
            {
                good++;
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string password = "A1tr4!df11";
            //Act
            Password pass = new Password(password);
            bool hasSmallWords = pass.SmallWords();
            //Assert
            Assert.IsTrue(hasSmallWords);

            if (hasSmallWords = true)
            {
                good++;
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string password = "A1tr4!df11";
            //Act
            Password pass = new Password(password);
            bool hasBigWords = pass.BigWords();
            //Assert
            Assert.IsTrue(hasBigWords);

            if (hasBigWords = true)
            {
                good++;
            }
        }

        public int Goodkolvo()
        {
            return good;
        }
    }
}