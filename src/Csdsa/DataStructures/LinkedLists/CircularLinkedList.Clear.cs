namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Clear"/> method for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void Clear()
    {
        _tail = null;
        _count = 0;
        _version++;
    }
}
