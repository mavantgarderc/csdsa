namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ToArray"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public T[] ToArray()
    {
        T[] array = new T[_count];

        if (_tail == null)
        {
            return array;
        }

        SinglyLinkedListNode<T> current = Head;

        for (int i = 0; i < _count; i++)
        {
            array[i] = current.Value;
            current = current.Next;
        }

        return array;
    }
}
