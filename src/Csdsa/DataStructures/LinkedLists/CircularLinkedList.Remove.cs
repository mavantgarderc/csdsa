namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Remove(T)"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public bool Remove(T item)
    {
        if (_tail == null)
        {
            return false;
        }

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        SinglyLinkedListNode<T> head = Head;

        if (comparer.Equals(head.Value, item))
        {
            RemoveFirst();
            return true;
        }

        SinglyLinkedListNode<T> current = head;

        while (current.Next != head)
        {
            if (comparer.Equals(current.Next.Value, item))
            {
                if (current.Next == _tail)
                {
                    _tail = current;
                }

                current.Next = current.Next.Next;

                _count--;
                _version++;

                return true;
            }

            current = current.Next;
        }

        return false;
    }
}
