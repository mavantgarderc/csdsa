namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clear"/> method for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
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
