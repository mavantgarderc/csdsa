namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddFirst(T)"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void AddFirst(T item)
    {
        SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(item);

        if (_tail == null)
        {
            _tail = newNode;
            newNode.Next = newNode;
        }
        else
        {
            newNode.Next = _tail.Next;
            _tail.Next = newNode;
        }

        _count++;
        _version++;
    }
}
