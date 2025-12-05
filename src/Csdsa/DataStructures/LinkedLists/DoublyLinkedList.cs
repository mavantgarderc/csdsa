namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Represents a doubly linked list implementation of <see cref="ILinkedList{T}"/>.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public partial class DoublyLinkedList<T> : ILinkedList<T>
{
    private LinkedListNode<T> _head;
    private LinkedListNode<T> _tail;
    private int _count;
    private int _version;
}
