using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorDotProductTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2 }, new double[] { 3, 4 }, 11)]
    [InlineData(new double[] { 0, 0 }, new double[] { 5, 6 }, 0)]
    [InlineData(new double[] { -1, -2 }, new double[] { 3, 4 }, -11)]
    [InlineData(new double[] { 1.5, 2.5 }, new double[] { 3.5, 4.5 }, 16.5)]
    public void DotProduct_CalculatesCorrectly(double[] v1, double[] v2, double expected)
    {
        Vector<double> vector1 = new Vector<double>(v1);
        Vector<double> vector2 = new Vector<double>(v2);

        double result = vector1.DotProduct(vector2);

        Assert.Equal(expected, result, Tolerance);
    }
}
