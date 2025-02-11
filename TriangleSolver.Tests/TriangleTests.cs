using NUnit.Framework;
using System;
using TriangleSolver;

namespace TriangleSolver.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AnalyzeTriangle_EquilateralTriangle_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }


        

    }
}
