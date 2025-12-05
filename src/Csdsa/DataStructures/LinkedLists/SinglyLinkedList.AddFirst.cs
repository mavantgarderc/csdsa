namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddFirst(T)"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public void AddFirst(T item)
    {
        SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(item);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head = newNode;
        }

        _count++;
        _version++;
    }
}
