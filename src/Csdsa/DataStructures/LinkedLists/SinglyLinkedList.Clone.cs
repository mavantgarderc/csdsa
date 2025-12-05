namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clone"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public ILinkedList<T> Clone()
    {
        SinglyLinkedList<T> clone = new SinglyLinkedList<T>();
        SinglyLinkedListNode<T> current = _head;

        while (current != null)
        {
            clone.AddLast(current.Value);
            current = current.Next;
        }

        return clone;
    }
}
