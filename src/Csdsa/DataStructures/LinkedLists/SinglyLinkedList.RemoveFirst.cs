namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="RemoveFirst"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public void RemoveFirst()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }

        _head = _head.Next;

        if (_head == null)
        {
            _tail = null;
        }

        _count--;
        _version++;
    }
}
