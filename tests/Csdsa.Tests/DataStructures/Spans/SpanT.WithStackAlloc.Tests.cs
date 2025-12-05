using System;
using Csdsa.DataStructures.Spans;
using Xunit;

namespace Csdsa.Tests.DataStructures.Spans;

public class SpanTWithStackAllocTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(128)]
    public void WithStackAlloc_AllocatesCorrectSize(int size)
    {
        SpanT.WithStackAlloc(
            size,
            span =>
            {
                Assert.Equal(size, span.Length);
            });
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2048)]
    public void WithStackAlloc_ThrowsInvalidSize(int size)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => SpanT.WithStackAlloc(
                size,
                span =>
                {
                    // no-op
                }));
    }
}
