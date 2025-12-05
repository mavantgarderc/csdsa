namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddFirst(T)"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public void AddFirst(T item)
    {
        LinkedListNode<T> newNode = new LinkedListNode<T>(item);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Prev = newNode;
            _head = newNode;
        }

        _count++;
        _version++;
    }
}
