using Csdsa.DataStructures.Arrays;
using Xunit;

namespace Csdsa.Tests.DataStructures.Arrays;

public class DynamicArrayClearTests
{
    [Fact]
    public void DynamicArray_Clear_RemovesAllElements()
    {
        DynamicArray<string> array = new DynamicArray<string>();

        array.Add("hello");
        array.Clear();

        Assert.Equal(0, array.Count);
    }
}
