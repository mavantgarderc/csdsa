using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayIndexerTests
{
    [Fact]
    public void DynamicArray_Indexer_GetAndSet_WorkAsExpected()
    {
        DynamicArray<int> array = new DynamicArray<int>();

        array.Add(5);
        array[0] = 10;

        Assert.Equal(10, array[0]);
    }
}
