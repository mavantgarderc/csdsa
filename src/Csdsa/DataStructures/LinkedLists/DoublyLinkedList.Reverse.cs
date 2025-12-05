namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Reverse"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public void Reverse()
    {
        if (_head == null || _head == _tail)
        {
            return;
        }

        LinkedListNode<T> current = _head;
        _tail = _head;
        LinkedListNode<T> temp = null;

        while (current != null)
        {
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;
            current = current.Prev;
        }

        if (temp != null)
        {
            _head = temp.Prev;
            _version++;
        }
    }
}
