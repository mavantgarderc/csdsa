using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorKroneckerProductTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2 }, new double[] { 3, 4 }, new double[] { 3, 4, 6, 8 })]
    [InlineData(new double[] { 1 }, new double[] { 2 }, new double[] { 2 })]
    [InlineData(new double[] { 0, 0 }, new double[] { 1, 2 }, new double[] { 0, 0, 0, 0 })]
    [InlineData(new double[] { -1, -2 }, new double[] { 3, 4 }, new double[] { -3, -4, -6, -8 })]
    public void KroneckerProduct_CalculatesCorrectly(double[] v1, double[] v2, double[] expected)
    {
        Vector<double> vector1 = new Vector<double>(v1);
        Vector<double> vector2 = new Vector<double>(v2);
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector1.KroneckerProduct(vector2);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }
    }
}
