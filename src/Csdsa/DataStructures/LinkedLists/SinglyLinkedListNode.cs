namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Represents a node in a singly linked list.
/// </summary>
/// <typeparam name="T">The type of the value stored in the node.</typeparam>
public class SinglyLinkedListNode<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SinglyLinkedListNode{T}"/> class
    /// with the specified value.
    /// </summary>
    /// <param name="value">The value stored in the node.</param>
    public SinglyLinkedListNode(T value)
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
    public SinglyLinkedListNode<T> Next { get; set; }
}
