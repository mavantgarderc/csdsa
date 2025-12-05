using System;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveFirst"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveFirst()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("bro list is empty...");
        }

        if (_head.Next == _head)
        {
            _head = null;
        }
        else
        {
            LinkedListNode<T> newHead = _head.Next;
            LinkedListNode<T> tail = Tail;

            newHead.Prev = tail;
            tail.Next = newHead;
            _head = newHead;
        }

        _count--;
        _version++;
    }
}
