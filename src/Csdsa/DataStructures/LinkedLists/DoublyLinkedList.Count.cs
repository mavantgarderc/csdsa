namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Count"/> property for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public int Count
    {
        get { return _count; }
    }
}
