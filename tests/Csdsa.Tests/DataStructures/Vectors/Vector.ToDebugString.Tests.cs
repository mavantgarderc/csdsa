using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorToDebugStringTests
{
    [Theory]
    [InlineData(new double[] { 1, 2, 3 }, "1.0000, 2.0000, 3.0000")]
    [InlineData(new double[] { 0.123456, 0.654321 }, "0.1235, 0.6543")]
    [InlineData(new double[] { 1 }, "1.0000")]
    [InlineData(new double[] { -1.5, 2.5 }, "-1.5000, 2.5000")]
    public void ToDebugString_FormatsCorrectly(double[] components, string expected)
    {
        Vector<double> vector = new Vector<double>(components);

        string result = vector.ToDebugString();

        Assert.Equal(expected, result);
    }
}
