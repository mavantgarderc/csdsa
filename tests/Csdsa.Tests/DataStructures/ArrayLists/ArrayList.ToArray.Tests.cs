using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListToArrayTests
{
    private static readonly int[] _expected1020 = { 10, 20 };

    [Fact]
    public void ToArray_CopiesContents()
    {
        ArrayList<int> list = new ArrayList<int> { 10, 20 };

        int[] array = list.ToArray();

        Assert.Equal(_expected1020, array);
    }

    [Fact]
    public void ToArray_EmptyList_ReturnsEmptyArray()
    {
        ArrayList<int> list = new ArrayList<int>();

        int[] array = list.ToArray();

        Assert.Empty(array);
    }
}
