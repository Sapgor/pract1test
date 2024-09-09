using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract1test;
using System;

namespace NumbersTest
{
    [TestClass]
    public class Numbers
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string password = "A1tr4!df11";

            // Act
            Password pass = new Password(password);
            bool hasNumbers = pass.Numbers();

            // Assert
            Assert.IsTrue(hasNumbers);
        }
    }

}
