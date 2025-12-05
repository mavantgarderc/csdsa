namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides <see cref="ILinkedList{T}.ReverseIterator"/> implementation
/// for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public IEnumerable<T> ReverseIterator()
    {
        LinkedListNode<T> current = _tail;

        while (current != null)
        {
            yield return current.Value;
            current = current.Prev;
        }
    }
}
