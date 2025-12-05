namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clone"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public ILinkedList<T> Clone()
    {
        DoublyLinkedList<T> clone = new DoublyLinkedList<T>();
        LinkedListNode<T> current = _head;

        while (current != null)
        {
            clone.AddLast(current.Value);
            current = current.Next;
        }

        return clone;
    }
}
