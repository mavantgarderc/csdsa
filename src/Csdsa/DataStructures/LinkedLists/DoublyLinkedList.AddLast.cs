namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddLast(T)"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public void AddLast(T item)
    {
        LinkedListNode<T> newNode = new LinkedListNode<T>(item);

        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Prev = _tail;
            _tail.Next = newNode;
            _tail = newNode;
        }

        _count++;
        _version++;
    }
}
