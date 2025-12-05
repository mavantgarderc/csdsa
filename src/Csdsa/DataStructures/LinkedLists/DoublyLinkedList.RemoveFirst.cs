namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveFirst"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveFirst()
    {
        if (_head == null)
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
            _head = _head.Next;
            _head.Prev = null;
        }

        _count--;
        _version++;
    }
}
