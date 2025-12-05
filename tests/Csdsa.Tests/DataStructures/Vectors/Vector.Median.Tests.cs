using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorMedianTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4, 5 }, 3)]
    [InlineData(new double[] { 1, 2, 3, 4 }, 2.5)]
    [InlineData(new double[] { 5, 1, 3 }, 3)]
    [InlineData(new double[] { -5, -1, 3 }, -1)]
    public void Median_CalculatesMiddleValue(double[] components, double expected)
    {
        Vector<double> vector = new Vector<double>(components);

        double result = vector.Median();

        Assert.Equal(expected, result, Tolerance);
    }
}
