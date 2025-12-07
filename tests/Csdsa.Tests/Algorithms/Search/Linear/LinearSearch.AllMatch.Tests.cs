using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void AllMatch_ReturnsTrue_WhenAllElementsMatch()
    {
        int[] collection = { 2, 4, 6 };

        bool result = collection.AllMatch(x => x % 2 == 0);

        Assert.True(result);
    }

    [Fact]
    public void AllMatch_ReturnsFalse_WhenAnyElementDoesNotMatch()
    {
        int[] collection = { 2, 3, 4 };

        bool result = collection.AllMatch(x => x % 2 == 0);

        Assert.False(result);
    }
}
