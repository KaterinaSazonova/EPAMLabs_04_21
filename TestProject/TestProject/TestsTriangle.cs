using NUnit.Framework;

namespace TestProject
{
    public class TestsTriangle
    {

        [Test, Combinatorial]
        public void TestAreaTriangle (
            [Range(0, 20)] int x,
            [Range(0, 20)] int y,
            [Range(0, 20)] int z)

        {
            var temp = GeometricFigures.Triangle.GetArea(x, y, z);
            Assert.AreEqual(ExpectedResult.GetAreaTriangle(x, y, z ), temp);
        }

        [Test, Combinatorial]
        public void TestLengthTriangle(
            [Range(0, 20)] int x,
            [Range(0, 20)] int y,
            [Range(0, 20)] int z)

        {
            var temp = GeometricFigures.Triangle.GetLength(x, y, z);
            Assert.AreEqual(ExpectedResult.GetLengthTriangle(x, y, z), temp);
        }
    }
}