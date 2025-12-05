using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListTrueForAllTests
{
    [Fact]
    public void TrueForAll_ReturnsTrueWhenAllMatch()
    {
        ArrayList<int> list = new ArrayList<int> { 2, 4, 6 };

        bool allEven = list.TrueForAll(x => x % 2 == 0);

        Assert.True(allEven);
    }

    [Fact]
    public void TrueForAll_ReturnsFalseWhenNotAllMatch()
    {
        ArrayList<int> list = new ArrayList<int> { 2, 3, 6 };

        bool allEven = list.TrueForAll(x => x % 2 == 0);

        Assert.False(allEven);
    }

    [Fact]
    public void TrueForAll_EmptyList_ReturnsTrue()
    {
        ArrayList<int> list = new ArrayList<int>();

        bool result = list.TrueForAll(x => x > 0);

        Assert.True(result);
    }
}
