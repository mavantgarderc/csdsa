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

    [Fact]
    public void AsSpan_ContainsSameComponents()
    {
        Vector<int> vector = new Vector<int>(new[] { 1, 2, 3 });

        Span<int> span = vector.AsSpan();

        Assert.Equal(3, span.Length);
        Assert.Equal(1, span[0]);
        Assert.Equal(2, span[1]);
        Assert.Equal(3, span[2]);
    }

    [Fact]
    public void AsSpan_ReturnsIndependentCopy()
    {
        Vector<int> vector = new Vector<int>(new[] { 1, 2, 3 });

        Span<int> span = vector.AsSpan();
        span[0] = 99;

        // Since AsSpan returns a span over a copy, original vector should be unchanged.
        Span<int> span2 = vector.AsSpan();
        Assert.Equal(1, span2[0]);
    }
}
