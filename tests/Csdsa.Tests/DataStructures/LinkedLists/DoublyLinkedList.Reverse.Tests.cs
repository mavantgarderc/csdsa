using System.Linq;
using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListReverseTests
{
    private static readonly int[] Expected4321 = { 4, 3, 2, 1 };
    private static readonly int[] Expected1234 = { 1, 2, 3, 4 };

    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Fact]
    public void Reverse_And_ReverseIterator_Work()
    {
        DoublyLinkedList<int> list = NewList(1, 2, 3, 4);

        list.Reverse();

        Assert.Equal(Expected4321, list.ToArray());

        int[] back = list.ReverseIterator().Cast<int>().ToArray();
        Assert.Equal(Expected1234, back);
    }
}
