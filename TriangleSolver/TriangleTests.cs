using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AnalyzeTriangle_ThreeEqualSides_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 5;
            string expected = "Equilateral triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
