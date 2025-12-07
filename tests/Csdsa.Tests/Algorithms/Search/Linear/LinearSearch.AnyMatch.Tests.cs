using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void AnyMatch_ReturnsTrue_WhenAnyElementMatches()
    {
        int[] collection = { 1, 2, 3 };

        bool result = collection.AnyMatch(x => x == 2);

        Assert.True(result);
    }

    [Fact]
    public void AnyMatch_ReturnsFalse_WhenNoElementMatches()
    {
        int[] collection = { 1, 2, 3 };

        bool result = collection.AnyMatch(x => x == 99);

        Assert.False(result);
    }
}
