using System;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Map_ValueTuple_TransformsBothItems()
    {
        (int First, int Second) input = (2, 3);

        (int First, int Second) result = input.Map(x => x + 1, y => y * 2);

        Assert.Equal((3, 6), (result.First, result.Second));
    }

    [Fact]
    public void Map_ReferenceTuple_TransformsBothItems()
    {
        Tuple<int, int> input = Tuple.Create(2, 3);

        Tuple<int, int> result = input.Map(x => x + 1, y => y * 2);

        Assert.Equal(3, result.Item1);
        Assert.Equal(6, result.Item2);
    }
}
