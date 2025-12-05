using System.Collections.Generic;

namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Represents a circular doubly linked list implementation of <see cref="ILinkedList{T}"/>.
/// The list maintains a reference to the head node; the tail is <c>head.Prev</c>.
/// </summary>
/// <typeparam name="T">The element type.</typeparam>
public partial class CircularDoublyLinkedList<T> : ILinkedList<T>
{
    private LinkedListNode<T> _head;
    private int _count;
    private int _version;

    private LinkedListNode<T> Tail
    {
        get
        {
            if (_head == null)
            {
                return null;
            }

            return _head.Prev;
        }
    }
}
