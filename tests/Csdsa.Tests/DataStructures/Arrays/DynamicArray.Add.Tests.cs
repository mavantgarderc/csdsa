using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayAddTests
{
    [Fact]
    public void DynamicArray_AddElements_ShouldIncreaseCount()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(10);
        array.Add(20);

        Assert.Equal(2, array.Count);
        Assert.Equal(10, array[0]);
        Assert.Equal(20, array[1]);
    }

    [Fact]
    public void DynamicArray_Add_AppendsElementsInOrder()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(1);
        array.Add(2);

        Assert.Equal(2, array.Count);
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
    }
}
