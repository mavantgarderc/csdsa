using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorAddTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2 }, new double[] { 3, 4 }, new double[] { 4, 6 })]
    [InlineData(new double[] { 0, 0 }, new double[] { 5, 6 }, new double[] { 5, 6 })]
    [InlineData(new double[] { -1, -2 }, new double[] { 3, 4 }, new double[] { 2, 2 })]
    [InlineData(new double[] { 1.5, 2.5 }, new double[] { 3.5, 4.5 }, new double[] { 5, 7 })]
    public void Add_ReturnsSum(double[] v1, double[] v2, double[] expected)
    {
        Vector<double> vector1 = new Vector<double>(v1);
        Vector<double> vector2 = new Vector<double>(v2);
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector1 + vector2;

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }
    }
}
