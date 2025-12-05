using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListClearTests
{
    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Fact]
    public void Clear_Empties_List()
    {
        DoublyLinkedList<int> list = NewList(1, 2, 3);

        list.Clear();

        Assert.Empty(list);
        Assert.False(list.Contains(1));
    }
}
