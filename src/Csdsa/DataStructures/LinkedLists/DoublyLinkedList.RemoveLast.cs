namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveLast"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
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
            _tail = _tail.Prev;
            _tail.Next = null;
        }

        _count--;
        _version++;
    }
}
