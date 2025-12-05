using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListGetRangeTests
{
    private static readonly int[] _expected234 = { 2, 3, 4 };

    [Fact]
    public void GetRange_ReturnsCorrectSublist()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5 };

        ArrayList<int> range = list.GetRange(1, 3);

        Assert.Equal(_expected234, range.ToArray());
    }

    [Fact]
    public void GetRange_EmptyRange_ReturnsEmptyList()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        ArrayList<int> range = list.GetRange(1, 0);

        Assert.Empty(range);
    }
}
