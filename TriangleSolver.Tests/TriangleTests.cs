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

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Valid1_ReturnsScalene()
        {
            int side1 = 3, side2 = 4, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Valid2_ReturnsScalene()
        {
            int side1 = 7, side2 = 10, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Valid3_ReturnsScalene()
        {
            int side1 = 8, side2 = 15, side3 = 17;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Valid4_ReturnsScalene()
        {
            int side1 = 5, side2 = 12, side3 = 13;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Valid5_ReturnsScalene()
        {
            int side1 = 11, side2 = 14, side3 = 18;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Scalene triangle", result);
        }


    }
}
