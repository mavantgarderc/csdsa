namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides <see cref="ILinkedList{T}.ReverseIterator"/> implementation
/// for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public System.Collections.Generic.IEnumerable<T> ReverseIterator()
    {
        if (_head == null)
        {
            yield break;
        }

        LinkedListNode<T> start = Tail;
        LinkedListNode<T> current = start;

        do
        {
            yield return current.Value;
            current = current.Prev;
        }
        while (!ReferenceEquals(current, start));
    }
}
