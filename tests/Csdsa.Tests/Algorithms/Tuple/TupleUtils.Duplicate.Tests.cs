using Csdsa.Algorithms.Tuples;

using Xunit;

namespace Csdsa.Tests.Algorithms.Tuples;

public sealed partial class TupleUtilsTests
{
    [Fact]
    public void Duplicate_CreatesRepeatedTuple()
    {
        (int First, int Second, int Third, int Fourth) result =
            TupleUtils.Duplicate((1, 2));

        Assert.Equal((1, 2, 1, 2), (result.First, result.Second, result.Third, result.Fourth));
    }
}
