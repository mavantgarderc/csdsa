using System;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Swap_ValueTuple_SwapsElements()
    {
        (int First, string Second) input = (1, "a");

        (string Second, int First) swapped = input.Swap();

        Assert.Equal(("a", 1), (swapped.Second, swapped.First));
    }

    [Fact]
    public void Swap_ReferenceTuple_SwapsElements()
    {
        Tuple<int, string> input = Tuple.Create(1, "a");

        Tuple<string, int> swapped = input.Swap();

        Assert.Equal("a", swapped.Item1);
        Assert.Equal(1, swapped.Item2);
    }
}
