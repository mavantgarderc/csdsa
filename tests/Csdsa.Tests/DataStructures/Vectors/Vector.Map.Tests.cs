using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorMapTests
{
    private const double Tolerance = 1e-6;

    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4 }, new double[] { 2, 4, 6, 8 })]
    [InlineData(new double[] { 1 }, new double[] { 2 })]
    [InlineData(new double[] { 0, 0, 0 }, new double[] { 0, 0, 0 })]
    [InlineData(new double[] { -1, -2 }, new double[] { -2, -4 })]
    public void Map_TransformsElements(double[] components, double[] expected)
    {
        Vector<double> vector = new Vector<double>(components);
        Vector<double> expectedVector = new Vector<double>(expected);

        Vector<double> result = vector.Map(x => x * 2);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expectedVector[i], result[i], Tolerance);
        }
    }
}
