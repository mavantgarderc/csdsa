using System;
using System.Collections.Generic;
using System.Linq;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void ZipToValueTuples_ZipsCorrectly()
    {
        int[] first = { 1, 2 };
        string[] second = { "a", "b" };

        List<(int First, string Second)> result =
            TupleUtils.ZipToValueTuples(first, second).ToList();

        Assert.Equal((1, "a"), (result[0].First, result[0].Second));
        Assert.Equal((2, "b"), (result[1].First, result[1].Second));
    }

    [Fact]
    public void ZipToTuples_ZipsCorrectly()
    {
        int[] first = { 1, 2 };
        string[] second = { "a", "b" };

        List<Tuple<int, string>> result =
            TupleUtils.ZipToTuples(first, second).ToList();

        Assert.Equal(1, result[0].Item1);
        Assert.Equal("a", result[0].Item2);
    }
}
