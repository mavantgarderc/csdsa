using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorMeanTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4 }, 2.5)]
    [InlineData(new double[] { 5, 5, 5, 5 }, 5)]
    [InlineData(new double[] { -1, -2, -3 }, -2)]
    [InlineData(new double[] { 1.5, 2.5, 3.5 }, 2.5)]
    public void Mean_CalculatesAverage(double[] components, double expected)
    {
        Vector<double> vector = new Vector<double>(components);

        double result = vector.Mean();

        Assert.Equal(expected, result, Tolerance);
    }
}
