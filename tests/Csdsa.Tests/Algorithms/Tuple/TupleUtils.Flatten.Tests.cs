using System;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Flatten_ValueTuple_FlattensProperly()
    {
        ((int First, int Second), int Third) nested = ((1, 2), 3);

        (int First, int Second, int Third) flat = nested.Flatten();

        Assert.Equal((1, 2, 3), (flat.First, flat.Second, flat.Third));
    }

    [Fact]
    public void Flatten_ReferenceTuple_FlattensProperly()
    {
        Tuple<Tuple<int, int>, int> nested = Tuple.Create(Tuple.Create(1, 2), 3);

        Tuple<int, int, int> flat = nested.Flatten();

        Assert.Equal(1, flat.Item1);
        Assert.Equal(2, flat.Item2);
        Assert.Equal(3, flat.Item3);
    }
}
