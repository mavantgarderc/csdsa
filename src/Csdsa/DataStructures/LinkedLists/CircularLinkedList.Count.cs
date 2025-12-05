namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="Count"/> property for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public int Count
    {
        get { return _count; }
    }
}
