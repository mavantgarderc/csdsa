using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorScaleTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2 }, 2, new double[] { 2, 4 })]
    [InlineData(new double[] { 3, 4 }, 0, new double[] { 0, 0 })]
    [InlineData(new double[] { -1, -2 }, 3, new double[] { -3, -6 })]
    [InlineData(new double[] { 1.5, 2.5 }, 2, new double[] { 3, 5 })]
    public void Scale_ReturnsScaledVector(double[] components, double scalar, double[] expected)
    {
        Vector<double> vector = new Vector<double>(components);
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector.Scale(scalar);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }
    }
}
