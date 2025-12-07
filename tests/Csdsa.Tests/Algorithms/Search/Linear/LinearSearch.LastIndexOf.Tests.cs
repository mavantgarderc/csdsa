using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void LastIndexOf_FindsLastMatch()
    {
        int[] collection = { 1, 2, 2, 4 };

        int lastIndex = collection.LastIndexOf(x => x == 2);

        Assert.Equal(2, lastIndex);
    }

    [Fact]
    public void LastIndexOf_ReturnsMinusOne_WhenNoMatch()
    {
        int[] collection = { 1, 2, 3 };

        int lastIndex = collection.LastIndexOf(x => x == 99);

        Assert.Equal(-1, lastIndex);
    }
}
