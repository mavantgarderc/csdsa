using System;
using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayInsertTests
{
    [Fact]
    public void DynamicArray_Insert_InsertsElementAtSpecifiedIndex()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(1);
        array.Add(3);
        array.Insert(1, 2);

        Assert.Equal(3, array.Count);
        Assert.Equal(2, array[1]);
    }

    [Fact]
    public void DynamicArray_InsertAndRemoveAt_InvalidIndices_ThrowArgumentOutOfRangeException()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(1);

        Assert.Throws<ArgumentOutOfRangeException>(() => array.Insert(-1, 5));
        Assert.Throws<ArgumentOutOfRangeException>(() => array.RemoveAt(1));
    }
}
