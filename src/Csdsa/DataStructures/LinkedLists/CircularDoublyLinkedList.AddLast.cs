namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddLast(T)"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public void AddLast(T item)
    {
        if (_head == null)
        {
            AddFirst(item);
        }
        else
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);
            LinkedListNode<T> tail = Tail;

            newNode.Next = _head;
            newNode.Prev = tail;
            tail.Next = newNode;
            _head.Prev = newNode;
        }

        _count++;
        _version++;
    }
}
