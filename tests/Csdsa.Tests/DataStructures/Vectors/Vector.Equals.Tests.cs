using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorEqualsTests
{
    [Theory]
    [InlineData(new double[] { 1, 2 }, new double[] { 1, 2 }, 0.01, true)]
    [InlineData(new double[] { 1, 2 }, new double[] { 1.01, 2.01 }, 0.1, true)]
    [InlineData(new double[] { 1, 2 }, new double[] { 3, 4 }, 0.01, false)]
    [InlineData(new double[] { 1, 2 }, new double[] { 1, 2, 3 }, 0.01, false)]
    public void Equals_ComparesVectors(double[] v1, double[] v2, double tolerance, bool expected)
    {
        Vector<double> vector1 = new Vector<double>(v1);
        Vector<double> vector2 = new Vector<double>(v2);

        bool result = vector1.Equals(vector2, tolerance);

        Assert.Equal(expected, result);
    }
}
