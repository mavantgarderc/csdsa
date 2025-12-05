using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListFindTests
{
    [Fact]
    public void Find_ReturnsFirstMatchingElement()
    {
        ArrayList<string> list = new ArrayList<string> { "apple", "banana", "cherry" };

        string result = list.Find(x => x.StartsWith("b"));

        Assert.Equal("banana", result);
    }

    [Fact]
    public void Find_ReturnsDefaultWhenNotFound()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        int result = list.Find(x => x > 5);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Find_EmptyList_ReturnsDefault()
    {
        ArrayList<int> list = new ArrayList<int>();

        int result = list.Find(x => x > 0);

        Assert.Equal(0, result);
    }
}
