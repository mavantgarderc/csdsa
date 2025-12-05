namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clone"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public ILinkedList<T> Clone()
    {
        CircularLinkedList<T> clone = new CircularLinkedList<T>();

        if (_tail == null)
        {
            return clone;
        }

        SinglyLinkedListNode<T> current = Head;
        SinglyLinkedListNode<T> start = current;

        do
        {
            clone.AddLast(current.Value);
            current = current.Next;
        }
        while (!ReferenceEquals(current, start));

        return clone;
    }
}
