namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Reverse"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public void Reverse()
    {
        if (_head == null || _head.Next == _head)
        {
            return;
        }

        LinkedListNode<T> current = _head;

        do
        {
            LinkedListNode<T> temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;
            current = current.Prev;
        }
        while (!ReferenceEquals(current, _head));

        _head = _head.Next;
        _version++;
    }
}
