using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListRemoveAllTests
{
    [Fact]
    public void RemoveAll_RemovesMatchingElements()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5, 6 };

        int removed = list.RemoveAll(x => x % 2 == 0);

        Assert.Equal(3, removed);
        Assert.Equal(new[] { 1, 3, 5 }, list.ToArray());
    }

    [Fact]
    public void RemoveAll_NoMatches_ReturnsZero()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 3, 5 };

        int removed = list.RemoveAll(x => x % 2 == 0);

        Assert.Equal(0, removed);
        Assert.Equal(new[] { 1, 3, 5 }, list.ToArray());
    }

    [Fact]
    public void RemoveAll_RemoveAll_EmptiesList()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        int removed = list.RemoveAll(_ => true);

        Assert.Equal(3, removed);
        Assert.Empty(list);
    }
}
