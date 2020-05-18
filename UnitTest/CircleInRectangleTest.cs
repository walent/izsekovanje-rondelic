using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CircleInRectangleLib;

namespace UnitTest
{
    [TestClass]
    public class CircleInRectangleTest
    {

        [TestMethod]
        public void Calculation_With_ValidInputData()
        {
            // Arrange
            double width = 257;
            double lenght = 157;
            double radious = 1.784124116;
            double spaces = 1;
            int expectedNumber = 3327;
            double actualNumber = 0;
            CircleInRectangle cir = new CircleInRectangle();

            // Act
            actualNumber = cir.numberOfSlugs(width, lenght, radious, spaces);

            // Assert
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestMethod]
        public void Calculation_With_NegativeInputData()
        {
            // Arrange
            double width = 0;
            double lenght = 100;
            double radious = 1.784124116;
            double spaces = 1;
            double actualNumber = 0;
            CircleInRectangle cir = new CircleInRectangle();

            // Act
            actualNumber = cir.numberOfSlugs(width, lenght, radious, spaces);

            // Assert

            Assert.AreEqual(actualNumber, 0);

        }

    }
}
