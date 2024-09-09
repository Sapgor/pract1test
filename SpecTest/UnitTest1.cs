using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract1test;
using System;

namespace SpecTest
{
    [TestClass]
    public class spec
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string password = "A1tr4!df11";

            // Act
            Password pass = new Password(password);
            bool hasSpecialCharacter = pass.Special();

            // Assert
            Assert.IsTrue(hasSpecialCharacter);
            }
        }
    }
