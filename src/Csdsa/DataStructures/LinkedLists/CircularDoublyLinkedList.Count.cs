namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Count"/> property for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public int Count
    {
        get { return _count; }
    }
}
