namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddLast(T)"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void AddLast(T item)
    {
        AddFirst(item);

        if (_tail != null)
        {
            _tail = _tail.Next;
        }
    }
}
