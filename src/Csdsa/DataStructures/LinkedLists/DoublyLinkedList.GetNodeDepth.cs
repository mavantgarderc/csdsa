namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ILinkedList{T}.GetNodeDepth"/> implementation
/// for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public int GetNodeDepth(T item)
    {
        LinkedListNode<T> node = Find(item);

        if (node == null)
        {
            return -1;
        }

        int depth = 0;
        LinkedListNode<T> current = node;

        while (current.Prev != null)
        {
            depth++;
            current = current.Prev;
        }

        return depth;
    }
}
