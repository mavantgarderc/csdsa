using System.Collections.Generic;
using Csdsa.DataStructures.Lists;
using Xunit;

namespace Csdsa.Tests.DataStructures.Lists;

public class ListTSortAscendingTests
{
    [Fact]
    public void SortAscending_SortsCorrectly()
    {
        List<int> list = new List<int> { 3, 1, 2 };

        ListT.SortAscending(list);

        Assert.Equal(new[] { 1, 2, 3 }, list);
    }
}
