namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetNodeDepth"/> implementation
/// for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public int GetNodeDepth(T item)
    {
        if (_tail == null)
        {
            return -1;
        }

        int depth = 0;
        SinglyLinkedListNode<T> current = Head;
        SinglyLinkedListNode<T> start = current;
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
        while (!ReferenceEquals(current, start));

        return -1;
    }
}
