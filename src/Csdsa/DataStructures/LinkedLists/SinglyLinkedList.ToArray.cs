namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="ToArray"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public T[] ToArray()
    {
        T[] array = new T[_count];
        SinglyLinkedListNode<T> current = _head;

        for (int i = 0; i < _count; i++)
        {
            array[i] = current.Value;
            current = current.Next;
        }

        return array;
    }
}
