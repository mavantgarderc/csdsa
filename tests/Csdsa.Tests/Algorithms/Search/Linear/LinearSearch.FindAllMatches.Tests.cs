using System.Collections.Generic;

using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void FindAllMatches_FindsAllMatchingElements()
    {
        int[] collection = { 1, 2, 3, 4, 5 };

        IReadOnlyList<int> matches = LinearSearch.FindAllMatches(collection, x => x % 2 == 0);

        Assert.Equal(2, matches.Count);
        Assert.Contains(2, matches);
        Assert.Contains(4, matches);
    }

    [Fact]
    public void FindAllMatches_ReturnsEmpty_WhenNoMatches()
    {
        int[] collection = { 1, 3, 5 };

        IReadOnlyList<int> matches = LinearSearch.FindAllMatches(collection, x => x % 2 == 0);

        Assert.Empty(matches);
    }
}
