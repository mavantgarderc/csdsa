using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorNormalizeTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 3, 4 }, new double[] { 0.6, 0.8 })]
    [InlineData(new double[] { 0, 5 }, new double[] { 0, 1 })]
    [InlineData(new double[] { -3, -4 }, new double[] { -0.6, -0.8 })]
    public void Normalize_ReturnsUnitVector(double[] components, double[] expected)
    {
        Vector<double> vector = new Vector<double>(components);
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector.Normalize();

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }

        Assert.Equal(1.0, result.Magnitude(), Tolerance);
    }
}
