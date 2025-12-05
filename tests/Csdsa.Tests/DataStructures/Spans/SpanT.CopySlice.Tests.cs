using System;
using Csdsa.DataStructures.Spans;
using Xunit;

namespace Csdsa.Tests.DataStructures.Spans;

public class SpanTCopySliceTests
{
    [Fact]
    public void CopySlice_CopiesSuccessfully()
    {
        Span<int> source = stackalloc int[] { 1, 2, 3 };
        Span<int> destination = stackalloc int[3];

        SpanT.CopySlice(source, destination);

        Assert.Equal(source.ToArray(), destination.ToArray());
    }

    [Fact]
    public void CopySlice_ThrowsIfDestinationTooSmall()
    {
        Span<int> source = stackalloc int[] { 1, 2, 3 };
        Span<int> destination = stackalloc int[2];

        ArgumentException ex = null;

        try
        {
            SpanT.CopySlice(source, destination);
        }
        catch (ArgumentException e)
        {
            ex = e;
        }

        Assert.NotNull(ex);
        Assert.Contains("Destination span is too small.", ex.Message);
    }
}
