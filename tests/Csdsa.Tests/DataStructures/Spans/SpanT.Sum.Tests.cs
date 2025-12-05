using System;
using Csdsa.DataStructures.Spans;
using Xunit;

namespace Csdsa.Tests.DataStructures.Spans;

public class SpanTSumTests
{
    [Fact]
    public void Sum_ReturnsCorrectSum()
    {
        Span<int> span = stackalloc int[] { 10, 20, 30 };

        int result = SpanT.Sum(span);

        Assert.Equal(60, result);
    }
}
