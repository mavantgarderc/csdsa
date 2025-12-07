using System;
using Csdsa.Algorithms.Tuples;
using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Create_ReturnsCorrectTuple()
    {
        Tuple<int, string> tuple = TupleUtils.Create(1, "a");

        Assert.Equal(1, tuple.Item1);
        Assert.Equal("a", tuple.Item2);
    }

    [Fact]
    public void CreateValueTuple_ReturnsCorrectValueTuple()
    {
        (int, string) tuple = TupleUtils.CreateValueTuple(1, "a");

        Assert.Equal((1, "a"), tuple);
    }
}
