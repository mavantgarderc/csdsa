namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveLast"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveLast()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("list is empty bro...");
        }

        if (_head.Next == _head)
        {
            _head = null;
        }
        else
        {
            LinkedListNode<T> tail = Tail;
            LinkedListNode<T> newTail = tail.Prev;

            newTail.Next = _head;
            _head.Prev = newTail;
        }

        _count--;
        _version++;
    }
}
