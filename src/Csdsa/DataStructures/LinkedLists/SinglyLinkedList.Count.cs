namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Count"/> property for <see cref="SinglyLinkedList{T}"/>.
/// </summary>
public partial class SinglyLinkedList<T>
{
    /// <inheritdoc />
    public int Count
    {
        get { return _count; }
    }
}
