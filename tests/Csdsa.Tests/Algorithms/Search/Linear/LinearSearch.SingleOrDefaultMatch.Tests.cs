using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void SingleOrDefaultMatch_ReturnsSingleMatch()
    {
        int[] collection = { 1, 2, 3 };

        int match = collection.SingleOrDefaultMatch(x => x == 2);

        Assert.Equal(2, match);
    }

    [Fact]
    public void SingleOrDefaultMatch_ReturnsDefault_WhenMultipleMatches()
    {
        int[] collection = { 1, 2, 2 };

        int match = collection.SingleOrDefaultMatch(x => x == 2);

        Assert.Equal(0, match);
    }

    [Fact]
    public void SingleOrDefaultMatch_ReturnsDefault_WhenNoMatch()
    {
        int[] collection = { 1, 2, 3 };

        int match = collection.SingleOrDefaultMatch(x => x == 99);

        Assert.Equal(0, match);
    }
}
