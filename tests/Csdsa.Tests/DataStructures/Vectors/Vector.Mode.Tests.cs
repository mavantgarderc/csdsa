using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorModeTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2, 2, 3 }, 2)]
    [InlineData(new double[] { 1, 1, 2, 2 }, 1)]
    [InlineData(new double[] { 5 }, 5)]
    [InlineData(new double[] { 1.1, 1.1, 2.2 }, 1.1)]
    public void Mode_ReturnsMostFrequent(double[] components, double expected)
    {
        Vector<double> vector = new Vector<double>(components);

        double result = vector.Mode();

        Assert.Equal(expected, result, Tolerance);
    }
}
