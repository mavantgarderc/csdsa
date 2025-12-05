namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides internal search helpers for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    private LinkedListNode<T> Find(T item)
    {
        LinkedListNode<T> current = _head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        while (current != null)
        {
            if (comparer.Equals(current.Value, item))
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }
}
