namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clear"/> method for <see cref="CircularDoublyLinkedList{T}"/>.
/// </summary>
public partial class CircularDoublyLinkedList<T>
{
    /// <inheritdoc />
    public void Clear()
    {
        _head = null;
        _count = 0;
        _version++;
    }
}
