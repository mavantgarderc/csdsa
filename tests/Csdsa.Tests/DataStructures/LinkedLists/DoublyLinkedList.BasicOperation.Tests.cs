using System.Linq;
using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListBasicOperationsTests
{
    private static readonly int[] Expected123 = { 1, 2, 3 };

    [Fact]
    public void AddFirst_AddLast_ToArray_And_Count_And_Contains_Work()
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();

        Assert.Equal(0, list.Count);

        list.AddFirst(2);
        list.AddFirst(1);
        list.AddLast(3);

        Assert.Equal(3, list.Count);

        int[] arr = list.ToArray();
        Assert.Equal(Expected123, arr);
        Assert.True(list.Contains(2));
        Assert.False(list.Contains(42));
    }
}
