namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Reverse"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void Reverse()
    {
        if (_tail == null || _tail.Next == _tail)
        {
            return;
        }

        SinglyLinkedListNode<T> prev = _tail;
        SinglyLinkedListNode<T> current = Head;
        SinglyLinkedListNode<T> head = Head;

        do
        {
            SinglyLinkedListNode<T> next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        while (!ReferenceEquals(current, head));

        _tail = head;
        _version++;
    }
}
