using System.Collections.Generic;

using Csdsa.Algorithms.Search.Linear;

using Xunit;

namespace Csdsa.Tests.Algorithms.Search.Linear;

public sealed partial class LinearSearchTests
{
    [Fact]
    public void LinearSearch_Integration_WorksAcrossCommonOperations()
    {
        int[] data = { 1, 2, 2, 3, 4 };

        int firstIndex = data.IndexOf(x => x == 2);
        int lastIndex = data.LastIndexOf(x => x == 2);
        int count = data.CountMatches(x => x == 2);
        bool any = data.AnyMatch(x => x == 2);
        bool all = data.AllMatch(x => x > 0);

        Assert.Equal(1, firstIndex);
        Assert.Equal(2, lastIndex);
        Assert.Equal(2, count);
        Assert.True(any);
        Assert.True(all);
    }
}
