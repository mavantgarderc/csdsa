namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="PeekFirst"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public T PeekFirst()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }

        return _head.Value;
    }
}
