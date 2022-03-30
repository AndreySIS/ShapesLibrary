using System;
using NUnit.Framework;
using ShapesLibrary;

namespace TestShapesLibrary
{
    [TestFixture]
    internal class TestCircle
    {
        private Circle circle;

        [SetUp]
        public void SetUp()
        {
            circle = new Circle();
        }

        [Test]
        public void TestSquare()
        {
            circle.r = 5;
            double result = circle.Square();
            Assert.AreEqual(Math.Round(result, 2), 78.54);
        }
    }
}
