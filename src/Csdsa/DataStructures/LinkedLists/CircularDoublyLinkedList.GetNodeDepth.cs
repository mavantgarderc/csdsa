using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetNodeDepth"/> implementation
/// for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public int GetNodeDepth(T item)
    {
        if (_head == null)
        {
            return -1;
        }

        int depth = 0;
        LinkedListNode<T> current = _head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        do
        {
            if (comparer.Equals(current.Value, item))
            {
                return depth;
            }

            depth++;
            current = current.Next;
        }
        while (!ReferenceEquals(current, _head));

        return -1;
    }
}
