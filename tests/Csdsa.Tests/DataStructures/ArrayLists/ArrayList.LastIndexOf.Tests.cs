using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListLastIndexOfTests
{
    [Fact]
    public void LastIndexOf_FindsLastOccurrence()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 2, 4 };

        int index = list.LastIndexOf(2);

        Assert.Equal(3, index);
    }

    [Fact]
    public void LastIndexOf_WithStartIndex_FindsCorrectOccurrence()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 2, 4 };

        int index = list.LastIndexOf(2, 2);

        Assert.Equal(1, index);
    }

    [Fact]
    public void LastIndexOf_WithStartIndexAndCount_FindsCorrectOccurrence()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 2, 4 };

        int index = list.LastIndexOf(2, 3, 3);

        Assert.Equal(3, index);
    }
}
