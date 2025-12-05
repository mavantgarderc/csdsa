using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Contains(T)"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public bool Contains(T item)
    {
        if (_head == null)
        {
            return false;
        }

        LinkedListNode<T> current = _head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        do
        {
            if (comparer.Equals(current.Value, item))
            {
                return true;
            }

            current = current.Next;
        }
        while (!ReferenceEquals(current, _head));

        return false;
    }
}
