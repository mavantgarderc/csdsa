using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListGetNodeDepthTests
{
    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Fact]
    public void GetNodeDepth_Finds_Correct_Index_Or_NegativeOne()
    {
        DoublyLinkedList<int> list = NewList(10, 20, 30);

        Assert.Equal(0, list.GetNodeDepth(10));
        Assert.Equal(2, list.GetNodeDepth(30));
        Assert.Equal(-1, list.GetNodeDepth(99));
    }
}
