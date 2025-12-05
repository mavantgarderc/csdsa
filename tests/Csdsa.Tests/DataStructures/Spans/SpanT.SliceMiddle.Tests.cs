using System;
using Csdsa.DataStructures.Spans;
using Xunit;

namespace Csdsa.Tests.DataStructures.Spans;

public class SpanTSliceMiddleTests
{
    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 })]                 // Odd length
    [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]           // Even length
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 2 })]           // Odd length
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3 })]     // Even length
    public void SliceMiddle_ReturnsCorrectMiddleElements(
        int[] input,
        int[] expected)
    {
        Span<int> span = stackalloc int[input.Length];
        input.AsSpan().CopyTo(span);

        Span<int> middle = SpanT.SliceMiddle(span);

        Assert.Equal(expected, middle.ToArray());
    }
}
