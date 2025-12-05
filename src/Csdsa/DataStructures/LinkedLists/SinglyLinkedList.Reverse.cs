namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Reverse"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public void Reverse()
    {
        if (_head == null || _head == _tail)
        {
            return;
        }

        SinglyLinkedListNode<T> previous = null;
        SinglyLinkedListNode<T> current = _head;
        _tail = _head;

        while (current != null)
        {
            SinglyLinkedListNode<T> next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        _head = previous;
        _version++;
    }
}
