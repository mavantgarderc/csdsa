namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="PeekLast"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public T PeekLast()
    {
        if (_tail == null)
        {
            throw new InvalidOperationException("List is empty.");
        }

        return _tail.Value;
    }
}
