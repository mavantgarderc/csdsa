using Csdsa.DataStructures.ArrayList;
using Xunit;

namespace Csdsa.Tests.DataStructures.ArrayList;

public class ArrayListReverseTests
{
    private static readonly int[] _expected321 = { 3, 2, 1 };

    [Fact]
    public void Reverse_ReversesList()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3 };

        list.Reverse();

        Assert.Equal(_expected321, list.ToArray());
    }

    [Fact]
    public void Reverse_WithRange_ReversesPartialList()
    {
        ArrayList<int> list = new ArrayList<int> { 1, 2, 3, 4, 5 };

        list.Reverse(1, 3);

        Assert.Equal(new[] { 1, 4, 3, 2, 5 }, list.ToArray());
    }
}
