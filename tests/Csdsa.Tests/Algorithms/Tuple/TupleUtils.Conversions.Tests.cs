using System;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void ToValueTuple_ConvertsFromTuple()
    {
        Tuple<int, string> tuple = new Tuple<int, string>(1, "a");

        (int First, string Second) result = tuple.ToValueTuple();

        Assert.Equal(1, result.First);
        Assert.Equal("a", result.Second);
    }

    [Fact]
    public void ToTuple_ConvertsValueTupleToTuple()
    {
        (int First, string Second) input = (1, "a");

        Tuple<int, string> result = input.ToTuple();

        Assert.Equal(1, result.Item1);
        Assert.Equal("a", result.Item2);
    }
}
