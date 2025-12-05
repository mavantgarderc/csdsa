using System;
using Csdsa.DataStructures.LinkedLists;
using Xunit;

namespace Csdsa.Tests.DataStructures.LinkedLists;

public class DoublyLinkedListPeekAndRemoveTests
{
    private static DoublyLinkedList<int> NewList(params int[] items)
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.AddRange(items);
        return list;
    }

    [Fact]
    public void PeekFirst_PeekLast_And_RemoveMethods_Work_And_Throw_OnEmpty()
    {
        DoublyLinkedList<int> list = NewList(10, 20, 30);

        Assert.Equal(10, list.PeekFirst());
        Assert.Equal(30, list.PeekLast());

        list.RemoveFirst();
        Assert.Equal(2, list.Count);
        Assert.Equal(20, list.PeekFirst());

        list.RemoveLast();
        Assert.Single(list);
        Assert.Equal(20, list.PeekLast());

        bool removed = list.Remove(20);
        Assert.True(removed);
        Assert.Empty(list);
        Assert.False(list.Remove(999));

        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        Assert.Throws<InvalidOperationException>(() => list.PeekFirst());
        Assert.Throws<InvalidOperationException>(() => list.PeekLast());
    }
}
