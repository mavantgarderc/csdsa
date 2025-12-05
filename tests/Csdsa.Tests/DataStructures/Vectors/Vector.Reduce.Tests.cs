using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorReduceTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4 }, 10)]
    [InlineData(new double[] { 5 }, 5)]
    [InlineData(new double[] { -1, 1 }, 0)]
    [InlineData(new double[] { 1.5, 2.5 }, 4)]
    public void Reduce_AggregatesValues(double[] components, double expected)
    {
        Vector<double> vector = new Vector<double>(components);

        double result = vector.Reduce((a, b) => a + b);

        Assert.Equal(expected, result, Tolerance);
    }
}
