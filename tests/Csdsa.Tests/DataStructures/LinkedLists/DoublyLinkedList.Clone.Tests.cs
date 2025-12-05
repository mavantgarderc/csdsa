using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListCloneTests
{
    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Fact]
    public void Clone_Is_DeepCopy()
    {
        DoublyLinkedList<int> original = NewList(5, 6, 7);

        DoublyLinkedList<int> clone = (DoublyLinkedList<int>)original.Clone();

        Assert.Equal(original.ToArray(), clone.ToArray());

        clone.AddLast(8);

        Assert.NotEqual(original.Count, clone.Count);
    }
}
