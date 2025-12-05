using System;
using Csdsa.DataStructures.Spans;
using Xunit;

namespace Csdsa.Tests.DataStructures.Spans;

public class SpanTReverseInPlaceTests
{
    private static readonly int[] Expected4321 = { 4, 3, 2, 1 };

    [Fact]
    public void ReverseInPlace_ReversesSpanCorrectly()
    {
        Span<int> span = stackalloc int[] { 1, 2, 3, 4 };

        SpanT.ReverseInPlace(span);

        Assert.Equal(Expected4321, span.ToArray());
    }
}
