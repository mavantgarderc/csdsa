namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Contains(T)"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public bool Contains(T item)
    {
        SinglyLinkedListNode<T> current = _head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        while (current != null)
        {
            if (comparer.Equals(current.Value, item))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }
}
