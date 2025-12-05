using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListRemoveTests
{
    private static readonly int[] _expected13 = { 1, 3 };

    [Fact]
    public void Remove_RemovesFirstOccurrence()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        bool removed = list.Remove(2);

        Assert.True(removed);
        Assert.Equal(_expected13, list.ToArray());
    }
}
