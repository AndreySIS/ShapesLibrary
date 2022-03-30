using System;
using NUnit.Framework;
using ShapesLibrary;

namespace TestShapesLibrary
{
    [TestFixture]
    internal class TestTriangle
    {
        private Triangle triangle;

        [SetUp]
        public void SetUp()
        {
            triangle = new Triangle();
        }

        [Test]
        public void TestSquare()
        {
            triangle.a = 9;
            triangle.b = 5;
            triangle.c = 7;
            double result = triangle.Square();
            Assert.AreEqual(Math.Round(result, 2), 17.41);
        }

        [Test]
        public void TestCheckRightTriangleTrue()
        {
            triangle.a = 3;
            triangle.b = 4;
            triangle.c = 5;
            string result = triangle.CheckRightTriangle();
            Assert.AreEqual(result, "Right triangle");
        }

        [Test]
        public void TestCheckRightTriangleFalse()
        {
            triangle.a = 3;
            triangle.b = 4;
            triangle.c = 6;
            string result = triangle.CheckRightTriangle();
            Assert.AreEqual(result, "Non-right triangle");
        }
    }
}
