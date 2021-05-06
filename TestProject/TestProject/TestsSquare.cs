using NUnit.Framework;

namespace TestProject
{
    public class TestsSquare
    {
        [Test, Combinatorial]
        public void TestAreaSquare ( [Range(0, 20)] int x )

        {
            var temp = GeometricFigures.Square.GetArea(x);
            Assert.AreEqual(ExpectedResult.GetAreaSquare(x), temp);
        }

        [Test, Combinatorial]
        public void TestLengthRectangle([Range(0, 20)] int x)
        {
            var temp = GeometricFigures.Square.GetLength(x);
            Assert.AreEqual(ExpectedResult.GetLengthSquare(x), temp);
        }
    }
}
