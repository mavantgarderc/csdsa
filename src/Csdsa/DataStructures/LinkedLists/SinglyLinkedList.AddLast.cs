namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddLast(T)"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public void AddLast(T item)
    {
        SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(item);

        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }

        _count++;
        _version++;
    }
}
