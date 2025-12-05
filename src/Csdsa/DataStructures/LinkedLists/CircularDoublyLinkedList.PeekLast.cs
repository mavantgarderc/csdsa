using System;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="PeekLast"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public T PeekLast()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("List is empty");
        }

        LinkedListNode<T> tail = Tail;
        return tail.Value;
    }
}
