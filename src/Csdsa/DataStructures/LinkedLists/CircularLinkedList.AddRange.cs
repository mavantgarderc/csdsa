namespace Csdsa.DataStructures.LinkedLists;

/// <summary>
/// Provides the <see cref="AddRange(System.Collections.Generic.IEnumerable{T})"/> method
/// for <see cref="CircularLinkedList{T}"/>.
/// </summary>
public partial class CircularLinkedList<T>
{
    /// <inheritdoc />
    public void AddRange(IEnumerable<T> items)
    {
        ArgumentNullException.ThrowIfNull(items);

        foreach (T item in items)
        {
            AddLast(item);
        }
    }
}
