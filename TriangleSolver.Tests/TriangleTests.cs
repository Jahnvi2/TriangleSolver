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

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_TwoEqualSides1_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_TwoEqualSides2_ReturnsIsosceles()
        {
            int side1 = 6, side2 = 8, side3 = 8;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_TwoEqualSides3_ReturnsIsosceles()
        {
            int side1 = 9, side2 = 9, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Isosceles triangle", result);
        }



    }
}
