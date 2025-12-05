namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Contains(T)"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public bool Contains(T item)
    {
        return Find(item) != null;
    }
}
