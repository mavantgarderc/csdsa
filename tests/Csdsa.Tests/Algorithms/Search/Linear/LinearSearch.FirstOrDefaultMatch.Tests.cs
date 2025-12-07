using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void FirstOrDefaultMatch_FindsFirstMatch()
    {
        int[] collection = { 1, 2, 3 };

        int first = collection.FirstOrDefaultMatch(x => x > 1);

        Assert.Equal(2, first);
    }

    [Fact]
    public void FirstOrDefaultMatch_ReturnsDefault_WhenNoMatch()
    {
        int[] collection = { 1, 2, 3 };

        int first = collection.FirstOrDefaultMatch(x => x == 99);

        Assert.Equal(0, first);
    }
}
