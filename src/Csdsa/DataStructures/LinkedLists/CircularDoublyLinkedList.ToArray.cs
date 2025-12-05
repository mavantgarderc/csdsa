namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ToArray"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public T[] ToArray()
    {
        T[] array = new T[_count];

        if (_head == null)
        {
            return array;
        }

        LinkedListNode<T> current = _head;

        for (int i = 0; i < _count; i++)
        {
            array[i] = current.Value;
            current = current.Next;
        }

        return array;
    }
}
