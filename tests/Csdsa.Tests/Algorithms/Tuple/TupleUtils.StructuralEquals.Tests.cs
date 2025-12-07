using System;

using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void StructuralEquals_ValueTuple_TrueForEqual()
    {
        (int First, string Second) a = (1, "x");
        (int First, string Second) b = (1, "x");

        bool equal = TupleUtils.StructuralEquals(a, b);

        Assert.True(equal);
    }

    [Fact]
    public void StructuralEquals_ReferenceTuple_FalseForMismatch()
    {
        Tuple<int, string> a = Tuple.Create(1, "x");
        Tuple<int, string> b = Tuple.Create(2, "x");

        bool equal = TupleUtils.StructuralEquals(a, b);

        Assert.False(equal);
    }
}
