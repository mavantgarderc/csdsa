namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="PeekFirst"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public T PeekFirst()
    {
        if (_tail == null)
        {
            throw new InvalidOperationException("List is empty");
        }

        SinglyLinkedListNode<T> head = Head;
        return head.Value;
    }
}
