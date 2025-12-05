using System;
using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayRemoveAtTests
{
    [Fact]
    public void DynamicArray_RemoveAt_RemovesElementAtSpecifiedIndex()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(10);
        array.Add(20);
        array.Add(30);

        array.RemoveAt(1);

        Assert.Equal(2, array.Count);
        Assert.Equal(30, array[1]);
    }

    [Fact]
    public void DynamicArray_RemoveAtOutOfRange_ThrowsException()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(1);

        Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveAt(-1));
        Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveAt(1));
    }
}
