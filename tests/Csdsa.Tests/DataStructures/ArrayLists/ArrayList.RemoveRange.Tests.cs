using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListRemoveRangeTests
{
    private static readonly int[] _expected15 = { 1, 5 };

    [Fact]
    public void RemoveRange_RemovesCorrectSubset()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5 };

        list.RemoveRange(1, 3);

        Assert.Equal(_expected15, list.ToArray());
    }
}
