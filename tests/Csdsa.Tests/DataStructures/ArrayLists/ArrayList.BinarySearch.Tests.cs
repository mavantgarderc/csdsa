using System.Collections.Generic;
using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListBinarySearchTests
{
    [Fact]
    public void BinarySearch_FindsElement()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 3, 5, 7 };

        int index = list.BinarySearch(5);

        Assert.Equal(2, index);
    }

    [Fact]
    public void BinarySearch_WithRange_FindsElementInRange()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 3, 5, 7, 9 };

        int index = list.BinarySearch(1, 3, 5, Comparer<int>.Default);

        Assert.Equal(2, index);
    }
}
