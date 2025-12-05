using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListRemoveAtTests
{
    private static readonly int[] _expected13 = { 1, 3 };

    [Fact]
    public void RemoveAt_RemovesCorrectIndex()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        list.RemoveAt(1);

        Assert.Equal(_expected13, list.ToArray());
    }
}
