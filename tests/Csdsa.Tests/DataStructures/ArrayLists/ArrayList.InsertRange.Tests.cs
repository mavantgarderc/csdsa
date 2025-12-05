using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListInsertRangeTests
{
    private static readonly int[] _expected1234 = { 1, 2, 3, 4 };

    [Fact]
    public void InsertRange_InsertsAllAtCorrectIndex()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 4 };

        list.InsertRange(1, new[] { 2, 3 });

        Assert.Equal(_expected1234, list.ToArray());
    }
}
