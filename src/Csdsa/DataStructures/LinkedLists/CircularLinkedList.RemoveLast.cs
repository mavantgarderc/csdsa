namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveLast"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveLast()
    {
        if (_tail == null)
        {
            throw new InvalidOperationException("HAHA! EMPTY...");
        }

        if (_tail.Next == _tail)
        {
            _tail = null;
        }
        else
        {
            SinglyLinkedListNode<T> current = _tail.Next;

            while (current.Next != _tail)
            {
                current = current.Next;
            }

            current.Next = _tail.Next;
            _tail = current;
        }

        _count--;
        _version++;
    }
}
