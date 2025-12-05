using Csdsa.DataStructures.Vectors;
using Xunit;

namespace Csdsa.Tests.DataStructures.Vectors;

public class VectorAsSpanTests
{
    private const double Tolerance = 1e-6;

    [Fact]
    public void AsSpan_ReturnsCorrectView()
    {
        double[] components = { 1, 2, 3 };
        Vector<double> vector = new Vector<double>(components);

        var span = vector.AsSpan();

        Assert.Equal(components.Length, span.Length);

        for (int i = 0; i < components.Length; i++)
        {
            Assert.Equal(components[i], span[i], Tolerance);
        }
    }
}
