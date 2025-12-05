namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddFirst(T)"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public void AddFirst(T item)
    {
        LinkedListNode<T> newNode = new LinkedListNode<T>(item);

        if (_head == null)
        {
            newNode.Next = newNode;
            newNode.Prev = newNode;
            _head = newNode;
        }
        else
        {
            LinkedListNode<T> tail = Tail;

            newNode.Next = _head;
            newNode.Prev = tail;
            tail.Next = newNode;
            _head.Prev = newNode;
            _head = newNode;
        }

        _count++;
        _version++;
    }
}
