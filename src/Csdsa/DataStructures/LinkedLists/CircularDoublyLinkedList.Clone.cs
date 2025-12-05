namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clone"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public ILinkedList<T> Clone()
    {
        CircularDoublyLinkedList<T> clone = new CircularDoublyLinkedList<T>();

        if (_head == null)
        {
            return clone;
        }

        LinkedListNode<T> current = _head;

        do
        {
            clone.AddLast(current.Value);
            current = current.Next;
        }
        while (!ReferenceEquals(current, _head));

        return clone;
    }
}
