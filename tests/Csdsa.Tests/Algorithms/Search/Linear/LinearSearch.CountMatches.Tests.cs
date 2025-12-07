using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void CountMatches_CountsCorrectly()
    {
        int[] collection = { 1, 2, 2, 3 };

        int count = collection.CountMatches(x => x == 2);

        Assert.Equal(2, count);
    }

    [Fact]
    public void CountMatches_ReturnsZero_WhenNoMatch()
    {
        int[] collection = { 1, 2, 3 };

        int count = collection.CountMatches(x => x == 99);

        Assert.Equal(0, count);
    }
}
