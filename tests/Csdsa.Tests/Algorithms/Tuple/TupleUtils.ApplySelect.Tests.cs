using System;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Apply_ExecutesActionOnTuple()
    {
        int result = 0;

        TupleUtils.Apply((2, 3), (x, y) => result = x + y);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Select_ProjectsTupleToResult()
    {
        int result = TupleUtils.Select((2, 3), (x, y) => x * y);

        Assert.Equal(6, result);
    }

    [Fact]
    public void TransformAll_MapsBothItems()
    {
        (int First, int Second) result = TupleUtils.TransformAll((3, 4), x => x * 10);

        Assert.Equal((30, 40), (result.First, result.Second));
    }
}
