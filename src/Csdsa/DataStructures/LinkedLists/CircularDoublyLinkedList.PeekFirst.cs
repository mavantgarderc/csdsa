using System;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="PeekFirst"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public T PeekFirst()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("list is empty");
        }

        return _head.Value;
    }
}
