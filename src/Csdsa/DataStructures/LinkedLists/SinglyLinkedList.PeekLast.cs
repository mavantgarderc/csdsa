namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="PeekLast"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
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
