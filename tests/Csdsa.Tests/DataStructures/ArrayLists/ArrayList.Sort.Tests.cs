using System.Collections.Generic;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListSortTests
{
    private static readonly int[] _expected123 = { 1, 2, 3 };

    [Fact]
    public void Sort_SortsCorrectly()
    {
        ArrayList<int> list = new ArrayList<int> { 3, 1, 2 };

        list.Sort();

        Assert.Equal(_expected123, list.ToArray());
    }

    [Fact]
    public void Sort_WithRange_SortsPartialList()
    {
        ArrayList<int> list = new ArrayList<int> { 5, 3, 1, 4, 2 };

        list.Sort(1, 3, Comparer<int>.Default);

        Assert.Equal(new[] { 5, 1, 3, 4, 2 }, list.ToArray());
    }
}
