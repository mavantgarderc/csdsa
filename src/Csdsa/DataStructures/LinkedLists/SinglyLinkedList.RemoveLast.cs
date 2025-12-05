namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveLast"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveLast()
    {
        if (_tail == null)
        {
            throw new InvalidOperationException("List is empty.");
        }

        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            SinglyLinkedListNode<T> current = _head;

            while (current.Next != _tail)
            {
                current = current.Next;
            }

            current.Next = null;
            _tail = current;
        }

        _count--;
        _version++;
    }
}
