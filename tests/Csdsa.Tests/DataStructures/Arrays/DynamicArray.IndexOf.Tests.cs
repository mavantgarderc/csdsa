using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayIndexOfTests
{
    [Fact]
    public void DynamicArray_IndexOf_ReturnsExpectedIndices()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(10);
        array.Add(20);

        Assert.Equal(1, array.IndexOf(20));
        Assert.Equal(-1, array.IndexOf(30));
    }
}
