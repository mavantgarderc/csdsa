using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Remove(T)"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public bool Remove(T item)
    {
        if (_head == null)
        {
            return false;
        }

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        LinkedListNode<T> current = _head;

        do
        {
            if (comparer.Equals(current.Value, item))
            {
                if (ReferenceEquals(current, _head))
                {
                    RemoveFirst();
                }
                else if (ReferenceEquals(current, Tail))
                {
                    RemoveLast();
                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                    _count--;
                    _version++;
                }

                return true;
            }

            current = current.Next;
        }
        while (!ReferenceEquals(current, _head));

        return false;
    }
}
