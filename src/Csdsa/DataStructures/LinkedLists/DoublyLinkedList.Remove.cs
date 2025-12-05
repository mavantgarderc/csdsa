namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Remove(T)"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public bool Remove(T item)
    {
        LinkedListNode<T> node = Find(item);

        if (node == null)
        {
            return false;
        }

        if (node == _head)
        {
            RemoveFirst();
        }
        else if (node == _tail)
        {
            RemoveLast();
        }
        else
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            _count--;
            _version++;
        }

        return true;
    }
}
