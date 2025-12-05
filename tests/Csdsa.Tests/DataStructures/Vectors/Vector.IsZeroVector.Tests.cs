using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorIsZeroVectorTests
{
    [Theory]
    [InlineData(new double[] { 0, 0, 0 }, 0.01, true)]
    [InlineData(new double[] { 0.001, -0.001 }, 0.01, true)]
    [InlineData(new double[] { 1, 2 }, 0.01, false)]
    [InlineData(new double[] { 0.1, 0 }, 0.01, false)]
    public void IsZeroVector_DetectsZero(double[] components, double tolerance, bool expected)
    {
        Vector<double> vector = new Vector<double>(components);

        bool result = vector.IsZeroVector(tolerance);

        Assert.Equal(expected, result);
    }
}
