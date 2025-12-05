using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Contains(T)"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public bool Contains(T item)
    {
        if (_tail == null)
        {
            return false;
        }

        SinglyLinkedListNode<T> current = Head;
        SinglyLinkedListNode<T> start = current;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        do
        {
            if (comparer.Equals(current.Value, item))
            {
                return true;
            }

            current = current.Next;
        }
        while (!ReferenceEquals(current, start));

        return false;
    }
}
