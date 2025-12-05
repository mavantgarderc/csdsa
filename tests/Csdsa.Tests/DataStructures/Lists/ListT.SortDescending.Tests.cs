using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTSortDescendingTests
{
    [Fact]
    public void SortDescending_SortsCorrectly()
    {
        List<int> list = new List<int> { 1, 2, 3 };

        ListT.SortDescending(list);

        Assert.Equal(new[] { 3, 2, 1 }, list);
    }
}
