namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Represents a singly linked list implementation of <see cref="ILinkedList{T}"/>.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public partial class SinglyLinkedList<T> : ILinkedList<T>
{
    private SinglyLinkedListNode<T> _head;
    private SinglyLinkedListNode<T> _tail;
    private int _count;
    private int _version;
}
