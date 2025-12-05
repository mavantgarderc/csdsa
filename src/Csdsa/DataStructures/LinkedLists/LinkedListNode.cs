namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Represents a node in a doubly linked list.
/// </summary>
/// <typeparam name="T">The type of the value stored in the node.</typeparam>
public class LinkedListNode<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LinkedListNode{T}"/> class
    /// with the specified value.
    /// </summary>
    /// <param name="value">The value stored in the node.</param>
    public LinkedListNode(T value)
    {
        Value = value;
    }

    /// <summary>
    /// Gets or sets the value stored in the node.
    /// </summary>
    public T Value { get; set; }

    /// <summary>
    /// Gets or sets the next node in the list.
    /// </summary>
    public LinkedListNode<T> Next { get; set; }

    /// <summary>
    /// Gets or sets the previous node in the list.
    /// </summary>
    public LinkedListNode<T> Prev { get; set; }
}
