using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListFindAllTests
{
    [Fact]
    public void FindAll_ReturnsAllMatchingElements()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5, 6 };

        ArrayList<int> result = list.FindAll(x => x % 2 == 0);

        Assert.Equal(new[] { 2, 4, 6 }, result.ToArray());
    }

    [Fact]
    public void FindAll_NoMatches_ReturnsEmptyList()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 3, 5 };

        ArrayList<int> result = list.FindAll(x => x % 2 == 0);

        Assert.Empty(result);
    }
}
