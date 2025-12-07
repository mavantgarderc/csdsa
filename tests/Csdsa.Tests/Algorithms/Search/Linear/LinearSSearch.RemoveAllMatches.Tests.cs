using System.Collections.Generic;

using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void RemoveAllMatches_RemovesCorrectNumber()
    {
        List<int> collection = new List<int> { 1, 2, 3, 2 };

        int removed = collection.RemoveAllMatches(x => x == 2);

        Assert.Equal(2, removed);
        Assert.DoesNotContain(2, collection);
    }

    [Fact]
    public void RemoveAllMatches_RemovesNone_WhenNoMatch()
    {
        List<int> collection = new List<int> { 1, 2, 3 };

        int removed = collection.RemoveAllMatches(x => x == 99);

        Assert.Equal(0, removed);
        Assert.Equal(new[] { 1, 2, 3 }, collection);
    }
}
