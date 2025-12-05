namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Remove(T)"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public bool Remove(T item)
    {
        if (_head == null)
        {
            return false;
        }

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        if (comparer.Equals(_head.Value, item))
        {
            RemoveFirst();
            return true;
        }

        SinglyLinkedListNode<T> current = _head;

        while (current.Next != null)
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
