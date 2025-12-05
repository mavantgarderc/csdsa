using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayContainsTests
{
    [Fact]
    public void DynamicArray_Contains_ReturnsTrueWhenItemExists()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(1);
        array.Add(2);

        Assert.True(array.Contains(1));
        Assert.False(array.Contains(3));
    }
}
