using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorMagnitudeTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 3, 4 }, 5)]
    [InlineData(new double[] { 1, 1, 1, 1 }, 2)]
    [InlineData(new double[] { 0, 0, 0 }, 0)]
    [InlineData(new double[] { -3, -4 }, 5)]
    public void Magnitude_CalculatesCorrectly(double[] components, double expected)
    {
        Vector<double> vector = new Vector<double>(components);

        double result = vector.Magnitude();

        Assert.Equal(expected, result, Tolerance);
    }
}
