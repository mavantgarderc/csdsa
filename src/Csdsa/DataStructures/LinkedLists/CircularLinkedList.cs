namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Represents a circular singly linked list implementation of <see cref="ILinkedList{T}"/>.
/// The list maintains a reference to the tail node; the head is <c>tail.Next</c>.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public partial class CircularLinkedList<T> : ILinkedList<T>
{
    private SinglyLinkedListNode<T> _tail;
    private int _count;
    private int _version;

    private SinglyLinkedListNode<T> Head
    {
        get
        {
            if (_tail == null)
            {
                return null;
            }

            return _tail.Next;
        }
    }
}
