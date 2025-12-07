using System.Collections.Generic;

using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void FindAll_Alias_ReturnsAllMatches()
    {
        int[] collection = { 1, 2, 2, 3 };

        IReadOnlyList<int> all = collection.FindAll(x => x == 2);

        Assert.Equal(2, all.Count);
        Assert.All(all, item => Assert.Equal(2, item));
    }

    [Fact]
    public void FindAll_Alias_ReturnsEmpty_WhenNoMatches()
    {
        int[] collection = { 1, 2, 3 };

        IReadOnlyList<int> all = collection.FindAll(x => x == 99);

        Assert.Empty(all);
    }
}
