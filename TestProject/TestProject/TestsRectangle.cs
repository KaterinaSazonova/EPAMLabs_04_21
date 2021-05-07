using NUnit.Framework;

namespace TestProject
{
    public class TestsRectangle
    {
        [Test,Combinatorial]
        public void TestAreaRectangle (
            [Range(0, 20)] int x,
            [Range(0, 20)] int y)
    
        {
            var temp = GeometricFigures.Rectangle.GetArea(x, y);
            Assert.AreEqual(ExpectedResult.GetAreaRectangle(x, y), temp);
        }

        [Test, Combinatorial]
        public void TestLengthRectangle (
            [Range(0, 20)] int x,
            [Range(0, 20)] int y)

        {
            var temp = GeometricFigures.Rectangle.GetLength(x, y);
            Assert.AreEqual(ExpectedResult.GetLengthRectangle(x, y), temp);
        }
    }
}