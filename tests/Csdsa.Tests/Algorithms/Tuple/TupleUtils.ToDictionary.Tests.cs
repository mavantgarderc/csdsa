using System;
using System.Collections.Generic;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void ToDictionary_ConvertsToDict_WhenNotThrowing()
    {
        List<(int Key, string Value)> data = new List<(int, string)>
        {
            (1, "a"),
            (2, "b"),
        };

        Dictionary<int, string> dict = data.ToDictionary();

        Assert.Equal("a", dict[1]);
        Assert.Equal("b", dict[2]);
    }

    [Fact]
    public void ToDictionary_ThrowsWhenValueIsNull_IfThrowIfNullTrue()
    {
        List<(int Key, string? Value)> data = new List<(int, string?)>
        {
            (1, null),
        };

        InvalidOperationException ex =
            Assert.Throws<InvalidOperationException>(() => data.ToDictionary(true));

        Assert.Equal("Tuple.Item2 is null.", ex.Message);
    }
}
