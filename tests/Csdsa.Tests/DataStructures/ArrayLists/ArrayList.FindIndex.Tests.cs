using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListFindIndexTests
{
    [Fact]
    public void FindIndex_FindsFirstMatchingElement()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5 };

        int index = list.FindIndex(x => x > 3);

        Assert.Equal(3, index);
    }

    [Fact]
    public void FindIndex_WithStartIndex_FindsFromPosition()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5 };

        int index = list.FindIndex(2, x => x > 3);

        Assert.Equal(3, index);
    }

    [Fact]
    public void FindIndex_WithStartIndexAndCount_FindsInRange()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5 };

        int index = list.FindIndex(0, 3, x => x > 2);

        Assert.Equal(2, index);
    }
}
