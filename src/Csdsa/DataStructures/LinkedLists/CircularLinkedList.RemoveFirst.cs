namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveFirst"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveFirst()
    {
        if (_tail == null)
        {
            throw new InvalidOperationException("list is empty bro...");
        }

        if (_tail.Next == _tail)
        {
            _tail = null;
        }
        else
        {
            SinglyLinkedListNode<T> head = _tail.Next;
            _tail.Next = head.Next;
        }

        _count--;
        _version++;
    }
}
