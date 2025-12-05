using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListAddRangeTests
{
    private static readonly int[] _collection34 = { 3, 4 };
    private static readonly int[] _expected1234 = { 1, 2, 3, 4 };

    [Fact]
    public void AddRange_AppendsAllElements()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2 };

        list.AddRange(_collection34);

        Assert.Equal(_expected1234, list.ToArray());
    }
}
