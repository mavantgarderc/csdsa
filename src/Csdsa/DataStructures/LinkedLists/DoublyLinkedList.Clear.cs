namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clear"/> method for <see cref="DoublyLinkedList{T}"/>.
/// </summary>
public partial class DoublyLinkedList<T>
{
    /// <inheritdoc />
    public void Clear()
    {
        _head = null;
        _tail = null;
        _count = 0;
        _version++;
    }
}
